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
    public partial class EditSupplierForm : Form
    {
        private int supplierID;

        // Formu toptancı verileri ile başlatmak için constructor
        public EditSupplierForm(int id)
        {
            InitializeComponent();
            supplierID = id;
            LoadSupplierData(id);
        }

        // Toptancı verilerini form alanlarına yüklemek


        private void LoadSupplierData(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Suppliers WHERE SupplierID = @SupplierID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SupplierID", id);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
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
                        txtDebt.Text = reader["Debt"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        // Güncellenen verileri kaydetmek için Save butonuna tıklanıldığında
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Veritabanı bağlantı dizesini al
            string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL UPDATE komutu
                    string updateQuery = "UPDATE Suppliers SET " +
                                         "SupplierName = @SupplierName, " +
                                         "ContactPerson = @ContactPerson, " +
                                         "Email = @Email, " +
                                         "Phone = @Phone, " +
                                         "Gsm = @Gsm, " +
                                         "Fax = @Fax, " +
                                         "Website = @Website, " +
                                         "TaxOffice = @TaxOffice, " +
                                         "TaxNumber = @TaxNumber, " +
                                         "Address = @Address, " +
                                         "Notes = @Notes, " +
                                         "Debt = @Debt " +
                                         "WHERE SupplierID = @SupplierID";

                    SqlCommand command = new SqlCommand(updateQuery, connection);

                    // Parametreler ekleniyor
                    command.Parameters.AddWithValue("@SupplierName", txtSupplierName.Text);
                    command.Parameters.AddWithValue("@ContactPerson", txtContactPerson.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    command.Parameters.AddWithValue("@Gsm", txtGsm.Text);
                    command.Parameters.AddWithValue("@Fax", txtFax.Text);
                    command.Parameters.AddWithValue("@Website", txtWebsite.Text);
                    command.Parameters.AddWithValue("@TaxOffice", txtTaxOffice.Text);
                    command.Parameters.AddWithValue("@TaxNumber", txtTaxNumber.Text);
                    command.Parameters.AddWithValue("@Address", txtAddress.Text);
                    command.Parameters.AddWithValue("@Notes", txtNotes.Text);
                    command.Parameters.AddWithValue("@Debt", Convert.ToDecimal(txtDebt.Text));  // Buradaki Debt değerinin uygun formatta olduğundan emin olun
                    command.Parameters.AddWithValue("@SupplierID", supplierID); // Bu, formda verilen tedarikçi ID'sidir.

                    // Sorguyu çalıştır
                    command.ExecuteNonQuery();
                    MessageBox.Show("Toptancı bilgileri başarıyla güncellendi.");
                    this.Close(); // Formu kapat
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Formu kapatır.
        }

    }

}
