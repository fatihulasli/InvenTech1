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
    public partial class SupplierAccountDetailsForm : Form
    {
        private int supplierID;

        // Parametreli constructor
        public SupplierAccountDetailsForm(int supplierID)
        {
            InitializeComponent();
            this.supplierID = supplierID;

            // Bu supplierID ile veritabanından bilgileri çekip formu doldurabilirsiniz.
            LoadSupplierDetails(supplierID);
        }

        private void LoadSupplierDetails(int supplierID)
        {
            // Veritabanından supplierID'ye ait bilgileri çekin ve formu doldurun.
        }

        public SupplierAccountDetailsForm()
        {
            InitializeComponent();
        }

        private void dgvPurchaseDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDebtDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnWholesalerPayment_Click(object sender, EventArgs e)
        {
            // Seçilen tedarikçiyi al
            int supplierID = GetSupplierIdFromSelectedRow();

            // Eğer geçerli bir SupplierID alınmışsa, WholesalerPaymentForm'u aç
            if (supplierID != -1)
            {
                // Burada gerekli bilgileri alarak formu oluşturuyoruz
                WholesalerPaymentForm paymentForm = new WholesalerPaymentForm(supplierID);
                paymentForm.ShowDialog(); // Modal form olarak aç
            }
        }

        // Seçilen tedarikçiyi alacak metod
        private int GetSupplierIdFromSelectedRow()
        {
            // Eğer borç detayları DataGridView'ini kullanıyorsanız
            if (dgvDebtDetails.SelectedRows.Count > 0)
            {
                // Seçilen satırdaki SupplierID'yi al
                return Convert.ToInt32(dgvDebtDetails.SelectedRows[0].Cells["Sıra No"].Value);
            }
            else
            {
                // Eğer hiçbir satır seçilmemişse hata mesajı verebilirsiniz
                MessageBox.Show("Lütfen bir tedarikçi seçin.");
                return -1; // Geçersiz ID
            }
        }





    }
}
