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
    public partial class MusteriBorcuForm : Form
    {
        public string MusteriAdi { get; set; }
        public decimal VeresiyeBorcu { get; set; }
        public decimal KalanTaksit { get; set; }
        public decimal OdemesiGerekenTaksit { get; set; }

        // Constructor ile bilgileri alıyoruz
        public MusteriBorcuForm(string musteriAdi, decimal veresiyeBorcu, decimal kalanTaksit, decimal odemesiGerekenTaksit)
        {
            InitializeComponent();

            // Gelen bilgileri formdaki alanlara atıyoruz
            MusteriAdi = musteriAdi;
            VeresiyeBorcu = veresiyeBorcu;
            KalanTaksit = kalanTaksit;
            OdemesiGerekenTaksit = odemesiGerekenTaksit;
        }

        private void MusteriBorcuForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde, gelen verileri ilgili alanlara yazıyoruz
            txtCustomerName.Text = MusteriAdi;
            txtVeresiyeBorcu.Text = VeresiyeBorcu.ToString("C");  // Para formatında gösterim
            txtKalanTaksitTutari.Text = KalanTaksit.ToString("C");
            txtOdemesiGerekenTaksit.Text = OdemesiGerekenTaksit.ToString("C");
        }
    }


}
