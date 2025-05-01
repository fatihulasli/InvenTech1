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

                    // AutoGenerateColumns özelliğini true yapıyoruz
                    dgvCustomerList.AutoGenerateColumns = true;

                    // DataGridView’e verileri bağla
                    dgvCustomerList.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                }
            }
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

                // Doğum tarihini TextBox'a aktaralım
                if (row.Cells["BirthDate"].Value != DBNull.Value)
                    txtBirthDate.Text = Convert.ToDateTime(row.Cells["BirthDate"].Value).ToString("dd.MM.yyyy");
                else
                    txtBirthDate.Text = "";  // Eğer tarih yoksa boş bırak

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

            // Doğum tarihini TextBox'tan alalım
            DateTime birthDate;
            if (!DateTime.TryParse(txtBirthDate.Text, out birthDate))
            {
                MessageBox.Show("Geçerli bir doğum tarihi giriniz.");
                return; // Eğer geçerli bir tarih değilse, işlemi durduruyoruz
            }

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
                    command.Parameters.AddWithValue("@BirthDate", birthDate);  // TextBox'tan alınan doğum tarihi
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

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            // NewCustomerForm formunu oluşturuyoruz
            NewCustomerForm newCustomerForm = new NewCustomerForm();

            // Formu modaldan açıyoruz, yani kullanıcı işlemi bitene kadar CustomerForm'a geri dönemez
            newCustomerForm.ShowDialog();

            // Yeni müşteri ekledikten sonra verileri tekrar yükleyelim
            LoadCustomerData();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomerData(); // Müşteri verilerini yükle
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomerList.SelectedRows.Count > 0)
            {
                // Seçili müşteri ID'sini al
                int customerID = Convert.ToInt32(dgvCustomerList.SelectedRows[0].Cells["CustomerID"].Value);

                string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // SQL sorgusu
                        string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@CustomerID", customerID);

                        command.ExecuteNonQuery();  // SQL komutunu çalıştırıyoruz

                        MessageBox.Show("Müşteri başarıyla silindi.");
                        LoadCustomerData();  // Silme işlemi sonrası DataGridView'i güncelle
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Silme hatası: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir müşteri seçin.");
            }
        }

        private void dgvCustomerList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomerList.SelectedRows.Count > 0)
            {
                // Seçilen satırdaki müşteri ID'sini al
                int customerID = Convert.ToInt32(dgvCustomerList.SelectedRows[0].Cells["CustomerID"].Value);

                // Veritabanından bu müşteri bilgilerini al
                GetCustomerDetails(customerID);
            }
        }

        private void GetCustomerDetails(int customerID)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Veritabanından müşteri bilgilerini çekme sorgusu
                    string query = "SELECT * FROM Customers WHERE CustomerID = @CustomerID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CustomerID", customerID);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Null kontrolü ile formdaki alanlara veri atama
                        txtCustomerName.Text = reader["CustomerName"] != DBNull.Value ? reader["CustomerName"].ToString() : "";
                        txtHomePhone.Text = reader["HomePhone"] != DBNull.Value ? reader["HomePhone"].ToString() : "";
                        txtGSMPhone.Text = reader["GSMPhone"] != DBNull.Value ? reader["GSMPhone"].ToString() : "";
                        txtWorkPhone.Text = reader["WorkPhone"] != DBNull.Value ? reader["WorkPhone"].ToString() : "";
                        txtAddress.Text = reader["Address"] != DBNull.Value ? reader["Address"].ToString() : "";
                        txtNotes.Text = reader["Notes"] != DBNull.Value ? reader["Notes"].ToString() : "";
                        txtEmail.Text = reader["Email"] != DBNull.Value ? reader["Email"].ToString() : "";

                        // Doğum tarihi ve kayıt tarihi TextBox'larına yazalım
                        if (DateTime.TryParse(reader["BirthDate"].ToString(), out DateTime birthDate))
                            txtBirthDate.Text = birthDate.ToString("dd.MM.yyyy");
                        else
                            txtBirthDate.Text = "";  // Boş ise, TextBox'ı boş bırakıyoruz

                        if (DateTime.TryParse(reader["RegistrationDate"].ToString(), out DateTime registrationDate))
                            txtRegistrationDate.Text = registrationDate.ToString("dd.MM.yyyy");
                        else
                            txtRegistrationDate.Text = "";  // Boş ise, TextBox'ı boş bırakıyoruz

                        // Diğer alanlar için de benzer şekilde değerler atayın
                        txtLimit.Text = reader["Limit"] != DBNull.Value ? reader["Limit"].ToString() : "";
                        txtVeresiyeToplam.Text = reader["CarriedDebt"] != DBNull.Value ? reader["CarriedDebt"].ToString() : "";  // CarriedDebt
                        txtKalanTaksitToplam.Text = reader["KalanTaksitToplam"] != DBNull.Value ? reader["KalanTaksitToplam"].ToString() : "";  // KalanTaksitToplam

                        // TotalDebt hesaplama (CarriedDebt + KalanTaksitToplam)
                        decimal carriedDebt = reader["CarriedDebt"] != DBNull.Value ? Convert.ToDecimal(reader["CarriedDebt"]) : 0;
                        decimal kalanTaksitToplam = reader["KalanTaksitToplam"] != DBNull.Value ? Convert.ToDecimal(reader["KalanTaksitToplam"]) : 0;
                        decimal totalDebt = carriedDebt + kalanTaksitToplam;

                        // TotalDebt'i formdaki alanına yazıyoruz
                        txtTotalDebt.Text = totalDebt.ToString("0.00");
                    }
                    else
                    {
                        MessageBox.Show("Müşteri bulunamadı.");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı hatası: " + ex.Message);
                }
            }
        }






    }
}