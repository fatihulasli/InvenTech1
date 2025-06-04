namespace InvenTech
{
    partial class SalesForm
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
            btnSelectCustomer = new Button();
            lblQuantityText = new Label();
            txtQuantity = new TextBox();
            barcodenumber = new Label();
            txtBarcode = new TextBox();
            btnSearchProduct = new Button();
            btnCancelProduct = new Button();
            dataGridView1 = new DataGridView();
            Barcode = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            grpPayment = new GroupBox();
            rbCash = new RadioButton();
            rbCard = new RadioButton();
            rbDebt = new RadioButton();
            lblTotalText = new Label();
            lblTotalAmount = new Label();
            btnConfirmSale = new Button();
            btnCancelSale = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpPayment.SuspendLayout();
            SuspendLayout();
            // 
            // btnSelectCustomer
            // 
            btnSelectCustomer.Location = new Point(12, 12);
            btnSelectCustomer.Name = "btnSelectCustomer";
            btnSelectCustomer.Size = new Size(126, 31);
            btnSelectCustomer.TabIndex = 0;
            btnSelectCustomer.Text = "\"Müşteri Seç\"";
            btnSelectCustomer.UseVisualStyleBackColor = true;
            // 
            // lblQuantityText
            // 
            lblQuantityText.AutoSize = true;
            lblQuantityText.Location = new Point(27, 59);
            lblQuantityText.Name = "lblQuantityText";
            lblQuantityText.Size = new Size(92, 20);
            lblQuantityText.TabIndex = 1;
            lblQuantityText.Text = "\"Miktar (F3)\"";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(125, 56);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 2;
            // 
            // barcodenumber
            // 
            barcodenumber.AutoSize = true;
            barcodenumber.Location = new Point(275, 59);
            barcodenumber.Name = "barcodenumber";
            barcodenumber.Size = new Size(126, 20);
            barcodenumber.TabIndex = 3;
            barcodenumber.Text = "Barkod Numarası:";
            // 
            // txtBarcode
            // 
            txtBarcode.Location = new Point(407, 56);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(125, 27);
            txtBarcode.TabIndex = 4;
            
            // 
            // btnSearchProduct
            // 
            btnSearchProduct.Location = new Point(563, 51);
            btnSearchProduct.Name = "btnSearchProduct";
            btnSearchProduct.Size = new Size(114, 32);
            btnSearchProduct.TabIndex = 5;
            btnSearchProduct.Text = "\"Ürün Ara\"\n";
            btnSearchProduct.UseVisualStyleBackColor = true;
            // 
            // btnCancelProduct
            // 
            btnCancelProduct.Location = new Point(708, 51);
            btnCancelProduct.Name = "btnCancelProduct";
            btnCancelProduct.Size = new Size(108, 32);
            btnCancelProduct.TabIndex = 6;
            btnCancelProduct.Text = "\"İptal Et\"\n\n";
            btnCancelProduct.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Barcode, ProductName, Stock, Price, Quantity, Total });
            dataGridView1.Location = new Point(12, 89);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(804, 256);
            dataGridView1.TabIndex = 7;
            // 
            // Barcode
            // 
            Barcode.HeaderText = "Barkod";
            Barcode.MinimumWidth = 6;
            Barcode.Name = "Barcode";
            Barcode.ReadOnly = true;
            Barcode.Width = 125;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "UrunAdi";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 125;
            // 
            // Stock
            // 
            Stock.HeaderText = "KalanStok";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            Stock.Width = 125;
            // 
            // Price
            // 
            Price.HeaderText = "Fiyat";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 125;
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Miktar";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 125;
            // 
            // Total
            // 
            Total.HeaderText = "ToplamTutar";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 125;
            // 
            // grpPayment
            // 
            grpPayment.Controls.Add(rbDebt);
            grpPayment.Controls.Add(rbCard);
            grpPayment.Controls.Add(rbCash);
            grpPayment.Location = new Point(12, 361);
            grpPayment.Name = "grpPayment";
            grpPayment.Size = new Size(284, 134);
            grpPayment.TabIndex = 8;
            grpPayment.TabStop = false;
            grpPayment.Text = "\"Ödeme Yöntemi\"\n";
            // 
            // rbCash
            // 
            rbCash.AutoSize = true;
            rbCash.Location = new Point(9, 26);
            rbCash.Name = "rbCash";
            rbCash.Size = new Size(77, 24);
            rbCash.TabIndex = 9;
            rbCash.TabStop = true;
            rbCash.Text = "\"Nakit\"\n";
            rbCash.UseVisualStyleBackColor = true;
            // 
            // rbCard
            // 
            rbCard.AutoSize = true;
            rbCard.Location = new Point(9, 56);
            rbCard.Name = "rbCard";
            rbCard.Size = new Size(112, 24);
            rbCard.TabIndex = 10;
            rbCard.TabStop = true;
            rbCard.Text = "\"Kredi Kartı\"\n";
            rbCard.UseVisualStyleBackColor = true;
            // 
            // rbDebt
            // 
            rbDebt.AutoSize = true;
            rbDebt.Location = new Point(9, 86);
            rbDebt.Name = "rbDebt";
            rbDebt.Size = new Size(104, 24);
            rbDebt.TabIndex = 11;
            rbDebt.TabStop = true;
            rbDebt.Text = "\" Veresiye \"";
            rbDebt.UseVisualStyleBackColor = true;
            // 
            // lblTotalText
            // 
            lblTotalText.AutoSize = true;
            lblTotalText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTotalText.Location = new Point(360, 374);
            lblTotalText.Name = "lblTotalText";
            lblTotalText.Size = new Size(130, 28);
            lblTotalText.TabIndex = 9;
            lblTotalText.Text = "Toplam Tutar:\n";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTotalAmount.ForeColor = Color.Red;
            lblTotalAmount.Location = new Point(496, 374);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(88, 28);
            lblTotalAmount.TabIndex = 10;
            lblTotalAmount.Text = "asfasfas";
            // 
            // btnConfirmSale
            // 
            btnConfirmSale.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnConfirmSale.Location = new Point(360, 415);
            btnConfirmSale.Name = "btnConfirmSale";
            btnConfirmSale.Size = new Size(130, 66);
            btnConfirmSale.TabIndex = 11;
            btnConfirmSale.Text = "Satışı Onayla";
            btnConfirmSale.UseVisualStyleBackColor = true;
            // 
            // btnCancelSale
            // 
            btnCancelSale.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCancelSale.Location = new Point(539, 417);
            btnCancelSale.Name = "btnCancelSale";
            btnCancelSale.Size = new Size(138, 66);
            btnCancelSale.TabIndex = 12;
            btnCancelSale.Text = "Satışı İptal Et";
            btnCancelSale.UseVisualStyleBackColor = true;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 563);
            Controls.Add(btnCancelSale);
            Controls.Add(btnConfirmSale);
            Controls.Add(lblTotalAmount);
            Controls.Add(lblTotalText);
            Controls.Add(grpPayment);
            Controls.Add(dataGridView1);
            Controls.Add(btnCancelProduct);
            Controls.Add(btnSearchProduct);
            Controls.Add(txtBarcode);
            Controls.Add(barcodenumber);
            Controls.Add(txtQuantity);
            Controls.Add(lblQuantityText);
            Controls.Add(btnSelectCustomer);
            Name = "SalesForm";
            Text = "SalesForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpPayment.ResumeLayout(false);
            grpPayment.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectCustomer;
        private Label lblQuantityText;
        private TextBox txtQuantity;
        private Label barcodenumber;
        private TextBox txtBarcode;
        private Button btnSearchProduct;
        private Button btnCancelProduct;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Barcode;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Total;
        private GroupBox grpPayment;
        private RadioButton rbDebt;
        private RadioButton rbCard;
        private RadioButton rbCash;
        private Label lblTotalText;
        private Label lblTotalAmount;
        private Button btnConfirmSale;
        private Button btnCancelSale;
    }
}