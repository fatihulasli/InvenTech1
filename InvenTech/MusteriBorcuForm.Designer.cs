namespace InvenTech
{
    partial class MusteriBorcuForm
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
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            grpDateRange = new GroupBox();
            btnInstallments = new Button();
            btnAddDebt = new Button();
            btnMakePayment = new Button();
            grpBorçDetayı = new GroupBox();
            lblCustomerName = new Label();
            txtCustomerName = new TextBox();
            lblVeresiyeBorcu = new Label();
            txtVeresiyeBorcu = new TextBox();
            txtKalanTaksitTutari = new TextBox();
            lblKalanTaksitTutari = new Label();
            lblOdemesiGerekenTaksit = new Label();
            txtOdemesiGerekenTaksit = new TextBox();
            borcDetayiDGV = new DataGridView();
            SıraNo = new DataGridViewTextBoxColumn();
            Tarih = new DataGridViewTextBoxColumn();
            IslemTuru = new DataGridViewTextBoxColumn();
            OncekiBakiye = new DataGridViewTextBoxColumn();
            IslemTutari = new DataGridViewTextBoxColumn();
            KalanBorc = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grpAlışverişDetayı = new GroupBox();
            alışverişDetayıDGV = new DataGridView();
            SıraNo2 = new DataGridViewTextBoxColumn();
            Tarih2 = new DataGridViewTextBoxColumn();
            UrunAdı2 = new DataGridViewTextBoxColumn();
            BirimFiyati = new DataGridViewTextBoxColumn();
            Miktar = new DataGridViewTextBoxColumn();
            ToplamTutar = new DataGridViewTextBoxColumn();
            OdemeSekli = new DataGridViewTextBoxColumn();
            lblUrunToplami = new Label();
            txtUrunToplami = new TextBox();
            grpDateRange.SuspendLayout();
            grpBorçDetayı.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)borcDetayiDGV).BeginInit();
            grpAlışverişDetayı.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)alışverişDetayıDGV).BeginInit();
            SuspendLayout();
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(6, 37);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(150, 31);
            dtpStartDate.TabIndex = 0;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(162, 37);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(150, 31);
            dtpEndDate.TabIndex = 1;
            // 
            // grpDateRange
            // 
            grpDateRange.BackColor = Color.Transparent;
            grpDateRange.Controls.Add(dtpStartDate);
            grpDateRange.Controls.Add(dtpEndDate);
            grpDateRange.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpDateRange.Location = new Point(12, 12);
            grpDateRange.Name = "grpDateRange";
            grpDateRange.Size = new Size(331, 85);
            grpDateRange.TabIndex = 3;
            grpDateRange.TabStop = false;
            grpDateRange.Text = "Tarih Aralığı Seçin:";
            // 
            // btnInstallments
            // 
            btnInstallments.BackColor = Color.FromArgb(76, 175, 80);
            btnInstallments.ForeColor = Color.White;
            btnInstallments.Location = new Point(402, 24);
            btnInstallments.Name = "btnInstallments";
            btnInstallments.Size = new Size(132, 73);
            btnInstallments.TabIndex = 4;
            btnInstallments.Text = "Taksitler";
            btnInstallments.UseVisualStyleBackColor = false;
            // 
            // btnAddDebt
            // 
            btnAddDebt.BackColor = Color.FromArgb(33, 150, 243);
            btnAddDebt.ForeColor = Color.White;
            btnAddDebt.Location = new Point(585, 24);
            btnAddDebt.Name = "btnAddDebt";
            btnAddDebt.Size = new Size(132, 73);
            btnAddDebt.TabIndex = 5;
            btnAddDebt.Text = "Hesaba Borç Ekle";
            btnAddDebt.UseVisualStyleBackColor = false;
            // 
            // btnMakePayment
            // 
            btnMakePayment.BackColor = Color.FromArgb(255, 87, 34);
            btnMakePayment.ForeColor = Color.White;
            btnMakePayment.Location = new Point(768, 24);
            btnMakePayment.Name = "btnMakePayment";
            btnMakePayment.Size = new Size(132, 73);
            btnMakePayment.TabIndex = 6;
            btnMakePayment.Text = "Tahsilat Yap";
            btnMakePayment.UseVisualStyleBackColor = false;
            // 
            // grpBorçDetayı
            // 
            grpBorçDetayı.BackColor = Color.Transparent;
            grpBorçDetayı.Controls.Add(borcDetayiDGV);
            grpBorçDetayı.Controls.Add(txtOdemesiGerekenTaksit);
            grpBorçDetayı.Controls.Add(lblOdemesiGerekenTaksit);
            grpBorçDetayı.Controls.Add(lblKalanTaksitTutari);
            grpBorçDetayı.Controls.Add(txtKalanTaksitTutari);
            grpBorçDetayı.Controls.Add(txtVeresiyeBorcu);
            grpBorçDetayı.Controls.Add(lblVeresiyeBorcu);
            grpBorçDetayı.Controls.Add(txtCustomerName);
            grpBorçDetayı.Controls.Add(lblCustomerName);
            grpBorçDetayı.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpBorçDetayı.Location = new Point(12, 115);
            grpBorçDetayı.Name = "grpBorçDetayı";
            grpBorçDetayı.Size = new Size(898, 387);
            grpBorçDetayı.TabIndex = 7;
            grpBorçDetayı.TabStop = false;
            grpBorçDetayı.Text = "Borç Detayı";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblCustomerName.Location = new Point(58, 26);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(156, 23);
            lblCustomerName.TabIndex = 0;
            lblCustomerName.Text = "Müşteri Adı Soyadı:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.BackColor = Color.FromArgb(255, 192, 128);
            txtCustomerName.Location = new Point(220, 23);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(200, 30);
            txtCustomerName.TabIndex = 1;
            // 
            // lblVeresiyeBorcu
            // 
            lblVeresiyeBorcu.AutoSize = true;
            lblVeresiyeBorcu.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblVeresiyeBorcu.Location = new Point(504, 26);
            lblVeresiyeBorcu.Name = "lblVeresiyeBorcu";
            lblVeresiyeBorcu.Size = new Size(172, 23);
            lblVeresiyeBorcu.TabIndex = 2;
            lblVeresiyeBorcu.Text = "Veresiye Borç Miktarı:";
            // 
            // txtVeresiyeBorcu
            // 
            txtVeresiyeBorcu.BackColor = Color.Red;
            txtVeresiyeBorcu.Location = new Point(682, 26);
            txtVeresiyeBorcu.Name = "txtVeresiyeBorcu";
            txtVeresiyeBorcu.ReadOnly = true;
            txtVeresiyeBorcu.Size = new Size(200, 30);
            txtVeresiyeBorcu.TabIndex = 3;
            // 
            // txtKalanTaksitTutari
            // 
            txtKalanTaksitTutari.BackColor = Color.FromArgb(255, 192, 128);
            txtKalanTaksitTutari.Location = new Point(220, 63);
            txtKalanTaksitTutari.Name = "txtKalanTaksitTutari";
            txtKalanTaksitTutari.ReadOnly = true;
            txtKalanTaksitTutari.Size = new Size(200, 30);
            txtKalanTaksitTutari.TabIndex = 4;
            // 
            // lblKalanTaksitTutari
            // 
            lblKalanTaksitTutari.AutoSize = true;
            lblKalanTaksitTutari.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblKalanTaksitTutari.Location = new Point(3, 70);
            lblKalanTaksitTutari.Name = "lblKalanTaksitTutari";
            lblKalanTaksitTutari.Size = new Size(211, 23);
            lblKalanTaksitTutari.TabIndex = 5;
            lblKalanTaksitTutari.Text = "Kalan Taksit Tutar Toplamı:";
            // 
            // lblOdemesiGerekenTaksit
            // 
            lblOdemesiGerekenTaksit.AutoSize = true;
            lblOdemesiGerekenTaksit.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblOdemesiGerekenTaksit.Location = new Point(435, 66);
            lblOdemesiGerekenTaksit.Name = "lblOdemesiGerekenTaksit";
            lblOdemesiGerekenTaksit.Size = new Size(244, 23);
            lblOdemesiGerekenTaksit.TabIndex = 6;
            lblOdemesiGerekenTaksit.Text = "Ödemesi Gereken Taksit Tutarı:";
            // 
            // txtOdemesiGerekenTaksit
            // 
            txtOdemesiGerekenTaksit.BackColor = Color.FromArgb(255, 192, 128);
            txtOdemesiGerekenTaksit.Location = new Point(682, 63);
            txtOdemesiGerekenTaksit.Name = "txtOdemesiGerekenTaksit";
            txtOdemesiGerekenTaksit.ReadOnly = true;
            txtOdemesiGerekenTaksit.Size = new Size(200, 30);
            txtOdemesiGerekenTaksit.TabIndex = 7;
            // 
            // borcDetayiDGV
            // 
            borcDetayiDGV.BackgroundColor = Color.FromArgb(255, 128, 0);
            borcDetayiDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            borcDetayiDGV.Columns.AddRange(new DataGridViewColumn[] { SıraNo, Tarih, IslemTuru, OncekiBakiye, IslemTutari, KalanBorc });
            borcDetayiDGV.Location = new Point(6, 99);
            borcDetayiDGV.Name = "borcDetayiDGV";
            borcDetayiDGV.RowHeadersWidth = 51;
            borcDetayiDGV.Size = new Size(886, 275);
            borcDetayiDGV.TabIndex = 8;
            // 
            // SıraNo
            // 
            SıraNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SıraNo.HeaderText = "Sıra No";
            SıraNo.MinimumWidth = 6;
            SıraNo.Name = "SıraNo";
            SıraNo.Resizable = DataGridViewTriState.False;
            // 
            // Tarih
            // 
            Tarih.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tarih.HeaderText = "Tarih";
            Tarih.MinimumWidth = 6;
            Tarih.Name = "Tarih";
            Tarih.Resizable = DataGridViewTriState.False;
            // 
            // IslemTuru
            // 
            IslemTuru.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IslemTuru.HeaderText = "İşlem Türü";
            IslemTuru.MinimumWidth = 6;
            IslemTuru.Name = "IslemTuru";
            IslemTuru.Resizable = DataGridViewTriState.False;
            // 
            // OncekiBakiye
            // 
            OncekiBakiye.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OncekiBakiye.HeaderText = "Önceki Bakiye";
            OncekiBakiye.MinimumWidth = 6;
            OncekiBakiye.Name = "OncekiBakiye";
            OncekiBakiye.Resizable = DataGridViewTriState.False;
            // 
            // IslemTutari
            // 
            IslemTutari.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IslemTutari.HeaderText = "İşlem Tutarı";
            IslemTutari.MinimumWidth = 6;
            IslemTutari.Name = "IslemTutari";
            IslemTutari.Resizable = DataGridViewTriState.False;
            // 
            // KalanBorc
            // 
            KalanBorc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            KalanBorc.HeaderText = "Kalan Borç";
            KalanBorc.MinimumWidth = 6;
            KalanBorc.Name = "KalanBorc";
            KalanBorc.Resizable = DataGridViewTriState.False;
            // 
            // grpAlışverişDetayı
            // 
            grpAlışverişDetayı.BackColor = Color.Transparent;
            grpAlışverişDetayı.Controls.Add(txtUrunToplami);
            grpAlışverişDetayı.Controls.Add(lblUrunToplami);
            grpAlışverişDetayı.Controls.Add(alışverişDetayıDGV);
            grpAlışverişDetayı.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grpAlışverişDetayı.Location = new Point(12, 518);
            grpAlışverişDetayı.Name = "grpAlışverişDetayı";
            grpAlışverişDetayı.Size = new Size(898, 383);
            grpAlışverişDetayı.TabIndex = 8;
            grpAlışverişDetayı.TabStop = false;
            grpAlışverişDetayı.Text = "Alışveriş Detayı";
            // 
            // alışverişDetayıDGV
            // 
            alışverişDetayıDGV.BackgroundColor = Color.FromArgb(255, 128, 0);
            alışverişDetayıDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            alışverişDetayıDGV.Columns.AddRange(new DataGridViewColumn[] { SıraNo2, Tarih2, UrunAdı2, BirimFiyati, Miktar, ToplamTutar, OdemeSekli });
            alışverişDetayıDGV.Location = new Point(6, 29);
            alışverişDetayıDGV.Name = "alışverişDetayıDGV";
            alışverişDetayıDGV.RowHeadersWidth = 51;
            alışverişDetayıDGV.Size = new Size(886, 275);
            alışverişDetayıDGV.TabIndex = 0;
            // 
            // SıraNo2
            // 
            SıraNo2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SıraNo2.HeaderText = "Sıra No";
            SıraNo2.MinimumWidth = 6;
            SıraNo2.Name = "SıraNo2";
            SıraNo2.Resizable = DataGridViewTriState.False;
            // 
            // Tarih2
            // 
            Tarih2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Tarih2.HeaderText = "Tarih";
            Tarih2.MinimumWidth = 6;
            Tarih2.Name = "Tarih2";
            Tarih2.Resizable = DataGridViewTriState.False;
            // 
            // UrunAdı2
            // 
            UrunAdı2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            UrunAdı2.HeaderText = "Ürün Adı";
            UrunAdı2.MinimumWidth = 6;
            UrunAdı2.Name = "UrunAdı2";
            UrunAdı2.Resizable = DataGridViewTriState.False;
            // 
            // BirimFiyati
            // 
            BirimFiyati.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BirimFiyati.HeaderText = "Birim Fiyatı";
            BirimFiyati.MinimumWidth = 6;
            BirimFiyati.Name = "BirimFiyati";
            BirimFiyati.Resizable = DataGridViewTriState.False;
            // 
            // Miktar
            // 
            Miktar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Miktar.HeaderText = "Miktar";
            Miktar.MinimumWidth = 6;
            Miktar.Name = "Miktar";
            Miktar.Resizable = DataGridViewTriState.False;
            // 
            // ToplamTutar
            // 
            ToplamTutar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ToplamTutar.HeaderText = "Toplam Tutar";
            ToplamTutar.MinimumWidth = 6;
            ToplamTutar.Name = "ToplamTutar";
            ToplamTutar.Resizable = DataGridViewTriState.False;
            // 
            // OdemeSekli
            // 
            OdemeSekli.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            OdemeSekli.HeaderText = "Ödeme Şekli";
            OdemeSekli.MinimumWidth = 6;
            OdemeSekli.Name = "OdemeSekli";
            OdemeSekli.Resizable = DataGridViewTriState.False;
            // 
            // lblUrunToplami
            // 
            lblUrunToplami.AutoSize = true;
            lblUrunToplami.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblUrunToplami.Location = new Point(573, 340);
            lblUrunToplami.Name = "lblUrunToplami";
            lblUrunToplami.Size = new Size(116, 23);
            lblUrunToplami.TabIndex = 1;
            lblUrunToplami.Text = "Ürün Toplamı:";
            // 
            // txtUrunToplami
            // 
            txtUrunToplami.Location = new Point(695, 337);
            txtUrunToplami.Name = "txtUrunToplami";
            txtUrunToplami.ReadOnly = true;
            txtUrunToplami.Size = new Size(197, 30);
            txtUrunToplami.TabIndex = 2;
            // 
            // MusteriBorcuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 924);
            Controls.Add(grpAlışverişDetayı);
            Controls.Add(grpBorçDetayı);
            Controls.Add(btnMakePayment);
            Controls.Add(btnAddDebt);
            Controls.Add(btnInstallments);
            Controls.Add(grpDateRange);
            Name = "MusteriBorcuForm";
            Text = "MusteriBorcuForm";
            grpDateRange.ResumeLayout(false);
            grpBorçDetayı.ResumeLayout(false);
            grpBorçDetayı.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)borcDetayiDGV).EndInit();
            grpAlışverişDetayı.ResumeLayout(false);
            grpAlışverişDetayı.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)alışverişDetayıDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private GroupBox grpDateRange;
        private Button btnInstallments;
        private Button btnAddDebt;
        private Button btnMakePayment;
        private GroupBox grpBorçDetayı;
        private TextBox txtCustomerName;
        private Label lblCustomerName;
        private Label lblKalanTaksitTutari;
        private TextBox txtKalanTaksitTutari;
        private TextBox txtVeresiyeBorcu;
        private Label lblVeresiyeBorcu;
        private DataGridView borcDetayiDGV;
        private TextBox txtOdemesiGerekenTaksit;
        private Label lblOdemesiGerekenTaksit;
        private DataGridViewTextBoxColumn SıraNo;
        private DataGridViewTextBoxColumn Tarih;
        private DataGridViewTextBoxColumn IslemTuru;
        private DataGridViewTextBoxColumn OncekiBakiye;
        private DataGridViewTextBoxColumn IslemTutari;
        private DataGridViewTextBoxColumn KalanBorc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grpAlışverişDetayı;
        private DataGridView alışverişDetayıDGV;
        private DataGridViewTextBoxColumn SıraNo2;
        private DataGridViewTextBoxColumn Tarih2;
        private DataGridViewTextBoxColumn UrunAdı2;
        private DataGridViewTextBoxColumn BirimFiyati;
        private DataGridViewTextBoxColumn Miktar;
        private DataGridViewTextBoxColumn ToplamTutar;
        private DataGridViewTextBoxColumn OdemeSekli;
        private TextBox txtUrunToplami;
        private Label lblUrunToplami;
    }
}