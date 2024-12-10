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
    public partial class ChangePasswordForm : Form
    {
        public string Username { get; set; }

        public ChangePasswordForm(string username)
        {
            InitializeComponent();
            Username = username; // Giriş yapan kullanıcının kullanıcı adı
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            string currentPassword = OldPassword.Text.Trim(); // Mevcut şifre
            string newPassword = NewPassword.Text.Trim(); // Yeni şifre
            string confirmPassword = ConfirmNewPassword.Text.Trim(); // Yeni şifre tekrarı

            // Boş alan kontrolü
            if (string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            // Yeni şifrelerin uyuşup uyuşmadığını kontrol et
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New passwords do not match.");
                return;
            }

            // Bağlantı dizesini App.config'den okuma
            string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Mevcut şifrenin doğruluğunu kontrol etme
                    string query = "SELECT COUNT(1) FROM Users WHERE Username=@username AND Password=@currentPassword";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@username", SqlDbType.NVarChar).Value = Username;
                    command.Parameters.Add("@currentPassword", SqlDbType.NVarChar).Value = currentPassword;

                    int userCount = Convert.ToInt32(command.ExecuteScalar());

                    if (userCount != 1)
                    {
                        MessageBox.Show("Current password is incorrect.");
                        return;
                    }

                    // Yeni şifreyi güncelleme
                    string updateQuery = "UPDATE Users SET Password=@newPassword WHERE Username=@username";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                    updateCommand.Parameters.Add("@username", SqlDbType.NVarChar).Value = Username;
                    updateCommand.Parameters.Add("@newPassword", SqlDbType.NVarChar).Value = newPassword;

                    int rowsAffected = updateCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password changed successfully.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password change failed.");
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("SQL Error: " + sqlEx.Message);
                }
            }
        }
    }
}
