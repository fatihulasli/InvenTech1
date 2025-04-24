namespace InvenTech
{
    partial class SupplierAccountDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            groupBox1 = new GroupBox();
            btnWholesalerPayment = new Button();
            button2 = new Button();
            groupBoxDept = new GroupBox();
            label2 = new Label();
            txtDebtBalance = new TextBox();
            label1 = new Label();
            txtSupplierName = new TextBox();
            dgvDebtDetails = new DataGridView();
            groupBoxPurchase = new GroupBox();
            txtTotalProduct = new TextBox();
            txtInvoiceSearch = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dgvPurchaseDetails = new DataGridView();
            groupBox1.SuspendLayout();
            groupBoxDept.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDebtDetails).BeginInit();
            groupBoxPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseDetails).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(15, 62);
            dateTimePicker1.Margin = new Padding(8, 7, 8, 7);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(329, 55);
            dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(430, 62);
            dateTimePicker2.Margin = new Padding(8, 7, 8, 7);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(329, 55);
            dateTimePicker2.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Location = new Point(30, 29);
            groupBox1.Margin = new Padding(8, 7, 8, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(8, 7, 8, 7);
            groupBox1.Size = new Size(780, 168);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tarih Aralığı Seçin";
            // 
            // btnWholesalerPayment
            // 
            btnWholesalerPayment.Location = new Point(1325, 43);
            btnWholesalerPayment.Margin = new Padding(8, 7, 8, 7);
            btnWholesalerPayment.Name = "btnWholesalerPayment";
            btnWholesalerPayment.Size = new Size(342, 154);
            btnWholesalerPayment.TabIndex = 2;
            btnWholesalerPayment.Text = "Toptancıya Ödeme Yap";
            btnWholesalerPayment.UseVisualStyleBackColor = true;
            btnWholesalerPayment.Click += btnWholesalerPayment_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1792, 43);
            button2.Margin = new Padding(8, 7, 8, 7);
            button2.Name = "button2";
            button2.Size = new Size(342, 154);
            button2.TabIndex = 3;
            button2.Text = "Toptancı Borcuna Ekleme Yap";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBoxDept
            // 
            groupBoxDept.Controls.Add(label2);
            groupBoxDept.Controls.Add(txtDebtBalance);
            groupBoxDept.Controls.Add(label1);
            groupBoxDept.Controls.Add(txtSupplierName);
            groupBoxDept.Controls.Add(dgvDebtDetails);
            groupBoxDept.ForeColor = Color.Blue;
            groupBoxDept.Location = new Point(30, 235);
            groupBoxDept.Margin = new Padding(8, 7, 8, 7);
            groupBoxDept.Name = "groupBoxDept";
            groupBoxDept.Padding = new Padding(8, 7, 8, 7);
            groupBoxDept.Size = new Size(3020, 929);
            groupBoxDept.TabIndex = 4;
            groupBoxDept.TabStop = false;
            groupBoxDept.Text = "Borç Detayı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1505, 67);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(327, 48);
            label2.TabIndex = 5;
            label2.Text = "Kalan Borç Miktarı :";
            // 
            // txtDebtBalance
            // 
            txtDebtBalance.BackColor = Color.Red;
            txtDebtBalance.Location = new Point(1862, 62);
            txtDebtBalance.Margin = new Padding(8, 7, 8, 7);
            txtDebtBalance.Name = "txtDebtBalance";
            txtDebtBalance.ReadOnly = true;
            txtDebtBalance.Size = new Size(682, 55);
            txtDebtBalance.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 70);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(283, 48);
            label1.TabIndex = 2;
            label1.Text = "Toptancının Adı :";
            // 
            // txtSupplierName
            // 
            txtSupplierName.BackColor = Color.FromArgb(255, 224, 192);
            txtSupplierName.Location = new Point(680, 60);
            txtSupplierName.Margin = new Padding(8, 7, 8, 7);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.ReadOnly = true;
            txtSupplierName.Size = new Size(649, 55);
            txtSupplierName.TabIndex = 1;
            // 
            // dgvDebtDetails
            // 
            dgvDebtDetails.BackgroundColor = Color.FromArgb(255, 128, 0);
            dgvDebtDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDebtDetails.Location = new Point(50, 149);
            dgvDebtDetails.Margin = new Padding(8, 7, 8, 7);
            dgvDebtDetails.Name = "dgvDebtDetails";
            dgvDebtDetails.RowHeadersWidth = 51;
            dgvDebtDetails.Size = new Size(2930, 766);
            dgvDebtDetails.TabIndex = 0;
            dgvDebtDetails.CellContentClick += dgvDebtDetails_CellContentClick;
            // 
            // groupBoxPurchase
            // 
            groupBoxPurchase.Controls.Add(txtTotalProduct);
            groupBoxPurchase.Controls.Add(txtInvoiceSearch);
            groupBoxPurchase.Controls.Add(label4);
            groupBoxPurchase.Controls.Add(label3);
            groupBoxPurchase.Controls.Add(dgvPurchaseDetails);
            groupBoxPurchase.ForeColor = Color.Blue;
            groupBoxPurchase.Location = new Point(30, 1212);
            groupBoxPurchase.Margin = new Padding(8, 7, 8, 7);
            groupBoxPurchase.Name = "groupBoxPurchase";
            groupBoxPurchase.Padding = new Padding(8, 7, 8, 7);
            groupBoxPurchase.Size = new Size(3020, 854);
            groupBoxPurchase.TabIndex = 5;
            groupBoxPurchase.TabStop = false;
            groupBoxPurchase.Text = "Alış Detayı";
            // 
            // txtTotalProduct
            // 
            txtTotalProduct.BackColor = Color.Red;
            txtTotalProduct.Location = new Point(1862, 55);
            txtTotalProduct.Margin = new Padding(8, 7, 8, 7);
            txtTotalProduct.Name = "txtTotalProduct";
            txtTotalProduct.Size = new Size(682, 55);
            txtTotalProduct.TabIndex = 4;
            // 
            // txtInvoiceSearch
            // 
            txtInvoiceSearch.BackColor = Color.FromArgb(255, 224, 192);
            txtInvoiceSearch.Location = new Point(680, 55);
            txtInvoiceSearch.Margin = new Padding(8, 7, 8, 7);
            txtInvoiceSearch.Name = "txtInvoiceSearch";
            txtInvoiceSearch.Size = new Size(649, 55);
            txtInvoiceSearch.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1585, 62);
            label4.Margin = new Padding(8, 0, 8, 0);
            label4.Name = "label4";
            label4.Size = new Size(250, 48);
            label4.TabIndex = 2;
            label4.Text = "Ürün Toplamı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 62);
            label3.Margin = new Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(536, 48);
            label3.TabIndex = 1;
            label3.Text = "Fatura Numarasına Göre Arama :";
            // 
            // dgvPurchaseDetails
            // 
            dgvPurchaseDetails.BackgroundColor = Color.FromArgb(255, 128, 0);
            dgvPurchaseDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPurchaseDetails.Location = new Point(50, 149);
            dgvPurchaseDetails.Margin = new Padding(8, 7, 8, 7);
            dgvPurchaseDetails.Name = "dgvPurchaseDetails";
            dgvPurchaseDetails.RowHeadersWidth = 51;
            dgvPurchaseDetails.Size = new Size(2930, 691);
            dgvPurchaseDetails.TabIndex = 0;
            dgvPurchaseDetails.CellContentClick += dgvPurchaseDetails_CellContentClick;
            // 
            // SupplierAccountDetailsForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(3080, 2095);
            Controls.Add(groupBoxPurchase);
            Controls.Add(groupBoxDept);
            Controls.Add(button2);
            Controls.Add(btnWholesalerPayment);
            Controls.Add(groupBox1);
            Margin = new Padding(8, 7, 8, 7);
            Name = "SupplierAccountDetailsForm";
            Text = "SupplierAccountDetailsForm";
            groupBox1.ResumeLayout(false);
            groupBoxDept.ResumeLayout(false);
            groupBoxDept.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDebtDetails).EndInit();
            groupBoxPurchase.ResumeLayout(false);
            groupBoxPurchase.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseDetails).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker startDatePicker;
        private DateTimePicker endDatePicker;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private GroupBox groupBox1;
        private Button btnWholesalerPayment;
        private Button button2;
        private GroupBox groupBoxDept;
        private DataGridView dgvDebtDetails;
        private GroupBox groupBoxPurchase;
        private DataGridView dgvPurchaseDetails;
        private Label label2;
        private TextBox txtDebtBalance;
        private Label label1;
        private TextBox txtSupplierName;
        private Label label3;
        private TextBox txtTotalProduct;
        private TextBox txtInvoiceSearch;
        private Label label4;
    }
}