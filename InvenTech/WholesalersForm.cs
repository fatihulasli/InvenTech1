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
    public partial class WholesalersForm : Form
    {
        public WholesalersForm()
        {
            InitializeComponent();
        }

        private DataTable suppliersTable; // Toptancı verilerini saklamak için sınıf düzeyinde tanımlama

        private void WholesalersForm_Load(object sender, EventArgs e)
        {
            // Toptancıları yüklemek için LoadSuppliers metodunu çağırıyoruz
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT SupplierID AS 'Sıra No', SupplierName AS 'Toptancı Adı', Debt AS 'Borç' FROM Suppliers";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable suppliersTable = new DataTable();
                    adapter.Fill(suppliersTable);

                    dgvSuppliers.DataSource = suppliersTable; // DataGridView'e bağla

                    // Toplam borcu güncelle
                    UpdateTotalDebt();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Toptancılar yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }





        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            // Yeni tedarikçi formunu aç
            NewSupplierForm newSupplierForm = new NewSupplierForm();
            newSupplierForm.ShowDialog();

            // Eğer yeni bir tedarikçi eklenirse listeyi güncelle
            LoadSuppliers();
        }
        public void AddSupplier(string supplierName, string contactPerson, string email)
        {
            string query = "INSERT INTO Suppliers (SupplierName, ContactPerson, Email) VALUES (@SupplierName, @ContactPerson, @Email)";
            SqlParameter[] parameters = {
        new SqlParameter("@SupplierName", supplierName),
        new SqlParameter("@ContactPerson", contactPerson),
        new SqlParameter("@Email", email)
    };

            int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Tedarikçi başarıyla eklendi.");
            }
            else
            {
                MessageBox.Show("Tedarikçi eklenirken bir hata oluştu.");
            }
        }

        public void UpdateSupplier(int supplierID, string supplierName, string contactPerson)
        {
            string query = "UPDATE Suppliers SET SupplierName = @SupplierName, ContactPerson = @ContactPerson WHERE SupplierID = @SupplierID";

            SqlParameter[] parameters = {
        new SqlParameter("@SupplierID", supplierID),
        new SqlParameter("@SupplierName", supplierName),
        new SqlParameter("@ContactPerson", contactPerson)
    };

            int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Tedarikçi başarıyla güncellendi.");
            }
            else
            {
                MessageBox.Show("Tedarikçi güncellenirken bir hata oluştu.");
            }
        }


        public void DeleteSupplier(int supplierID)
        {
            string query = "DELETE FROM Suppliers WHERE SupplierID = @SupplierID";

            SqlParameter[] parameters = {
        new SqlParameter("@SupplierID", supplierID)
    };

            int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Tedarikçi başarıyla silindi.");
            }
            else
            {
                MessageBox.Show("Tedarikçi silinirken bir hata oluştu.");
            }
        }



        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count > 0) // Eğer bir satır seçiliyse
            {
                // Seçilen Toptancının ID'sini al
                int supplierID = Convert.ToInt32(dgvSuppliers.SelectedRows[0].Cells["Sıra No"].Value);

                // Kullanıcıya onay mesajı göster
                DialogResult result = MessageBox.Show("Seçilen toptancıyı silmek istediğinizden emin misiniz?",
                                                      "Toptancı Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Veritabanından toptancıyı sil
                    DeleteSupplierFromDatabase(supplierID);

                    // DataGridView'i güncelle
                    LoadSuppliers();

                    MessageBox.Show("Toptancı başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz bir toptancıyı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dgvSuppliers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count > 0) // Eğer bir satır seçilmişse
            {
                DataGridViewRow selectedRow = dgvSuppliers.SelectedRows[0];

                // Boş satır kontrolü
                if (selectedRow.Cells["Sıra No"].Value == null ||
                    selectedRow.Cells["Sıra No"].Value == DBNull.Value ||
                    string.IsNullOrEmpty(selectedRow.Cells["Sıra No"].Value.ToString()))
                {
                    // Eğer boş bir satır seçildiyse, işlemi iptal et ve TextBox'ları temizle
                    ClearTextBoxes();
                    return;
                }

                // Seçilen Toptancının ID'sini al
                int supplierID = Convert.ToInt32(selectedRow.Cells["Sıra No"].Value);

                // Veritabanından bu ID'ye ait bilgileri çek ve TextBox'lara doldur
                LoadSupplierDetails(supplierID);
            }
            else
            {
                // Eğer seçim yoksa TextBox'ları temizle
                ClearTextBoxes();
            }
        }


        private void DeleteSupplierFromDatabase(int supplierID)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Toptancı silme SQL sorgusu
                    string query = "DELETE FROM Suppliers WHERE SupplierID = @SupplierID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SupplierID", supplierID);

                    command.ExecuteNonQuery(); // Sorguyu çalıştır
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Toptancı silinirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void LoadSupplierDetails(int supplierID)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Toptancı bilgilerini almak için SQL sorgusu
                    string query = "SELECT SupplierName, ContactPerson, Email, Phone, Gsm, Fax, Website, TaxOffice, TaxNumber, Address, Notes, Debt " +
                                   "FROM Suppliers WHERE SupplierID = @SupplierID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SupplierID", supplierID);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // TextBox'ları doldur
                        txtSupplierName.Text = reader["SupplierName"].ToString();
                        txtContactPerson.Text = reader["ContactPerson"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        txtPhone.Text = reader["Phone"].ToString();
                        txtGsm.Text = reader["Gsm"].ToString();
                        txtFax.Text = reader["Fax"].ToString();
                        txtWebsite.Text = reader["Website"].ToString();
                        txtTaxOffice.Text = reader["TaxOffice"].ToString();
                        txtTaxNumber.Text = reader["TaxNumber"].ToString();
                        txtAddress.Text = reader["Address"].ToString();
                        txtNotes.Text = reader["Notes"].ToString();
                        txtTotalDebt.Text = reader["Debt"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
        private void UpdateTotalDebt()
        {
            decimal totalDebt = 0;

            // DataGridView'deki her satırda borç değerini topla
            foreach (DataGridViewRow row in dgvSuppliers.Rows)
            {
                // Borç hücresini kontrol et
                if (row.Cells["Borç"].Value != null && decimal.TryParse(row.Cells["Borç"].Value.ToString(), out decimal debt))
                {
                    totalDebt += debt;
                }
            }

            // Toplam borcu TextBox'a yaz
            txtTotalSuppliersDebt.Text = totalDebt.ToString("F2"); // İki ondalıklı sayı formatı
        }

        private void ClearTextBoxes()
        {
            txtSupplierName.Clear();
            txtContactPerson.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtGsm.Clear();
            txtFax.Clear();
            txtWebsite.Clear();
            txtTaxOffice.Clear();
            txtTaxNumber.Clear();
            txtAddress.Clear();
            txtNotes.Clear();
            txtTotalDebt.Clear();
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count > 0)
            {
                // Seçilen satırın SupplierID'sini al
                int supplierID = Convert.ToInt32(dgvSuppliers.SelectedRows[0].Cells["Sıra No"].Value);

                // EditSupplierForm'u aç ve SupplierID'yi geç
                EditSupplierForm editForm = new EditSupplierForm(supplierID);
                editForm.ShowDialog();

                // Form kapanınca tedarikçi listesini yeniden yükle
                LoadSuppliers();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz toptancıyı seçin.");
            }
        }

        private void btnAccountDetails_Click(object sender, EventArgs e)
        {
            // Seçilen toptancı bilgisi alındığında yeni form açılır
            SupplierAccountDetailsForm supplierAccountDetailsForm = new SupplierAccountDetailsForm();
            supplierAccountDetailsForm.ShowDialog(); // Modal (ön planda) olarak açılır
        }

    }
}
