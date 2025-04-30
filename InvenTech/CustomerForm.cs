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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

       
        private void LoadCustomerData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT CustomerID, CustomerName, CarriedDebt FROM Customers"; // Müşteri bilgilerini çek
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable); // Veriyi çek

                    // DataGridView’e verileri bağla
                    dgvCustomerList.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                }
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomerData(); // Müşteri verilerini yükle
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txtSearchCustomer.Text;

            string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT CustomerID, CustomerName, CarriedDebt FROM Customers WHERE CustomerName LIKE @SearchQuery"; // Müşteri ismine göre arama
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dgvCustomerList.DataSource = dataTable; // DataGridView'i güncelle
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Arama hatası: " + ex.Message);
                }
            }
        }

        private void dgvCustomerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomerList.Rows[e.RowIndex];

                // Müşteri bilgilerini al
                txtCustomerName.Text = row.Cells["CustomerName"].Value.ToString();
                txtHomePhone.Text = row.Cells["HomePhone"].Value.ToString();
                txtGSMPhone.Text = row.Cells["GSMPhone"].Value.ToString();
                txtWorkPhone.Text = row.Cells["WorkPhone"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                dtpBirthDate.Value = Convert.ToDateTime(row.Cells["BirthDate"].Value); // DateTime Picker’a aktar

                // Veresiye Toplam değerini al ve txtVeresiyeToplam'a yaz
                txtVeresiyeToplam.Text = row.Cells["CarriedDebt"].Value.ToString();  // Burada "CarriedDebt" alanını "VeresiyeToplam" ile değiştirebilirsiniz
            }
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
            decimal carriedDebt = Convert.ToDecimal(txtVeresiyeToplam.Text);  // Devreden Borç
            decimal limit = Convert.ToDecimal(txtLimit.Text);  // Limit Belirle

            string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

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

                    command.ExecuteNonQuery();  // SQL komutunu çalıştırıyoruz

                    MessageBox.Show("Müşteri başarıyla kaydedildi.");
                    LoadCustomerData(); // Veritabanına kaydettikten sonra müşteri verilerini yeniden yükle
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }







        private void dgvCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
