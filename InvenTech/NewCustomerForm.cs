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
    public partial class NewCustomerForm : Form
    {
        public NewCustomerForm()
        {
            InitializeComponent();
        }

        private void NewCustomerForm_Load(object sender, EventArgs e)
        {

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // Formdan alınan müşteri bilgilerini değişkenlere atıyoruz
            string customerName = txtCustomerName.Text;
            string homePhone = txtHomePhone.Text;
            string gsmPhone = txtGSMPhone.Text;
            string workPhone = txtWorkPhone.Text;
            string address = txtAddress.Text;
            string email = txtEmail.Text;
            DateTime birthDate = dtpBirthDate.Value;  // Doğum tarihi
            decimal carriedDebt = Convert.ToDecimal(txtCarriedDebt.Text);  // Devreden Borç
            decimal limit = Convert.ToDecimal(txtLimit.Text);  // Limit Belirle

            // Veritabanı bağlantı dizesini App.config'den alıyoruz
            string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

            // Veritabanına bağlanıyoruz
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();  // Bağlantıyı açıyoruz

                    // SQL sorgusunu yazıyoruz
                    string query = @"
                INSERT INTO Customers 
                (CustomerName, HomePhone, GSMPhone, WorkPhone, Address, Email, BirthDate, CarriedDebt, Limit)
                VALUES 
                (@CustomerName, @HomePhone, @GSMPhone, @WorkPhone, @Address, @Email, @BirthDate, @CarriedDebt, @Limit)";

                    // SQL komutunu hazırlıyoruz
                    SqlCommand command = new SqlCommand(query, connection);

                    // Parametreleri ekliyoruz
                    command.Parameters.AddWithValue("@CustomerName", customerName);
                    command.Parameters.AddWithValue("@HomePhone", homePhone);
                    command.Parameters.AddWithValue("@GSMPhone", gsmPhone);
                    command.Parameters.AddWithValue("@WorkPhone", workPhone);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@BirthDate", birthDate);
                    command.Parameters.AddWithValue("@CarriedDebt", carriedDebt);
                    command.Parameters.AddWithValue("@Limit", limit);

                    // Komutu çalıştırıyoruz
                    command.ExecuteNonQuery();

                    // İşlem başarılıysa kullanıcıya mesaj veriyoruz
                    MessageBox.Show("Müşteri başarıyla eklendi.");
                }
                catch (SqlException ex)
                {
                    // Hata olursa kullanıcıya uyarı veriyoruz
                    MessageBox.Show("SQL Hatası: " + ex.Message);
                }
            }
        }

        private void ClearForm()
        {
            txtCustomerName.Clear();
            txtHomePhone.Clear();
            txtGSMPhone.Clear();
            txtWorkPhone.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtCarriedDebt.Clear();
            txtLimit.Clear();
            dtpBirthDate.Value = DateTime.Now;  // Doğum tarihi varsayılan olarak bugünü alacak
        }


    }
}
 