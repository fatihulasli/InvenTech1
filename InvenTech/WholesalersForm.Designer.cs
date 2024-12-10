namespace InvenTech
{
    partial class WholesalersForm
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
            txtSupplierName = new TextBox();
            txtContactPerson = new TextBox();
            txtWebsite = new TextBox();
            txtEmail = new TextBox();
            txtTaxOffice = new TextBox();
            txtTaxNumber = new TextBox();
            txtAddress = new RichTextBox();
            txtPhone = new TextBox();
            label1 = new Label();
            txtGsm = new TextBox();
            txtFax = new TextBox();
            txtNotes = new RichTextBox();
            btnAccountDetails = new Button();
            txtTotalDebt = new TextBox();
            btnMakePayment = new Button();
            btnAddDebt = new Button();
            panel1 = new Panel();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label13 = new Label();
            txtSearchSupplier = new TextBox();
            btnAddSupplier = new Button();
            btnEditSupplier = new Button();
            btnDeleteSupplier = new Button();
            btnReturnProduct = new Button();
            btnSupplierDebtList = new Button();
            label14 = new Label();
            txtTotalSuppliersDebt = new TextBox();
            dgvSuppliers = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(114, 18);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.ReadOnly = true;
            txtSupplierName.Size = new Size(278, 27);
            txtSupplierName.TabIndex = 1;
            // 
            // txtContactPerson
            // 
            txtContactPerson.Location = new Point(114, 63);
            txtContactPerson.Name = "txtContactPerson";
            txtContactPerson.ReadOnly = true;
            txtContactPerson.Size = new Size(278, 27);
            txtContactPerson.TabIndex = 2;
            // 
            // txtWebsite
            // 
            txtWebsite.Location = new Point(114, 153);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.ReadOnly = true;
            txtWebsite.Size = new Size(278, 27);
            txtWebsite.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(114, 108);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(278, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtTaxOffice
            // 
            txtTaxOffice.Location = new Point(114, 198);
            txtTaxOffice.Name = "txtTaxOffice";
            txtTaxOffice.ReadOnly = true;
            txtTaxOffice.Size = new Size(113, 27);
            txtTaxOffice.TabIndex = 5;
            // 
            // txtTaxNumber
            // 
            txtTaxNumber.Location = new Point(277, 198);
            txtTaxNumber.Name = "txtTaxNumber";
            txtTaxNumber.ReadOnly = true;
            txtTaxNumber.Size = new Size(115, 27);
            txtTaxNumber.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(114, 243);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(278, 120);
            txtAddress.TabIndex = 7;
            txtAddress.Text = "";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(514, 18);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(115, 27);
            txtPhone.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(422, 20);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 9;
            label1.Text = "İş Telefonu :";
            // 
            // txtGsm
            // 
            txtGsm.Location = new Point(514, 63);
            txtGsm.Name = "txtGsm";
            txtGsm.ReadOnly = true;
            txtGsm.Size = new Size(115, 27);
            txtGsm.TabIndex = 10;
            // 
            // txtFax
            // 
            txtFax.Location = new Point(514, 108);
            txtFax.Name = "txtFax";
            txtFax.ReadOnly = true;
            txtFax.Size = new Size(115, 27);
            txtFax.TabIndex = 11;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(514, 153);
            txtNotes.Name = "txtNotes";
            txtNotes.ReadOnly = true;
            txtNotes.Size = new Size(247, 72);
            txtNotes.TabIndex = 12;
            txtNotes.Text = "";
            // 
            // btnAccountDetails
            // 
            btnAccountDetails.Location = new Point(414, 290);
            btnAccountDetails.Name = "btnAccountDetails";
            btnAccountDetails.Size = new Size(117, 68);
            btnAccountDetails.TabIndex = 13;
            btnAccountDetails.Text = "Toptancı Hesap Detayı";
            btnAccountDetails.UseVisualStyleBackColor = true;
            // 
            // txtTotalDebt
            // 
            txtTotalDebt.BackColor = Color.IndianRed;
            txtTotalDebt.Location = new Point(514, 243);
            txtTotalDebt.Name = "txtTotalDebt";
            txtTotalDebt.ReadOnly = true;
            txtTotalDebt.Size = new Size(115, 27);
            txtTotalDebt.TabIndex = 14;
            // 
            // btnMakePayment
            // 
            btnMakePayment.Location = new Point(545, 290);
            btnMakePayment.Name = "btnMakePayment";
            btnMakePayment.Size = new Size(117, 68);
            btnMakePayment.TabIndex = 15;
            btnMakePayment.Text = "Toptancıya Ödeme Yap";
            btnMakePayment.UseVisualStyleBackColor = true;
            // 
            // btnAddDebt
            // 
            btnAddDebt.Location = new Point(676, 290);
            btnAddDebt.Name = "btnAddDebt";
            btnAddDebt.Size = new Size(117, 68);
            btnAddDebt.TabIndex = 16;
            btnAddDebt.Text = "Toptancı Borcuna Ekleme Yap";
            btnAddDebt.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnAddDebt);
            panel1.Controls.Add(btnAccountDetails);
            panel1.Controls.Add(btnMakePayment);
            panel1.Location = new Point(3, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 386);
            panel1.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(409, 245);
            label12.Name = "label12";
            label12.Size = new Size(100, 20);
            label12.TabIndex = 28;
            label12.Text = "Toplam Borç :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(417, 148);
            label11.Name = "label11";
            label11.Size = new Size(92, 20);
            label11.TabIndex = 27;
            label11.Text = "Özel Notlar :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(472, 110);
            label10.Name = "label10";
            label10.Size = new Size(37, 20);
            label10.TabIndex = 26;
            label10.Text = "Fax :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(399, 65);
            label9.Name = "label9";
            label9.Size = new Size(110, 20);
            label9.TabIndex = 25;
            label9.Text = "Gsm  Telefonu :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(61, 238);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 24;
            label8.Text = "Adres:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(230, 200);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 23;
            label7.Text = "V.N :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 200);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 22;
            label6.Text = "Vergi Dairesi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 155);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 21;
            label5.Text = "İnternet Adresi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 110);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 20;
            label4.Text = "E-Mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 65);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 19;
            label3.Text = "Şirket Yetkilisi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 20);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 18;
            label2.Text = "Toptancı Adı:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.ForeColor = SystemColors.Highlight;
            label13.Location = new Point(12, 412);
            label13.Name = "label13";
            label13.Size = new Size(100, 20);
            label13.TabIndex = 25;
            label13.Text = "Toptancı Ara :";
            // 
            // txtSearchSupplier
            // 
            txtSearchSupplier.Location = new Point(114, 409);
            txtSearchSupplier.Name = "txtSearchSupplier";
            txtSearchSupplier.Size = new Size(186, 27);
            txtSearchSupplier.TabIndex = 26;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.Location = new Point(548, 442);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(117, 82);
            btnAddSupplier.TabIndex = 27;
            btnAddSupplier.Text = "Toptancı Ekle";
            btnAddSupplier.UseVisualStyleBackColor = true;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // btnEditSupplier
            // 
            btnEditSupplier.Location = new Point(688, 442);
            btnEditSupplier.Name = "btnEditSupplier";
            btnEditSupplier.Size = new Size(117, 82);
            btnEditSupplier.TabIndex = 28;
            btnEditSupplier.Text = "Toptancı Bilgilerini Düzenle";
            btnEditSupplier.UseVisualStyleBackColor = true;
            btnEditSupplier.Click += btnEditSupplier_Click;
            // 
            // btnDeleteSupplier
            // 
            btnDeleteSupplier.Location = new Point(548, 571);
            btnDeleteSupplier.Name = "btnDeleteSupplier";
            btnDeleteSupplier.Size = new Size(117, 82);
            btnDeleteSupplier.TabIndex = 29;
            btnDeleteSupplier.Text = "Toptancı  Sil";
            btnDeleteSupplier.UseVisualStyleBackColor = true;
            btnDeleteSupplier.Click += btnDeleteSupplier_Click;
            // 
            // btnReturnProduct
            // 
            btnReturnProduct.Location = new Point(688, 571);
            btnReturnProduct.Name = "btnReturnProduct";
            btnReturnProduct.Size = new Size(117, 82);
            btnReturnProduct.TabIndex = 30;
            btnReturnProduct.Text = "Toptancıya Ürün İade Et";
            btnReturnProduct.UseVisualStyleBackColor = true;
            // 
            // btnSupplierDebtList
            // 
            btnSupplierDebtList.Location = new Point(548, 700);
            btnSupplierDebtList.Name = "btnSupplierDebtList";
            btnSupplierDebtList.Size = new Size(117, 82);
            btnSupplierDebtList.TabIndex = 31;
            btnSupplierDebtList.Text = "Toptancı Borç Listesi";
            btnSupplierDebtList.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.ForeColor = SystemColors.Highlight;
            label14.Location = new Point(17, 800);
            label14.Name = "label14";
            label14.Size = new Size(259, 20);
            label14.TabIndex = 32;
            label14.Text = "Bütün Toptancılara Toplam Borcunuz :";
            // 
            // txtTotalSuppliersDebt
            // 
            txtTotalSuppliersDebt.BackColor = Color.Red;
            txtTotalSuppliersDebt.Location = new Point(282, 797);
            txtTotalSuppliersDebt.Name = "txtTotalSuppliersDebt";
            txtTotalSuppliersDebt.ReadOnly = true;
            txtTotalSuppliersDebt.Size = new Size(230, 27);
            txtTotalSuppliersDebt.TabIndex = 33;
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuppliers.BackgroundColor = Color.FromArgb(255, 128, 0);
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Location = new Point(21, 442);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.RowHeadersWidth = 51;
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.Size = new Size(491, 340);
            dgvSuppliers.TabIndex = 34;
            dgvSuppliers.SelectionChanged += dgvSuppliers_SelectionChanged;
            // 
            // WholesalersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 853);
            Controls.Add(dgvSuppliers);
            Controls.Add(txtTotalSuppliersDebt);
            Controls.Add(label14);
            Controls.Add(btnSupplierDebtList);
            Controls.Add(btnReturnProduct);
            Controls.Add(btnDeleteSupplier);
            Controls.Add(btnEditSupplier);
            Controls.Add(btnAddSupplier);
            Controls.Add(txtSearchSupplier);
            Controls.Add(label13);
            Controls.Add(txtTotalDebt);
            Controls.Add(txtNotes);
            Controls.Add(txtFax);
            Controls.Add(txtGsm);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtTaxNumber);
            Controls.Add(txtTaxOffice);
            Controls.Add(txtWebsite);
            Controls.Add(txtEmail);
            Controls.Add(txtContactPerson);
            Controls.Add(txtSupplierName);
            Controls.Add(panel1);
            Name = "WholesalersForm";
            Text = "WholesalersForm";
            Load += WholesalersForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSupplierName;
        private TextBox txtContactPerson;
        private TextBox txtWebsite;
        private TextBox txtEmail;
        private TextBox txtTaxOffice;
        private TextBox txtTaxNumber;
        private RichTextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtGsm;
        private TextBox txtFax;
        private RichTextBox txtNotes;
        private Button btnAccountDetails;
        private TextBox txtTotalDebt;
        private Button btnMakePayment;
        private Button btnAddDebt;
        private Panel panel1;
        private Label label2;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dgvSuppliers;
        private Label label13;
        private TextBox txtSearchSupplier;
        private Button btnAddSupplier;
        private Button btnEditSupplier;
        private Button btnDeleteSupplier;
        private Button btnReturnProduct;
        private Button btnSupplierDebtList;
        private Label label14;
        private TextBox txtTotalSuppliersDebt;
    }
}