using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvenTech
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void changeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {

                // Yeni bir LoginForm oluştur ve göster
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();


            }
        }



        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void receivingARefundFromTheCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ProductEntry_Click(object sender, EventArgs e)
        {
            ProductEnterForm productEnterForm = new ProductEnterForm();
            productEnterForm.ShowDialog();
        }

        private void Users_Click(object sender, EventArgs e)
        {

        }

        private void Sales_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm();
            salesForm.Show(); // SalesForm'u açar
        }

        private void SeePrice_Click(object sender, EventArgs e)
        {
            // ProductSearchForm formunu oluşturuyoruz
            ProductSearchForm productSearchForm = new ProductSearchForm();

            // Formu modaldan açıyoruz (yeni form, kullanıcı bu formu kapatmadan MainForm'a geri dönemeyecek)
            productSearchForm.ShowDialog();
        }


        private void Customers_Click(object sender, EventArgs e)
        {
            // CustomerForm formunu aç
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show(); // Yeni formu göster   
        }

        private void ReturnProcess_Click(object sender, EventArgs e)
        {

        }

        private void Stock_Click(object sender, EventArgs e)
        {

        }

        private void Reports_Click(object sender, EventArgs e)
        {

        }

        private void CashRegister_Click(object sender, EventArgs e)
        {

        }

        private void Wholesalers_Click(object sender, EventArgs e)
        {
            WholesalersForm wholesalersForm = new WholesalersForm();
            wholesalersForm.ShowDialog(); // Yeni formu modal olarak aç
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void caseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exchangeRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void passwordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void processingAProductReturnToTheWholesalerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showTheİnventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ınventoryCountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productsBelowCriticalStockLevelsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void receiveReturnFromCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wholesalerListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addWholesalerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editWholesalerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteWholesalerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void returnToWholesalerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contactİnformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void File_Click(object sender, EventArgs e)
        {

        }

        private void Agenda_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kullanıcı adını oturum bilgisinden alıyoruz.
            string currentUsername = UserSession.Username;

            if (string.IsNullOrEmpty(currentUsername))
            {
                MessageBox.Show("You must be logged in to change your password.");
                return;
            }

            ChangePasswordForm changePasswordForm = new ChangePasswordForm(currentUsername);
            changePasswordForm.ShowDialog();
        }

    }
}
