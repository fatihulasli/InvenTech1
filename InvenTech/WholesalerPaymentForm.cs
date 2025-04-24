using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InvenTech
{
    public partial class WholesalerPaymentForm : Form
    {
        private int supplierID;  // SupplierID'yi sınıf düzeyinde tanımla

        // Constructor, SupplierID'yi alacak
        public WholesalerPaymentForm(int supplierId)
        {
            InitializeComponent();
            supplierID = supplierId; // Parametreyi sınıf değişkenine ata
        }

        private void WholesalerPaymentForm_Load(object sender, EventArgs e)
        {
            // supplierID'yi kullanarak gerekli işlemleri yapabilirsiniz
            MessageBox.Show("Selected Supplier ID: " + supplierID);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        INSERT INTO Payments (SupplierID, PaymentAmount, PaymentDate, PaymentTime, PaymentMethod, Description)
                        VALUES (@SupplierID, @Amount, @Date, @Time, @PaymentMethod, @Description)";

                    SqlCommand command = new SqlCommand(query, connection);

                    // Parametreleri ekle
                    command.Parameters.AddWithValue("@SupplierID", supplierID); // supplierID formdan alınacak
                    command.Parameters.AddWithValue("@Amount", Convert.ToDecimal(txtAmount.Text)); // Ödeme tutarı
                    command.Parameters.AddWithValue("@Date", dtpDate.Value); // Tarih
                    command.Parameters.AddWithValue("@Time", dtpTime.Value.ToString("HH:mm")); // Saat formatı
                    command.Parameters.AddWithValue("@PaymentMethod", cmbPaymentMethod.SelectedItem.ToString()); // Ödeme yöntemi
                    command.Parameters.AddWithValue("@Description", txtDescription.Text); // Açıklama

                    // Sorguyu çalıştır
                    command.ExecuteNonQuery(); // SQL sorgusunu çalıştır

                    MessageBox.Show("Ödeme başarılı bir şekilde kaydedildi!");
                    this.Close();  // Formu kapat
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);  // Hata mesajı göster
            }
        }

        // Vazgeç butonuna tıklanınca formu kapat
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
