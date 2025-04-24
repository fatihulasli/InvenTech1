namespace InvenTech
{
    partial class WholesalerPaymentForm
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
            label1 = new Label();
            txtTotalDebt = new TextBox();
            txtAmount = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmbPaymentMethod = new ComboBox();
            dtpDate = new DateTimePicker();
            dtpTime = new DateTimePicker();
            label4 = new Label();
            txtDescription = new RichTextBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(145, 41);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.ReadOnly = true;
            txtSupplierName.Size = new Size(125, 27);
            txtSupplierName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 44);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 1;
            label1.Text = "Toptancı Adı";
            // 
            // txtTotalDebt
            // 
            txtTotalDebt.Location = new Point(145, 87);
            txtTotalDebt.Name = "txtTotalDebt";
            txtTotalDebt.Size = new Size(125, 27);
            txtTotalDebt.TabIndex = 2;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(145, 225);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(125, 27);
            txtAmount.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 85);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 4;
            label2.Text = "Toplam Borç";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 132);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 5;
            label3.Text = "Tarih";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "Kredi Kartı", "Nakit", "Çek" });
            cmbPaymentMethod.Location = new Point(145, 339);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(151, 28);
            cmbPaymentMethod.TabIndex = 7;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(145, 133);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(250, 27);
            dtpDate.TabIndex = 8;
            // 
            // dtpTime
            // 
            dtpTime.CustomFormat = "HH:mm";
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.Location = new Point(145, 179);
            dtpTime.Name = "dtpTime";
            dtpTime.Size = new Size(250, 27);
            dtpTime.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 176);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 11;
            label4.Text = "Saat";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(145, 271);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(235, 49);
            txtDescription.TabIndex = 12;
            txtDescription.Text = "";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(76, 175, 80);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(145, 385);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(94, 53);
            btnConfirm.TabIndex = 13;
            btnConfirm.Text = "Onayla";
            btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(244, 67, 54);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(301, 385);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 53);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Vazgeç";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 339);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 15;
            label5.Text = "Ödeme Şekli";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 271);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 16;
            label6.Text = "Açıklama";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 228);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 17;
            label7.Text = "Ödeme Tutarı";
            // 
            // WholesalerPaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(txtDescription);
            Controls.Add(label4);
            Controls.Add(dtpTime);
            Controls.Add(dtpDate);
            Controls.Add(cmbPaymentMethod);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtAmount);
            Controls.Add(txtTotalDebt);
            Controls.Add(label1);
            Controls.Add(txtSupplierName);
            Name = "WholesalerPaymentForm";
            Text = "WholesalerPaymentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSupplierName;
        private Label label1;
        private TextBox txtTotalDebt;
        private TextBox txtAmount;
        private Label label2;
        private Label label3;
        private ComboBox cmbPaymentMethod;
        private DateTimePicker dtpDate;
        private DateTimePicker dtpTime;
        private Label label4;
        private RichTextBox txtDescription;
        private Button btnConfirm;
        private Button btnCancel;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}