namespace InvenTech
{
    partial class NewCustomerForm
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
            label1 = new Label();
            label2 = new Label();
            txtCustomerName = new TextBox();
            txtHomePhone = new TextBox();
            txtWorkPhone = new TextBox();
            txtGSMPhone = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dtpBirthDate = new DateTimePicker();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtLimit = new TextBox();
            txtCarriedDebt = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(163, 9);
            label1.Name = "label1";
            label1.Size = new Size(209, 31);
            label1.TabIndex = 0;
            label1.Text = "Müşteri Yeni Kayıt";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 58);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Adı Soyadı :";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(163, 58);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(270, 27);
            txtCustomerName.TabIndex = 2;
            // 
            // txtHomePhone
            // 
            txtHomePhone.Location = new Point(163, 99);
            txtHomePhone.Name = "txtHomePhone";
            txtHomePhone.Size = new Size(270, 27);
            txtHomePhone.TabIndex = 3;
            // 
            // txtWorkPhone
            // 
            txtWorkPhone.Location = new Point(163, 181);
            txtWorkPhone.Name = "txtWorkPhone";
            txtWorkPhone.Size = new Size(270, 27);
            txtWorkPhone.TabIndex = 5;
            // 
            // txtGSMPhone
            // 
            txtGSMPhone.Location = new Point(163, 140);
            txtGSMPhone.Name = "txtGSMPhone";
            txtGSMPhone.Size = new Size(270, 27);
            txtGSMPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(163, 263);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(270, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(163, 222);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(270, 27);
            txtAddress.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 99);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 8;
            label3.Text = "Ev Telefonu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 181);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 10;
            label4.Text = "İş Telefonu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 140);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 9;
            label5.Text = "GSM Telefonu:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(102, 263);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 12;
            label6.Text = "E-mail:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(107, 222);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 11;
            label7.Text = "Adres:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(163, 304);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(270, 27);
            dtpBirthDate.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(56, 304);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 14;
            label8.Text = "Doğum Tarihi:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(66, 389);
            label9.Name = "label9";
            label9.Size = new Size(91, 20);
            label9.TabIndex = 18;
            label9.Text = "Limit Belirle:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(47, 345);
            label10.Name = "label10";
            label10.Size = new Size(110, 20);
            label10.TabIndex = 17;
            label10.Text = "Devreden Borç:";
            // 
            // txtLimit
            // 
            txtLimit.Location = new Point(163, 386);
            txtLimit.Name = "txtLimit";
            txtLimit.Size = new Size(270, 27);
            txtLimit.TabIndex = 16;
            // 
            // txtCarriedDebt
            // 
            txtCarriedDebt.Location = new Point(163, 345);
            txtCarriedDebt.Name = "txtCarriedDebt";
            txtCarriedDebt.Size = new Size(270, 27);
            txtCarriedDebt.TabIndex = 15;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(163, 439);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(105, 57);
            btnSave.TabIndex = 19;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(328, 439);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 57);
            btnCancel.TabIndex = 20;
            btnCancel.Text = "Vazgeç";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // NewCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 544);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(txtLimit);
            Controls.Add(txtCarriedDebt);
            Controls.Add(label8);
            Controls.Add(dtpBirthDate);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(txtAddress);
            Controls.Add(txtWorkPhone);
            Controls.Add(txtGSMPhone);
            Controls.Add(txtHomePhone);
            Controls.Add(txtCustomerName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewCustomerForm";
            Text = " ";
            Load += NewCustomerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCustomerName;
        private TextBox txtHomePhone;
        private TextBox txtWorkPhone;
        private TextBox txtGSMPhone;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpBirthDate;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtLimit;
        private TextBox txtCarriedDebt;
        private Button btnSave;
        private Button btnCancel;
    }
}