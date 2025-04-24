using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvenTech
{
    public partial class ProductEnterForm : Form
    {
        public ProductEnterForm()
        {
            InitializeComponent();
            LoadProductGroups();
            LoadSuppliers(); // Tedarikçileri yükle
        }

        private void LoadProductGroups()
        {
            // Bağlantı dizesini App.config'den alın
            string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // ProductGroups tablosundan GroupName değerlerini çek
                    string query = "SELECT GroupName FROM ProductGroups";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();
                    cmbProductGroup.Items.Clear(); // Mevcut öğeleri temizle

                    // Verileri okuyarak ComboBox'a ekle
                    while (reader.Read())
                    {
                        cmbProductGroup.Items.Add(reader["GroupName"].ToString());
                    }

                    reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Hatası: " + ex.Message);
                }
            }
        }


        private void LoadSuppliers()
        {
            // Bağlantı dizesini App.config'den al
            string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Suppliers tablosundan SupplierName değerlerini çek
                    string query = "SELECT SupplierName FROM Suppliers";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();
                    cmbSupplierName.Items.Clear(); // Mevcut öğeleri temizle

                    // Verileri okuyarak ComboBox'a ekle
                    while (reader.Read())
                    {
                        cmbSupplierName.Items.Add(reader["SupplierName"].ToString());
                    }

                    reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
            }
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {
        }


        private void btnGenerateBarcodeNo_Click(object sender, EventArgs e)
        {
            // Rastgele bir barkod numarası oluşturma
            Random random = new Random();
            string barcode = random.Next(1000000000, 1999999999).ToString(); // 10 haneli bir barkod numarası
            txtBarcode.Text = barcode;
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbProductGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddNewProductGroup_Click(object sender, EventArgs e)
        {
            // Yeni ürün grubu ismini girmek için InputBox kullan
            string newGroup = Microsoft.VisualBasic.Interaction.InputBox(
                "Lütfen Yeni Ürün Grubu Adını Yazınız",
                "InvenTech All in one!"
            );

            if (string.IsNullOrEmpty(newGroup))
            {
                MessageBox.Show("Ürün grubu adı boş olamaz.");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // ProductGroups tablosuna yeni grup ekle
                    string query = "INSERT INTO ProductGroups (GroupName) VALUES (@GroupName)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@GroupName", newGroup);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        cmbProductGroup.Items.Add(newGroup); // Açılır listeye de ekle
                        MessageBox.Show("Yeni ürün grubu başarıyla veritabanına eklendi.");
                    }
                    else
                    {
                        MessageBox.Show("Ürün grubu eklenirken bir hata oluştu.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Hatası: " + ex.Message);
                }
            }
        }

        private void txtVATRate_TextChanged(object sender, EventArgs e)
        {
            CalculateExcludingVAT();
            CalculateIncludingVAT();
        }

        private void txtPurchasePriceIncludingVAT_TextChanged(object sender, EventArgs e)
        {
            CalculateExcludingVAT();
        }

        private void txtPurchasePriceExcludingVAT_TextChanged(object sender, EventArgs e)
        {
            CalculateIncludingVAT();
        }

        // KDV Dahil fiyata göre KDV Hariç fiyatı hesaplayan metot
        private bool isUpdating = false; // burada daha önce including veya excluding kullanılmıs mı diye bakıyoruz 

        private void CalculateExcludingVAT()
        {
            if (isUpdating) return;
            try
            {
                isUpdating = true;
                if (decimal.TryParse(txtPurchasePriceIncludingVAT.Text, out decimal priceIncludingVAT) &&
                    decimal.TryParse(txtVATRate.Text, out decimal vatRate))
                {
                    decimal priceExcludingVAT = priceIncludingVAT / (1 + vatRate / 100);
                    txtPurchasePriceExcludingVAT.Text = priceExcludingVAT.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while calculating the price: " + ex.Message);
            }
            finally
            {
                isUpdating = false;
            }
        }

        private void CalculateIncludingVAT()
        {
            if (isUpdating) return;
            try
            {
                isUpdating = true;
                if (decimal.TryParse(txtPurchasePriceExcludingVAT.Text, out decimal priceExcludingVAT) &&
                    decimal.TryParse(txtVATRate.Text, out decimal vatRate))
                {
                    decimal priceIncludingVAT = priceExcludingVAT * (1 + vatRate / 100);
                    txtPurchasePriceIncludingVAT.Text = priceIncludingVAT.ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while calculating the price: " + ex.Message);
            }
            finally
            {
                isUpdating = false;
            }
        }


        private void txtSalesPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSecondSalesPrice_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtStockQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbUnit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMinimumStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddNewSupplier_Click(object sender, EventArgs e)
        {
            // Yeni Tedarikçi Formunu aç
            NewSupplierForm newSupplierForm = new NewSupplierForm();
            newSupplierForm.ShowDialog(); // Modal olarak aç
        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int productGroupID = GetProductGroupID(cmbProductGroup.SelectedItem?.ToString());
            string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Barkod numarasına göre ürün olup olmadığını kontrol et
                    string checkQuery = "SELECT StockAmount FROM Products WHERE Barcode = @Barcode";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@Barcode", txtBarcode.Text);

                    SqlDataReader reader = checkCmd.ExecuteReader();

                    if (reader.Read()) // Ürün var, stok miktarını güncelle
                    {
                        int currentStock = Convert.ToInt32(reader["StockAmount"]);
                        reader.Close();

                        int addedQuantity = Convert.ToInt32(txtStockQuantity.Text);  // Kullanıcı tarafından girilen yeni miktar
                        int updatedStock = currentStock + addedQuantity;

                        // Mevcut ürünü güncelle
                        string updateQuery = "UPDATE Products SET StockAmount = @UpdatedStock WHERE Barcode = @Barcode";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, connection);
                        updateCmd.Parameters.AddWithValue("@UpdatedStock", updatedStock);
                        updateCmd.Parameters.AddWithValue("@Barcode", txtBarcode.Text);

                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Stok başarıyla güncellendi.");
                    }
                    else // Ürün yok, yeni ürün ekle
                    {
                        reader.Close();

                        string insertQuery = @"
                    INSERT INTO Products (Barcode, ProductName, ProductCode, ProductGroup, 
                                          PurchasePriceIncludingVAT, PurchasePriceExcludingVAT, SalesPrice, 
                                          SecondSalesPrice, VATRate, StockAmount, Unit, MinimumStock, 
                                          SupplierName, PaymentMethod, ProductGroupID)
                    VALUES (@Barcode, @ProductName, @ProductCode, @ProductGroup, 
                            @PurchasePriceIncludingVAT, @PurchasePriceExcludingVAT, @SalesPrice, 
                            @SecondSalesPrice, @VATRate, @StockAmount, @Unit, @MinimumStock, 
                            @SupplierName, @PaymentMethod, @ProductGroupID)";

                        SqlCommand insertCmd = new SqlCommand(insertQuery, connection);
                        insertCmd.Parameters.AddWithValue("@Barcode", txtBarcode.Text);
                        insertCmd.Parameters.AddWithValue("@ProductName", txtProductName.Text);
                        insertCmd.Parameters.AddWithValue("@ProductCode", txtProductCode.Text);
                        insertCmd.Parameters.AddWithValue("@ProductGroup", cmbProductGroup.SelectedItem?.ToString());
                        insertCmd.Parameters.AddWithValue("@PurchasePriceIncludingVAT", Convert.ToDecimal(txtPurchasePriceIncludingVAT.Text));
                        insertCmd.Parameters.AddWithValue("@PurchasePriceExcludingVAT", Convert.ToDecimal(txtPurchasePriceExcludingVAT.Text));
                        insertCmd.Parameters.AddWithValue("@SalesPrice", Convert.ToDecimal(txtSalesPrice.Text));
                        insertCmd.Parameters.AddWithValue("@SecondSalesPrice", Convert.ToDecimal(txtSecondSalesPrice.Text));
                        insertCmd.Parameters.AddWithValue("@VATRate", Convert.ToDecimal(txtVATRate.Text));
                        insertCmd.Parameters.AddWithValue("@StockAmount", Convert.ToInt32(txtStockQuantity.Text)); // Yeni ürün için stok miktarı
                        insertCmd.Parameters.AddWithValue("@Unit", txtUnit.Text);
                        insertCmd.Parameters.AddWithValue("@MinimumStock", Convert.ToInt32(txtMinimumStock.Text));
                        insertCmd.Parameters.AddWithValue("@SupplierName", cmbSupplierName.SelectedItem?.ToString());
                        insertCmd.Parameters.AddWithValue("@PaymentMethod", cmbPaymentMethod.SelectedItem?.ToString());
                        insertCmd.Parameters.AddWithValue("@ProductGroupID", productGroupID);

                        insertCmd.ExecuteNonQuery();

                        MessageBox.Show("Yeni ürün başarıyla kaydedildi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }


        private int GetProductGroupID(string groupName)
        {
            int productGroupID = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT ProductGroupID FROM ProductGroups WHERE GroupName = @GroupName";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@GroupName", groupName);
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        productGroupID = Convert.ToInt32(result);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
            }

            return productGroupID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSearchByProductName_Click(object sender, EventArgs e)
        {

        }

        private void btnInvoiceEntry_Click(object sender, EventArgs e)
        {

        }

        private void ProductEnterForm_Load(object sender, EventArgs e)
        {

        }

        private void ClearProductDetails()
        {
            // Ürünle ilgili TextBox'ları temizleyin
            txtProductName.Clear();
            txtSalesPrice.Clear();
            txtStockQuantity.Clear();
            txtUnit.Clear();
        }


        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            // Eğer Enter tuşuna basılmışsa
            if (e.KeyCode == Keys.Enter)
            {
                // Barkod numarasını al
                string barcode = txtBarcode.Text.Trim();

                // Eğer barkod boş değilse, kontrol et
                if (!string.IsNullOrEmpty(barcode))
                {
                    // Ürün var mı kontrol et
                    CheckIfProductExists(barcode);
                }
                else
                {
                    MessageBox.Show("Barkod numarasını giriniz.");
                }
            }
        }




        private void CheckIfProductExists(string barcode)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Barkod numarasına göre sorgu
                    string query = "SELECT COUNT(*) FROM Products_Backup WHERE Barcode = @Barcode";  // 'Products' yerine 'Products_Backup' kullanalım
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Barcode", barcode);

                    int productCount = (int)command.ExecuteScalar();

                    // Eğer ürün varsa
                    if (productCount > 0)
                    {
                        // Ürün mevcut, işlem yapılabilir
                        MessageBox.Show("Bu barkod numarasına sahip bir ürün bulunuyor.");
                    }
                    else
                    {
                        // Ürün bulunamadı, yeni ürün eklenebilir
                        MessageBox.Show("Bu barkod numarasına sahip bir ürün bulunamadı. Yeni ürün ekleyebilirsiniz.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }





    }
}
