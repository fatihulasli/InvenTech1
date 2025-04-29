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
    public partial class ProductSearchForm : Form
    {
        public string SelectedBarcode { get; private set; }

        public ProductSearchForm()
        {
            InitializeComponent();
        }

        private void txtSearchProductName_TextChanged(object sender, EventArgs e)
        {
            (dgvProducts.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("[Ürünün Adı] LIKE '%{0}%' OR [Bar. No] LIKE '%{0}%'", txtSearchProductName.Text.Trim().Replace("'", "''"));
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedBarcode = dgvProducts.Rows[e.RowIndex].Cells["Bar. No"].Value.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void ProductSearchForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["UserDBConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT Barcode AS [Bar. No], 
                                    ProductName AS [Ürünün Adı], 
                                    ProductGroup AS [Ürün Grubu], 
                                    StockAmount AS [Mevcut Stok], 
                                    Unit AS [Ölçü Birimi], 
                                    PurchasePriceIncludingVAT AS [Alış Fiyatı], 
                                    SalesPrice AS [Satış Fiyatı]
                             FROM Products_Backup";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvProducts.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ürünler yüklenemedi: " + ex.Message);
                }
            }
        }


    }
}
