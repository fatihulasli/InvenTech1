using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
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

        // Tab sırasını ayarlayan fonksiyonu ekliyoruz
        private void SetTabIndex()
        {
            // Tab sırasını ayarlayalım
            txtBarcode.TabIndex = 0;  // Barkod No
            txtProductName.TabIndex = 1;  // Ürün Adı
            txtProductCode.TabIndex = 2;  // Ürün Kodu - Açıklama
            cmbProductGroup.TabIndex = 3;  // Ürün Grubu Seç
            txtVATRate.TabIndex = 4;  // Vergi Oranı
            txtPurchasePriceIncludingVAT.TabIndex = 5;  // Alış Fiyatı (KDV Dahil)
            txtPurchasePriceExcludingVAT.TabIndex = 6;  // Alış Fiyatı (KDV Hariç)
            txtSalesPrice.TabIndex = 7;  // Satış Fiyatı
            txtSecondSalesPrice.TabIndex = 8;  // İkinci Satış Fiyatı
            txtStockQuantity.TabIndex = 9;  // Mevcut Stok Miktarı
            txtMinimumStock.TabIndex = 10;  // Minimum Stok Miktarı
            txtStockEklenecek.TabIndex = 11;  // Eklenecek Miktar
            txtUnit.TabIndex = 12;  // Ölçü Birimi  (Burada `txtUnit` kullanıyoruz)
            cmbSupplierName.TabIndex = 13;  // Toptancı Adı
            cmbPaymentMethod.TabIndex = 14;  // Ödeme Yöntemi
        }


        // Form yüklendiğinde tab sırasını ayarla
     

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
            // 1. BOŞ ALAN KONTROLÜ EKLİYORUZ
            if (string.IsNullOrWhiteSpace(txtBarcode.Text) ||
                string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(txtProductCode.Text) ||
                cmbProductGroup.SelectedItem == null ||
                cmbSupplierName.SelectedItem == null ||
                cmbPaymentMethod.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm zorunlu alanları doldurun!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Eksik bilgi varsa devam etmeden çık!
            }

            int productGroupID = GetProductGroupID(cmbProductGroup.SelectedItem?.ToString());
            string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Barkod numarasına göre ürün olup olmadığını kontrol et
                    string checkQuery = "SELECT StockAmount FROM Products_Backup WHERE Barcode = @Barcode";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@Barcode", txtBarcode.Text.Trim());

                    SqlDataReader reader = checkCmd.ExecuteReader();

                    if (reader.Read()) // Ürün varsa, stok güncellenecek
                    {
                        int currentStock = Convert.ToInt32(reader["StockAmount"]);
                        reader.Close();

                        int addedQuantity = 0;
                        int.TryParse(txtStockEklenecek.Text, out addedQuantity);  // txtStockQuantity değil artık txtStockEklenecek olacak!
                        int updatedStock = currentStock + addedQuantity;

                        // Mevcut ürünü güncelle
                        string updateQuery = "UPDATE Products_Backup SET StockAmount = @UpdatedStock WHERE Barcode = @Barcode";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, connection);
                        updateCmd.Parameters.AddWithValue("@UpdatedStock", updatedStock);
                        updateCmd.Parameters.AddWithValue("@Barcode", txtBarcode.Text.Trim());

                        updateCmd.ExecuteNonQuery();

                        SystemSounds.Asterisk.Play(); // Güncelleme sesi (yumuşak blip)
                        MessageBox.Show("Stok başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearProductDetails();

                    }
                    else // Ürün yoksa, yeni ürün eklenir
                    {
                        reader.Close();

                        // Şimdi verileri güvenli şekilde alalım
                        decimal purchasePriceIncludingVAT = 0;
                        decimal.TryParse(txtPurchasePriceIncludingVAT.Text, out purchasePriceIncludingVAT);

                        decimal purchasePriceExcludingVAT = 0;
                        decimal.TryParse(txtPurchasePriceExcludingVAT.Text, out purchasePriceExcludingVAT);

                        decimal salesPrice = 0;
                        decimal.TryParse(txtSalesPrice.Text, out salesPrice);

                        decimal secondSalesPrice = 0;
                        decimal.TryParse(txtSecondSalesPrice.Text, out secondSalesPrice);

                        decimal vatRate = 0;
                        decimal.TryParse(txtVATRate.Text, out vatRate);

                        int minimumStock = 0;
                        int.TryParse(txtMinimumStock.Text, out minimumStock);

                        int stockAmount = 0;
                        int.TryParse(txtStockEklenecek.Text, out stockAmount);

                        string insertQuery = @"
                    INSERT INTO Products_Backup (Barcode, ProductName, ProductCode, ProductGroup, 
                                          PurchasePriceIncludingVAT, PurchasePriceExcludingVAT, SalesPrice, 
                                          SecondSalesPrice, VATRate, StockAmount, Unit, MinimumStock, 
                                          SupplierName, PaymentMethod, ProductGroupID)
                    VALUES (@Barcode, @ProductName, @ProductCode, @ProductGroup, 
                            @PurchasePriceIncludingVAT, @PurchasePriceExcludingVAT, @SalesPrice, 
                            @SecondSalesPrice, @VATRate, @StockAmount, @Unit, @MinimumStock, 
                            @SupplierName, @PaymentMethod, @ProductGroupID)";

                        SqlCommand insertCmd = new SqlCommand(insertQuery, connection);
                        insertCmd.Parameters.AddWithValue("@Barcode", txtBarcode.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@ProductCode", txtProductCode.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@ProductGroup", cmbProductGroup.SelectedItem?.ToString());
                        insertCmd.Parameters.AddWithValue("@PurchasePriceIncludingVAT", purchasePriceIncludingVAT);
                        insertCmd.Parameters.AddWithValue("@PurchasePriceExcludingVAT", purchasePriceExcludingVAT);
                        insertCmd.Parameters.AddWithValue("@SalesPrice", salesPrice);
                        insertCmd.Parameters.AddWithValue("@SecondSalesPrice", secondSalesPrice);
                        insertCmd.Parameters.AddWithValue("@VATRate", vatRate);
                        insertCmd.Parameters.AddWithValue("@StockAmount", stockAmount);
                        insertCmd.Parameters.AddWithValue("@Unit", txtUnit.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@MinimumStock", minimumStock);
                        insertCmd.Parameters.AddWithValue("@SupplierName", cmbSupplierName.SelectedItem?.ToString());
                        insertCmd.Parameters.AddWithValue("@PaymentMethod", cmbPaymentMethod.SelectedItem?.ToString());
                        insertCmd.Parameters.AddWithValue("@ProductGroupID", productGroupID);

                        insertCmd.ExecuteNonQuery();

                        SystemSounds.Exclamation.Play(); // Yeni kayıt sesi (hafif dikkat sesi)
                        MessageBox.Show("Yeni ürün başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearProductDetails();

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
            ProductSearchForm searchForm = new ProductSearchForm();  // Yeni arama formu açıyoruz

            if (searchForm.ShowDialog() == DialogResult.OK)          // Kullanıcı bir ürün seçip OK'e bastıysa
            {
                string selectedBarcode = searchForm.SelectedBarcode;

                if (!string.IsNullOrEmpty(selectedBarcode))
                {
                    txtBarcode.Text = selectedBarcode;              // Barkodu ana forma yaz
                    CheckIfProductExists(selectedBarcode);          // Barkoda göre ürünü otomatik getir
                }
            }
        }


        private void btnInvoiceEntry_Click(object sender, EventArgs e)
        {

        }

        private void ProductEnterForm_Load(object sender, EventArgs e)
        {
            // Form ilk açıldığında
            lblStockQuantity.Visible = true;
            txtStockQuantity.Visible = true;
            // Tab sırasını ayarla
            SetTabIndex();

            lblEklenecekMiktarBilgi.Visible = false;
            txtStockEklenecek.Visible = false;
            lblOldStock.Visible = false;
            lblNewStock.Visible = false;
        }



        private void ClearProductDetails()
        {
            txtBarcode.Clear();
            txtProductName.Clear();
            txtProductCode.Clear();
            cmbProductGroup.SelectedIndex = -1;
            txtPurchasePriceIncludingVAT.Clear();
            txtPurchasePriceExcludingVAT.Clear();
            txtSalesPrice.Clear();
            txtSecondSalesPrice.Clear();
            txtVATRate.Clear();
            txtStockEklenecek.Clear();
            txtUnit.Clear();
            txtMinimumStock.Clear();
            cmbSupplierName.SelectedIndex = -1;
            cmbPaymentMethod.SelectedIndex = -1;

            // Görünürlük ayarları
            lblEklenecekMiktarBilgi.Visible = false;
            txtStockEklenecek.Visible = false;
            lblOldStock.Visible = false;
            lblNewStock.Visible = false;

            lblStockQuantity.Visible = true;
            txtStockQuantity.Visible = true;
            txtBarcode.Focus(); // Kayıt sonrası direk barkoda odaklanır!
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

                    // Barkoda göre ürünleri seç
                    string query = @"SELECT ProductName, ProductCode, ProductGroup, 
                             PurchasePriceIncludingVAT, PurchasePriceExcludingVAT, 
                             SalesPrice, SecondSalesPrice, VATRate, StockAmount, 
                             Unit, MinimumStock, SupplierName, PaymentMethod
                             FROM Products_Backup
                             WHERE Barcode = @Barcode";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Barcode", barcode);

                    SqlDataReader reader = command.ExecuteReader();

                    // Eğer ürün varsa
                    if (reader.Read())
                    {
                        // Ürün bilgilerini forma aktar
                        txtProductName.Text = reader["ProductName"].ToString();
                        txtProductCode.Text = reader["ProductCode"].ToString();
                        cmbProductGroup.Text = reader["ProductGroup"].ToString();
                        txtPurchasePriceIncludingVAT.Text = reader["PurchasePriceIncludingVAT"].ToString();
                        txtPurchasePriceExcludingVAT.Text = reader["PurchasePriceExcludingVAT"].ToString();
                        txtSalesPrice.Text = reader["SalesPrice"].ToString();
                        txtSecondSalesPrice.Text = reader["SecondSalesPrice"].ToString();
                        txtVATRate.Text = reader["VATRate"].ToString();
                        txtUnit.Text = reader["Unit"].ToString();
                        txtMinimumStock.Text = reader["MinimumStock"].ToString();
                        cmbSupplierName.Text = reader["SupplierName"].ToString();
                        cmbPaymentMethod.Text = reader["PaymentMethod"].ToString();

                        // Ürün bilgilerini kullanıcı değiştiremesin
                        txtProductName.ReadOnly = true;
                        txtProductCode.ReadOnly = true;
                        cmbProductGroup.Enabled = false;
                        txtPurchasePriceIncludingVAT.ReadOnly = false;
                        txtPurchasePriceExcludingVAT.ReadOnly = false;
                        txtSalesPrice.ReadOnly = false;
                        txtSecondSalesPrice.ReadOnly = false;
                        txtVATRate.ReadOnly = true;
                        txtUnit.ReadOnly = true;
                        txtMinimumStock.ReadOnly = true;
                        cmbSupplierName.Enabled = false;
                        cmbPaymentMethod.Enabled = false;

                        // Stok bilgilerini ayarla
                        int eskiStok = Convert.ToInt32(reader["StockAmount"]);
                        lblOldStock.Text = $"Eski Stok: {eskiStok}";
                        txtStockEklenecek.Clear();  // Böyle yapınca boş gelir                        

                        // Görünürlük ayarları
                        lblEklenecekMiktarBilgi.Visible = true;
                        txtStockEklenecek.Visible = true;
                        lblOldStock.Visible = true;
                        lblNewStock.Visible = true;

                        lblStockQuantity.Visible = false;
                        txtStockQuantity.Visible = false;

                        HesaplaYeniStok(eskiStok);
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("Bu barkod numarasına sahip bir ürün bulunamadı. Yeni ürün ekleyebilirsiniz.");
                        txtProductName.ReadOnly = false;
                        txtProductCode.ReadOnly = false;
                        cmbProductGroup.Enabled = true;
                        txtPurchasePriceIncludingVAT.ReadOnly = false;
                        txtPurchasePriceExcludingVAT.ReadOnly = false;
                        txtSalesPrice.ReadOnly = false;
                        txtSecondSalesPrice.ReadOnly = false;
                        txtVATRate.ReadOnly = false;
                        txtUnit.ReadOnly = false;
                        txtMinimumStock.ReadOnly = false;
                        cmbSupplierName.Enabled = true;
                        cmbPaymentMethod.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }




        private void HesaplaYeniStok(int eskiStok)
        {
            int eklenecekMiktar = 0;
            int.TryParse(txtStockEklenecek.Text, out eklenecekMiktar);

            int yeniStok = eskiStok + eklenecekMiktar;
            lblNewStock.Text = $"Yeni Stok: {yeniStok}";
        }



        private void txtStockEklenecek_TextChanged(object sender, EventArgs e)
        {
            if (lblOldStock.Visible && int.TryParse(lblOldStock.Text.Replace("Eski Stok: ", ""), out int eskiStok))
            {
                HesaplaYeniStok(eskiStok);
            }
        }

        private void lblEklenecekMiktarBilgi_Click(object sender, EventArgs e)
        {

        }
    }
}
