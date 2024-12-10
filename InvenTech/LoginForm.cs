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
using System.Configuration; // App.config'den bağlantı dizesini almak için gerekli


namespace InvenTech 
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {

            string username = Username.Text; //username Textbox'ından kullanıcı adı alınır
            string password = Password.Text; //password Textbox'ından şifre alınır  


            // Kullanıcı adı ve şifre kontrolü
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password cannot be empty!");
                return;
            }
            // Bağlantı dizesini App.config'den okuma
            string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Role FROM Users WHERE Username=@username AND Password=@password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string role = reader["Role"].ToString();

                        MessageBox.Show("Login successful!");
                        // Kullanıcı adı oturum bilgisinde saklanıyor
                        UserSession.Username = username;
                        this.Hide();
                        MainForm mainForm = new MainForm();
                        Program.NavigateTo(mainForm); 

                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!");
                    }

                    reader.Close();

                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("SQL Error: " + sqlEx.Message);
                }
            }

        }

        private void Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            Program.NavigateTo(registerForm); // Register formuna geç


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
