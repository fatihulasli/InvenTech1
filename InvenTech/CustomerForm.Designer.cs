namespace InvenTech
{
    partial class CustomerForm
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
            label3 = new Label();
            txtGSMPhone = new TextBox();
            label4 = new Label();
            txtWorkPhone = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            label6 = new Label();
            txtNotes = new TextBox();
            label7 = new Label();
            txtEmail = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtLimit = new TextBox();
            txtVeresiyeToplam = new TextBox();
            label12 = new Label();
            label13 = new Label();
            txtKalanTaksitToplam = new TextBox();
            txtTotalDebt = new TextBox();
            label14 = new Label();
            btnDebtDetails = new Button();
            btnAddDebt = new Button();
            btnMakePayment = new Button();
            dgvCustomerList = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            CarriedDebt = new DataGridViewTextBoxColumn();
            txtSearchCustomer = new TextBox();
            label15 = new Label();
            label16 = new Label();
            btnAddCustomer = new Button();
            btnEditCustomer = new Button();
            btnReturnItem = new Button();
            btnDeleteCustomer = new Button();
            btnDelayedPayments = new Button();
            btnDebtList = new Button();
            label17 = new Label();
            lblTotalVeresiye = new Label();
            label18 = new Label();
            lblTotalTaksit = new Label();
            txtBirthDate = new TextBox();
            txtRegistrationDate = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(303, 9);
            label1.Name = "label1";
            label1.Size = new Size(188, 31);
            label1.TabIndex = 0;
            label1.Text = "Müşteri Bilgileri";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 47);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "Adı Soyadı:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(158, 47);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.ReadOnly = true;
            txtCustomerName.Size = new Size(203, 27);
            txtCustomerName.TabIndex = 2;
            // 
            // txtHomePhone
            // 
            txtHomePhone.Location = new Point(158, 87);
            txtHomePhone.Name = "txtHomePhone";
            txtHomePhone.ReadOnly = true;
            txtHomePhone.Size = new Size(203, 27);
            txtHomePhone.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 87);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 3;
            label3.Text = "Ev Telefonu:";
            // 
            // txtGSMPhone
            // 
            txtGSMPhone.Location = new Point(158, 127);
            txtGSMPhone.Name = "txtGSMPhone";
            txtGSMPhone.ReadOnly = true;
            txtGSMPhone.Size = new Size(203, 27);
            txtGSMPhone.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 127);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 7;
            label4.Text = "GSM Telefonu:";
            // 
            // txtWorkPhone
            // 
            txtWorkPhone.Location = new Point(158, 167);
            txtWorkPhone.Name = "txtWorkPhone";
            txtWorkPhone.ReadOnly = true;
            txtWorkPhone.Size = new Size(203, 27);
            txtWorkPhone.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 167);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 5;
            label5.Text = "İş Telefonu:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(158, 207);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(203, 86);
            txtAddress.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(106, 207);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 9;
            label6.Text = "Adres:";
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(158, 306);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ReadOnly = true;
            txtNotes.Size = new Size(203, 86);
            txtNotes.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(68, 306);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 11;
            label7.Text = "Özel Notlar:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(555, 44);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(203, 27);
            txtEmail.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(496, 44);
            label8.Name = "label8";
            label8.Size = new Size(53, 20);
            label8.TabIndex = 13;
            label8.Text = "E mail:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(448, 87);
            label9.Name = "label9";
            label9.Size = new Size(101, 20);
            label9.TabIndex = 16;
            label9.Text = "Doğum Tarihi:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(465, 127);
            label10.Name = "label10";
            label10.Size = new Size(84, 20);
            label10.TabIndex = 17;
            label10.Text = "Kayıt Tarihi:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(557, 167);
            label11.Name = "label11";
            label11.Size = new Size(115, 20);
            label11.TabIndex = 19;
            label11.Text = "Belirlenen Limit:";
            // 
            // txtLimit
            // 
            txtLimit.BackColor = SystemColors.Info;
            txtLimit.Location = new Point(675, 167);
            txtLimit.Name = "txtLimit";
            txtLimit.ReadOnly = true;
            txtLimit.Size = new Size(203, 27);
            txtLimit.TabIndex = 20;
            // 
            // txtVeresiyeToplam
            // 
            txtVeresiyeToplam.BackColor = SystemColors.Highlight;
            txtVeresiyeToplam.Location = new Point(675, 204);
            txtVeresiyeToplam.Name = "txtVeresiyeToplam";
            txtVeresiyeToplam.ReadOnly = true;
            txtVeresiyeToplam.Size = new Size(203, 27);
            txtVeresiyeToplam.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(548, 204);
            label12.Name = "label12";
            label12.Size = new Size(124, 20);
            label12.TabIndex = 21;
            label12.Text = "Veresiye Toplamı:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(525, 240);
            label13.Name = "label13";
            label13.Size = new Size(147, 20);
            label13.TabIndex = 23;
            label13.Text = "Kalan Taksit Toplamı:";
            // 
            // txtKalanTaksitToplam
            // 
            txtKalanTaksitToplam.BackColor = Color.OliveDrab;
            txtKalanTaksitToplam.Location = new Point(675, 240);
            txtKalanTaksitToplam.Name = "txtKalanTaksitToplam";
            txtKalanTaksitToplam.ReadOnly = true;
            txtKalanTaksitToplam.Size = new Size(203, 27);
            txtKalanTaksitToplam.TabIndex = 24;
            // 
            // txtTotalDebt
            // 
            txtTotalDebt.BackColor = Color.Red;
            txtTotalDebt.Location = new Point(675, 273);
            txtTotalDebt.Name = "txtTotalDebt";
            txtTotalDebt.ReadOnly = true;
            txtTotalDebt.Size = new Size(203, 27);
            txtTotalDebt.TabIndex = 26;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(576, 273);
            label14.Name = "label14";
            label14.Size = new Size(96, 20);
            label14.TabIndex = 25;
            label14.Text = "Toplam Borç:";
            // 
            // btnDebtDetails
            // 
            btnDebtDetails.Location = new Point(555, 321);
            btnDebtDetails.Name = "btnDebtDetails";
            btnDebtDetails.Size = new Size(94, 60);
            btnDebtDetails.TabIndex = 27;
            btnDebtDetails.Text = "Müşteri Borç Detayı";
            btnDebtDetails.UseVisualStyleBackColor = true;
            // 
            // btnAddDebt
            // 
            btnAddDebt.Location = new Point(669, 321);
            btnAddDebt.Name = "btnAddDebt";
            btnAddDebt.Size = new Size(94, 60);
            btnAddDebt.TabIndex = 28;
            btnAddDebt.Text = "Hesaba Borç Ekle";
            btnAddDebt.UseVisualStyleBackColor = true;
            // 
            // btnMakePayment
            // 
            btnMakePayment.Location = new Point(783, 321);
            btnMakePayment.Name = "btnMakePayment";
            btnMakePayment.Size = new Size(94, 60);
            btnMakePayment.TabIndex = 29;
            btnMakePayment.Text = "Tahsilat Yap";
            btnMakePayment.UseVisualStyleBackColor = true;
            // 
            // dgvCustomerList
            // 
            dgvCustomerList.CausesValidation = false;
            dgvCustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerList.Columns.AddRange(new DataGridViewColumn[] { CustomerID, CustomerName, CarriedDebt });
            dgvCustomerList.Location = new Point(0, 505);
            dgvCustomerList.Name = "dgvCustomerList";
            dgvCustomerList.RowHeadersWidth = 51;
            dgvCustomerList.Size = new Size(592, 377);
            dgvCustomerList.TabIndex = 31;
            dgvCustomerList.CellContentClick += dgvCustomerList_CellContentClick;
            dgvCustomerList.SelectionChanged += dgvCustomerList_SelectionChanged;
            // 
            // CustomerID
            // 
            CustomerID.DataPropertyName = "CustomerID";
            CustomerID.HeaderText = "Sıra No";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.Width = 90;
            // 
            // CustomerName
            // 
            CustomerName.DataPropertyName = "CustomerName";
            CustomerName.HeaderText = "Müşterinin Adı";
            CustomerName.MinimumWidth = 6;
            CustomerName.Name = "CustomerName";
            CustomerName.Width = 300;
            // 
            // CarriedDebt
            // 
            CarriedDebt.DataPropertyName = "CarriedDebt";
            CarriedDebt.HeaderText = "Borcu";
            CarriedDebt.MinimumWidth = 6;
            CarriedDebt.Name = "CarriedDebt";
            CarriedDebt.Width = 150;
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Location = new Point(139, 472);
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.Size = new Size(303, 27);
            txtSearchCustomer.TabIndex = 32;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(45, 472);
            label15.Name = "label15";
            label15.Size = new Size(88, 20);
            label15.TabIndex = 33;
            label15.Text = "Müşteri Ara:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label16.Location = new Point(205, 449);
            label16.Name = "label16";
            label16.Size = new Size(168, 20);
            label16.TabIndex = 34;
            label16.Text = "<<< ADI SOYADI >>>";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(636, 505);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(122, 101);
            btnAddCustomer.TabIndex = 35;
            btnAddCustomer.Text = "Müşteri Ekle";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.Location = new Point(783, 505);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(122, 101);
            btnEditCustomer.TabIndex = 41;
            btnEditCustomer.Text = "Müşteri Bilgilerini Düzenle";
            btnEditCustomer.UseVisualStyleBackColor = true;
            // 
            // btnReturnItem
            // 
            btnReturnItem.Location = new Point(783, 643);
            btnReturnItem.Name = "btnReturnItem";
            btnReturnItem.Size = new Size(122, 101);
            btnReturnItem.TabIndex = 43;
            btnReturnItem.Text = "Müşteriden İade Al";
            btnReturnItem.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(636, 643);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(122, 101);
            btnDeleteCustomer.TabIndex = 42;
            btnDeleteCustomer.Text = "Müşteri Sil";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // btnDelayedPayments
            // 
            btnDelayedPayments.Location = new Point(783, 781);
            btnDelayedPayments.Name = "btnDelayedPayments";
            btnDelayedPayments.Size = new Size(122, 101);
            btnDelayedPayments.TabIndex = 45;
            btnDelayedPayments.Text = "Taksit Ödemelerini Geciktiren Müşteriler";
            btnDelayedPayments.UseVisualStyleBackColor = true;
            // 
            // btnDebtList
            // 
            btnDebtList.Location = new Point(636, 781);
            btnDebtList.Name = "btnDebtList";
            btnDebtList.Size = new Size(122, 101);
            btnDebtList.TabIndex = 44;
            btnDebtList.Text = "Müşteri Borç Listesi";
            btnDebtList.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label17.Location = new Point(12, 910);
            label17.Name = "label17";
            label17.Size = new Size(330, 28);
            label17.TabIndex = 46;
            label17.Text = "Tüm Müşterilerin Veresiye Toplamı:";
            // 
            // lblTotalVeresiye
            // 
            lblTotalVeresiye.AutoSize = true;
            lblTotalVeresiye.BackColor = Color.Red;
            lblTotalVeresiye.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTotalVeresiye.Location = new Point(348, 910);
            lblTotalVeresiye.Name = "lblTotalVeresiye";
            lblTotalVeresiye.Size = new Size(0, 28);
            lblTotalVeresiye.TabIndex = 47;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label18.Location = new Point(12, 962);
            label18.Name = "label18";
            label18.Size = new Size(407, 28);
            label18.TabIndex = 48;
            label18.Text = "Tüm Müşterilerin Ödeyeceği Taksit Toplamı:";
            // 
            // lblTotalTaksit
            // 
            lblTotalTaksit.AutoSize = true;
            lblTotalTaksit.BackColor = Color.Red;
            lblTotalTaksit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTotalTaksit.Location = new Point(425, 969);
            lblTotalTaksit.Name = "lblTotalTaksit";
            lblTotalTaksit.Size = new Size(0, 25);
            lblTotalTaksit.TabIndex = 49;
            // 
            // txtBirthDate
            // 
            txtBirthDate.Location = new Point(555, 84);
            txtBirthDate.Name = "txtBirthDate";
            txtBirthDate.ReadOnly = true;
            txtBirthDate.Size = new Size(203, 27);
            txtBirthDate.TabIndex = 50;
            // 
            // txtRegistrationDate
            // 
            txtRegistrationDate.Location = new Point(555, 127);
            txtRegistrationDate.Name = "txtRegistrationDate";
            txtRegistrationDate.ReadOnly = true;
            txtRegistrationDate.Size = new Size(203, 27);
            txtRegistrationDate.TabIndex = 51;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 1029);
            Controls.Add(txtRegistrationDate);
            Controls.Add(txtBirthDate);
            Controls.Add(lblTotalTaksit);
            Controls.Add(label18);
            Controls.Add(lblTotalVeresiye);
            Controls.Add(label17);
            Controls.Add(btnDelayedPayments);
            Controls.Add(btnDebtList);
            Controls.Add(btnReturnItem);
            Controls.Add(btnDeleteCustomer);
            Controls.Add(btnEditCustomer);
            Controls.Add(btnAddCustomer);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(txtSearchCustomer);
            Controls.Add(dgvCustomerList);
            Controls.Add(btnMakePayment);
            Controls.Add(btnAddDebt);
            Controls.Add(btnDebtDetails);
            Controls.Add(txtTotalDebt);
            Controls.Add(label14);
            Controls.Add(txtKalanTaksitToplam);
            Controls.Add(label13);
            Controls.Add(txtVeresiyeToplam);
            Controls.Add(label12);
            Controls.Add(txtLimit);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtEmail);
            Controls.Add(label8);
            Controls.Add(txtNotes);
            Controls.Add(label7);
            Controls.Add(txtAddress);
            Controls.Add(label6);
            Controls.Add(txtGSMPhone);
            Controls.Add(label4);
            Controls.Add(txtWorkPhone);
            Controls.Add(label5);
            Controls.Add(txtHomePhone);
            Controls.Add(label3);
            Controls.Add(txtCustomerName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomerForm";
            Text = "CustomerForm";
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCustomerName;
        private TextBox txtHomePhone;
        private Label label3;
        private TextBox txtGSMPhone;
        private Label label4;
        private TextBox txtWorkPhone;
        private Label label5;
        private TextBox txtAddress;
        private Label label6;
        private TextBox txtNotes;
        private Label label7;
        private TextBox txtEmail;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtLimit;
        private TextBox txtVeresiyeToplam;
        private Label label12;
        private Label label13;
        private TextBox txtKalanTaksitToplam;
        private TextBox txtTotalDebt;
        private Label label14;
        private Button btnDebtDetails;
        private Button btnAddDebt;
        private Button btnMakePayment;
        private DataGridView dgvCustomerList;
        private TextBox txtSearchCustomer;
        private Label label15;
        private Label label16;
        private Button btnAddCustomer;
        private Button btnEditCustomer;
        private Button btnReturnItem;
        private Button btnDeleteCustomer;
        private Button btnDelayedPayments;
        private Button btnDebtList;
        private Label label17;
        private Label lblTotalVeresiye;
        private Label label18;
        private Label lblTotalTaksit;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn CarriedDebt;
        private TextBox txtBirthDate;
        private TextBox txtRegistrationDate;
    }
}