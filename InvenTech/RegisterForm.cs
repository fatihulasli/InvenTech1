using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.VisualBasic.ApplicationServices;



namespace InvenTech
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            string username = Username.Text;  //username TextBoxundan kullanıcı adını aldık 
            string password = Password.Text;  //password TextBoxundan şifreyi de aldım 
            string passwordConfirm = PasswordConfirm.Text;  //passwordconfirm TextBoxundan parolayı onayladık
            string role = cmbRole.SelectedItem?.ToString(); // Kullanıcının seçtiği rolü alıyoruz.

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(passwordConfirm))
            {
                MessageBox.Show("Username and password cannot be empty!");
                return;
            }

            if (password != passwordConfirm)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            if (string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Kullanıcı adının mevcut olup olmadığını kontrol ediyoruz
                    string checkUsernameQuery = "SELECT COUNT(1) FROM Users WHERE Username = @username";
                    SqlCommand checkUsernameCommand = new SqlCommand(checkUsernameQuery, connection);
                    checkUsernameCommand.Parameters.AddWithValue("@username", username);

                    int userExists = (int)checkUsernameCommand.ExecuteScalar();
                    if (userExists > 0)
                    {
                        MessageBox.Show("Username is already taken. Please choose another username.");
                        return;
                    }


                    // Kullanıcı adı mevcut değilse kaydı yapıyoruz
                    string query = "INSERT INTO Users (Username, Password, Role) VALUES (@username, @password,@role)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@role", role);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Registration successful!");
                    this.Close(); // Register formunu kapatıyoruz
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("SQL Error: " + sqlEx.Message);
                }
            }





            //Kullanıcıyı kaydetme işlemi  (ileri adımlarda veritabanına ekleme yapılabilir )    
            MessageBox.Show("Registration successfull! Please wait for admin approval. ");
            this.Close();  //register formunu kapatıp login formuna geri dön


        }

        private void back_Click(object sender, EventArgs e)
        {
            Program.GoBack();
        }
    }
}
