using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace InvenTech
{
    public static class DatabaseHelper
    {
        // Bağlantı dizesi: App.config dosyasından alınacak
        private static string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

        // Veri sorgulama (SELECT)
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                if (parameters != null)
                    adapter.SelectCommand.Parameters.AddRange(parameters);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        // Veri ekleme, güncelleme, silme (INSERT, UPDATE, DELETE)
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                connection.Open();
                return command.ExecuteNonQuery();
            }
        }

        // Tek bir değer döndürme (örneğin COUNT, MAX)
        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                connection.Open();
                return command.ExecuteScalar();
            }
        }
    }
}
