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
    public partial class NewSupplierForm : Form
    {
        public NewSupplierForm()
        {
            InitializeComponent();
        }

        // Cancel butonuna tıklanıldığında formu kapatır
        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Save butonuna tıklanıldığında bilgileri doğrular ve veritabanına kaydeder
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Zorunlu alanların boş olup olmadığını kontrol et
            if (string.IsNullOrEmpty(txtSupplierName.Text))
            {
                MessageBox.Show("Supplier name cannot be empty.");
                return;
            }

            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Phone number cannot be empty.");
                return;
            }

            // Bağlantı dizesini App.config'den al
            string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Veritabanına ekleme sorgusu
                    string query = @"
                        INSERT INTO Suppliers (SupplierName, ContactPerson, Email, Phone, Gsm, Fax, Website, 
                                              TaxOffice, TaxNumber, Address, Debt, Notes, CreatedDate)
                        VALUES (@SupplierName, @ContactPerson, @Email, @Phone, @Gsm, @Fax, @Website, 
                                @TaxOffice, @TaxNumber, @Address, @Debt, @Notes, GETDATE())";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parametreleri ekle
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
                        command.Parameters.AddWithValue("@Debt", string.IsNullOrEmpty(txtDebt.Text) ? 0 : Convert.ToDecimal(txtDebt.Text));
                        command.Parameters.AddWithValue("@Notes", txtNotes.Text);

                        // Sorguyu çalıştır
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Supplier information saved successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
