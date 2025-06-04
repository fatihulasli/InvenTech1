using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace InvenTech
{
    public partial class SalesForm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;
        private int selectedCustomerId = -1;

        public SalesForm()
        {
            InitializeComponent();

            // Event bağlamaları
            btnSelectCustomer.Click += BtnSelectCustomer_Click;
            btnSearchProduct.Click += BtnSearchProduct_Click;
            btnCancelProduct.Click += BtnCancelProduct_Click;
            btnConfirmSale.Click += BtnConfirmSale_Click;
            btnCancelSale.Click += BtnCancelSale_Click;
            txtBarcode.KeyDown += TxtBarcode_KeyDown;
            txtQuantity.KeyDown += TxtQuantity_KeyDown;
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;

            SetupGrid();
            ResetForm();
        }

        private void SetupGrid()
        {
            dataGridView1.Columns["Barcode"].ReadOnly = true;
            dataGridView1.Columns["ProductName"].ReadOnly = true;
            dataGridView1.Columns["Stock"].ReadOnly = true;
            dataGridView1.Columns["Price"].ReadOnly = true;
            dataGridView1.Columns["Total"].ReadOnly = true;
        }

        private void ResetForm()
        {
            txtBarcode.Clear();
            txtQuantity.Text = "1";
            lblTotalAmount.Text = "0.00 ₺";
            dataGridView1.Rows.Clear();
            selectedCustomerId = -1;
            btnSelectCustomer.Text = "Müşteri Seç";
            rbCash.Checked = true;
        }

        private void BtnSelectCustomer_Click(object sender, EventArgs e)
        {
            using (CustomerForm cf = new CustomerForm())
            {
                if (cf.ShowDialog() == DialogResult.OK)
                {
                    selectedCustomerId = cf.SelectedCustomerId;
                    btnSelectCustomer.Text = cf.SelectedCustomerName;
                }
            }
        }

        private void TxtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barcode = txtBarcode.Text.Trim();
                int quantity = int.TryParse(txtQuantity.Text, out int q) ? q : 1;
                AddProductToCart(barcode, quantity);
                txtBarcode.Clear();
                txtBarcode.Focus();
                e.Handled = true;
            }
        }

        private void TxtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBarcode.Focus();
                e.Handled = true;
            }
        }

        private void AddProductToCart(string barcode, int quantity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ProductName, StockAmount, SalesPrice FROM Products_Backup WHERE Barcode = @barcode";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@barcode", barcode);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string productName = reader["ProductName"].ToString();
                    int stock = Convert.ToInt32(reader["StockAmount"]);
                    decimal price = Convert.ToDecimal(reader["SalesPrice"]);
                    reader.Close();

                    if (quantity > stock)
                    {
                        MessageBox.Show("Yeterli stok yok!");
                        return;
                    }

                    // Sepette aynı ürün varsa miktarı güncelle
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells["Barcode"].Value.ToString() == barcode)
                        {
                            int existingQty = Convert.ToInt32(row.Cells["Quantity"].Value);
                            int newQty = existingQty + quantity;
                            if (newQty > stock)
                            {
                                MessageBox.Show("Yeterli stok yok!");
                                return;
                            }
                            row.Cells["Quantity"].Value = newQty;
                            row.Cells["Total"].Value = newQty * price;
                            UpdateTotalAmount();
                            return;
                        }
                    }

                    // Yeni ürün ekle
                    dataGridView1.Rows.Add(barcode, productName, stock, price, quantity, price * quantity);
                    UpdateTotalAmount();
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Ürün bulunamadı!");
                }
            }
        }

        private void UpdateTotalAmount()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDecimal(row.Cells["Total"].Value);
            }
            lblTotalAmount.Text = total.ToString("C2");
        }

        private void BtnConfirmSale_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == -1)
            {
                MessageBox.Show("Lütfen müşteri seçin.");
                return;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Sepet boş.");
                return;
            }

            string paymentMethod = rbCash.Checked ? "Nakit" : rbCard.Checked ? "Kredi Kartı" : "Veresiye";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string insertSale = "INSERT INTO Sales (CustomerID, SaleDate, PaymentMethod, TotalAmount) OUTPUT INSERTED.SaleID VALUES (@CustomerID, @SaleDate, @PaymentMethod, @TotalAmount)";
                    SqlCommand cmdSale = new SqlCommand(insertSale, conn, transaction);
                    cmdSale.Parameters.AddWithValue("@CustomerID", selectedCustomerId);
                    cmdSale.Parameters.AddWithValue("@SaleDate", DateTime.Now);
                    cmdSale.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                    decimal totalAmount = decimal.Parse(lblTotalAmount.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);
                    cmdSale.Parameters.AddWithValue("@TotalAmount", totalAmount);

                    int saleId = (int)cmdSale.ExecuteScalar();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        string barcode = row.Cells["Barcode"].Value.ToString();
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                        decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                        string insertItem = "INSERT INTO SaleItems (SaleID, Barcode, Quantity, UnitPrice) VALUES (@SaleID, @Barcode, @Quantity, @UnitPrice)";
                        SqlCommand cmdItem = new SqlCommand(insertItem, conn, transaction);
                        cmdItem.Parameters.AddWithValue("@SaleID", saleId);
                        cmdItem.Parameters.AddWithValue("@Barcode", barcode);
                        cmdItem.Parameters.AddWithValue("@Quantity", quantity);
                        cmdItem.Parameters.AddWithValue("@UnitPrice", price);
                        cmdItem.ExecuteNonQuery();

                        string updateStock = "UPDATE Products_Backup SET StockAmount = StockAmount - @Quantity WHERE Barcode = @Barcode";
                        SqlCommand cmdStock = new SqlCommand(updateStock, conn, transaction);
                        cmdStock.Parameters.AddWithValue("@Quantity", quantity);
                        cmdStock.Parameters.AddWithValue("@Barcode", barcode);
                        cmdStock.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Satış başarıyla tamamlandı.");
                    ResetForm();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Satış işlemi sırasında hata oluştu: " + ex.Message);
                }
            }
        }

        private void BtnCancelSale_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void BtnSearchProduct_Click(object sender, EventArgs e)
        {
            using (ProductSearchForm searchForm = new ProductSearchForm())
            {
                if (searchForm.ShowDialog() == DialogResult.OK)
                {
                    string selectedBarcode = searchForm.SelectedBarcode;
                    txtBarcode.Text = selectedBarcode;
                    txtQuantity.Focus();
                }
            }
        }

        private void BtnCancelProduct_Click(object sender, EventArgs e)
        {
            txtBarcode.Clear();
            txtQuantity.Text = "1";
            txtBarcode.Focus();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                UpdateTotalAmount();
            }
        }
    }
}
