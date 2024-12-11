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
            button1 = new Button();
            button2 = new Button();
            groupBoxDept = new GroupBox();
            dgvDebtDetails = new DataGridView();
            groupBoxPurchase = new GroupBox();
            dgvPurchaseDetails = new DataGridView();
            txtSupplierName = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
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
            dateTimePicker1.Location = new Point(6, 26);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(134, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(172, 26);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(134, 27);
            dateTimePicker2.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(312, 70);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tarih Aralığı Seçin";
            // 
            // button1
            // 
            button1.Location = new Point(530, 18);
            button1.Name = "button1";
            button1.Size = new Size(137, 64);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(717, 18);
            button2.Name = "button2";
            button2.Size = new Size(137, 64);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // groupBoxDept
            // 
            groupBoxDept.Controls.Add(label2);
            groupBoxDept.Controls.Add(textBox1);
            groupBoxDept.Controls.Add(label1);
            groupBoxDept.Controls.Add(txtSupplierName);
            groupBoxDept.Controls.Add(dgvDebtDetails);
            groupBoxDept.ForeColor = Color.Blue;
            groupBoxDept.Location = new Point(12, 98);
            groupBoxDept.Name = "groupBoxDept";
            groupBoxDept.Size = new Size(1208, 387);
            groupBoxDept.TabIndex = 4;
            groupBoxDept.TabStop = false;
            groupBoxDept.Text = "Borç Detayı";
            // 
            // dgvDebtDetails
            // 
            dgvDebtDetails.BackgroundColor = Color.FromArgb(255, 128, 0);
            dgvDebtDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDebtDetails.Location = new Point(20, 62);
            dgvDebtDetails.Name = "dgvDebtDetails";
            dgvDebtDetails.RowHeadersWidth = 51;
            dgvDebtDetails.Size = new Size(1172, 319);
            dgvDebtDetails.TabIndex = 0;
            dgvDebtDetails.CellContentClick += dgvDebtDetails_CellContentClick;
            // 
            // groupBoxPurchase
            // 
            groupBoxPurchase.Controls.Add(textBox3);
            groupBoxPurchase.Controls.Add(textBox2);
            groupBoxPurchase.Controls.Add(label4);
            groupBoxPurchase.Controls.Add(label3);
            groupBoxPurchase.Controls.Add(dgvPurchaseDetails);
            groupBoxPurchase.ForeColor = Color.Blue;
            groupBoxPurchase.Location = new Point(12, 505);
            groupBoxPurchase.Name = "groupBoxPurchase";
            groupBoxPurchase.Size = new Size(1208, 356);
            groupBoxPurchase.TabIndex = 5;
            groupBoxPurchase.TabStop = false;
            groupBoxPurchase.Text = "Alış Detayı";
            // 
            // dgvPurchaseDetails
            // 
            dgvPurchaseDetails.BackgroundColor = Color.FromArgb(255, 128, 0);
            dgvPurchaseDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPurchaseDetails.Location = new Point(20, 62);
            dgvPurchaseDetails.Name = "dgvPurchaseDetails";
            dgvPurchaseDetails.RowHeadersWidth = 51;
            dgvPurchaseDetails.Size = new Size(1172, 288);
            dgvPurchaseDetails.TabIndex = 0;
            dgvPurchaseDetails.CellContentClick += dgvPurchaseDetails_CellContentClick;
            // 
            // txtSupplierName
            // 
            txtSupplierName.BackColor = Color.FromArgb(255, 224, 192);
            txtSupplierName.Location = new Point(272, 25);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.ReadOnly = true;
            txtSupplierName.Size = new Size(262, 27);
            txtSupplierName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 29);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 2;
            label1.Text = "Toptancının Adı :";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Red;
            textBox1.Location = new Point(745, 26);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(275, 27);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(602, 28);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 5;
            label2.Text = "Kalan Borç Miktarı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 26);
            label3.Name = "label3";
            label3.Size = new Size(223, 20);
            label3.TabIndex = 1;
            label3.Text = "Fatura Numarasına Göre Arama :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(634, 26);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 2;
            label4.Text = "Ürün Toplamı :";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(255, 224, 192);
            textBox2.Location = new Point(272, 23);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(262, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Red;
            textBox3.Location = new Point(745, 23);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(275, 27);
            textBox3.TabIndex = 4;
            // 
            // SupplierAccountDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 873);
            Controls.Add(groupBoxPurchase);
            Controls.Add(groupBoxDept);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
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
        private Button button1;
        private Button button2;
        private GroupBox groupBoxDept;
        private DataGridView dgvDebtDetails;
        private GroupBox groupBoxPurchase;
        private DataGridView dgvPurchaseDetails;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox txtSupplierName;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
    }
}