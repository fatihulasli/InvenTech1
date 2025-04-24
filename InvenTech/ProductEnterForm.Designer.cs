namespace InvenTech
{
    partial class ProductEnterForm
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
            txtBarcode = new TextBox();
            cmbProductGroup = new ComboBox();
            lblBarcode = new Label();
            txtPurchasePriceIncludingVAT = new TextBox();
            txtProductName = new TextBox();
            txtProductCode = new TextBox();
            txtPurchasePriceExcludingVAT = new TextBox();
            txtSalesPrice = new TextBox();
            txtVATRate = new TextBox();
            txtMinimumStock = new TextBox();
            txtSecondSalesPrice = new TextBox();
            txtUnit = new TextBox();
            txtStockQuantity = new TextBox();
            cmbPaymentMethod = new ComboBox();
            cmbSupplierName = new ComboBox();
            btnGenerateBarcodeNo = new Button();
            lblProductName = new Label();
            lblProductCode = new Label();
            lblProductGroup = new Label();
            btnAddNewProductGroup = new Button();
            lblPurchasePriceIncludingVAT = new Label();
            label1 = new Label();
            lblSalesPrice = new Label();
            lblSecondSalesPrice = new Label();
            lblVATRate = new Label();
            lblStockQuantity = new Label();
            lblUnit = new Label();
            lblMinimumStock = new Label();
            lblSupplierName = new Label();
            btnAddNewSupplier = new Button();
            lblPaymentMethod = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            btnSearchByProductName = new Button();
            btnInvoiceEntry = new Button();
            SuspendLayout();
            // 
            // txtBarcode
            // 
            txtBarcode.BackColor = Color.Yellow;
            txtBarcode.Location = new Point(552, 82);
            txtBarcode.Margin = new Padding(8, 7, 8, 7);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(694, 55);
            txtBarcode.TabIndex = 0;
            txtBarcode.TextChanged += txtBarcode_TextChanged;
            txtBarcode.KeyDown += txtBarcode_KeyDown;
            // 
            // cmbProductGroup
            // 
            cmbProductGroup.FormattingEnabled = true;
            cmbProductGroup.Location = new Point(552, 384);
            cmbProductGroup.Margin = new Padding(8, 7, 8, 7);
            cmbProductGroup.Name = "cmbProductGroup";
            cmbProductGroup.Size = new Size(694, 56);
            cmbProductGroup.TabIndex = 1;
            cmbProductGroup.SelectedIndexChanged += cmbProductGroup_SelectedIndexChanged;
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(310, 98);
            lblBarcode.Margin = new Padding(8, 0, 8, 0);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(198, 48);
            lblBarcode.TabIndex = 2;
            lblBarcode.Text = "Barkod No:";
            // 
            // txtPurchasePriceIncludingVAT
            // 
            txtPurchasePriceIncludingVAT.Location = new Point(552, 588);
            txtPurchasePriceIncludingVAT.Margin = new Padding(8, 7, 8, 7);
            txtPurchasePriceIncludingVAT.Name = "txtPurchasePriceIncludingVAT";
            txtPurchasePriceIncludingVAT.Size = new Size(306, 55);
            txtPurchasePriceIncludingVAT.TabIndex = 3;
            txtPurchasePriceIncludingVAT.TextChanged += txtPurchasePriceIncludingVAT_TextChanged;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(552, 182);
            txtProductName.Margin = new Padding(8, 7, 8, 7);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(869, 55);
            txtProductName.TabIndex = 4;
            txtProductName.TextChanged += txtProductName_TextChanged;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(552, 283);
            txtProductCode.Margin = new Padding(8, 7, 8, 7);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(694, 55);
            txtProductCode.TabIndex = 5;
            txtProductCode.TextChanged += txtProductCode_TextChanged;
            // 
            // txtPurchasePriceExcludingVAT
            // 
            txtPurchasePriceExcludingVAT.Location = new Point(552, 689);
            txtPurchasePriceExcludingVAT.Margin = new Padding(8, 7, 8, 7);
            txtPurchasePriceExcludingVAT.Name = "txtPurchasePriceExcludingVAT";
            txtPurchasePriceExcludingVAT.Size = new Size(306, 55);
            txtPurchasePriceExcludingVAT.TabIndex = 6;
            txtPurchasePriceExcludingVAT.TextChanged += txtPurchasePriceExcludingVAT_TextChanged;
            // 
            // txtSalesPrice
            // 
            txtSalesPrice.Location = new Point(552, 790);
            txtSalesPrice.Margin = new Padding(8, 7, 8, 7);
            txtSalesPrice.Name = "txtSalesPrice";
            txtSalesPrice.Size = new Size(306, 55);
            txtSalesPrice.TabIndex = 7;
            txtSalesPrice.TextChanged += txtSalesPrice_TextChanged;
            // 
            // txtVATRate
            // 
            txtVATRate.Location = new Point(552, 487);
            txtVATRate.Margin = new Padding(8, 7, 8, 7);
            txtVATRate.Name = "txtVATRate";
            txtVATRate.Size = new Size(182, 55);
            txtVATRate.TabIndex = 10;
            txtVATRate.TextChanged += txtVATRate_TextChanged;
            // 
            // txtMinimumStock
            // 
            txtMinimumStock.BackColor = Color.IndianRed;
            txtMinimumStock.Location = new Point(552, 1092);
            txtMinimumStock.Margin = new Padding(8, 7, 8, 7);
            txtMinimumStock.Name = "txtMinimumStock";
            txtMinimumStock.Size = new Size(306, 55);
            txtMinimumStock.TabIndex = 9;
            txtMinimumStock.TextChanged += txtMinimumStock_TextChanged;
            // 
            // txtSecondSalesPrice
            // 
            txtSecondSalesPrice.Location = new Point(552, 890);
            txtSecondSalesPrice.Margin = new Padding(8, 7, 8, 7);
            txtSecondSalesPrice.Name = "txtSecondSalesPrice";
            txtSecondSalesPrice.Size = new Size(306, 55);
            txtSecondSalesPrice.TabIndex = 8;
            txtSecondSalesPrice.TextChanged += txtSecondSalesPrice_TextChanged;
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(552, 1193);
            txtUnit.Margin = new Padding(8, 7, 8, 7);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(306, 55);
            txtUnit.TabIndex = 12;
            txtUnit.TextChanged += cmbUnit_TextChanged;
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.BackColor = Color.White;
            txtStockQuantity.Location = new Point(552, 991);
            txtStockQuantity.Margin = new Padding(8, 7, 8, 7);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(306, 55);
            txtStockQuantity.TabIndex = 11;
            txtStockQuantity.TextChanged += txtStockQuantity_TextChanged;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "Credit Card", "Bank Transfer", "To their debt" });
            cmbPaymentMethod.Location = new Point(552, 1397);
            cmbPaymentMethod.Margin = new Padding(8, 7, 8, 7);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(694, 56);
            cmbPaymentMethod.TabIndex = 13;
            cmbPaymentMethod.SelectedIndexChanged += cmbPaymentMethod_SelectedIndexChanged;
            // 
            // cmbSupplierName
            // 
            cmbSupplierName.FormattingEnabled = true;
            cmbSupplierName.Location = new Point(552, 1294);
            cmbSupplierName.Margin = new Padding(8, 7, 8, 7);
            cmbSupplierName.Name = "cmbSupplierName";
            cmbSupplierName.Size = new Size(694, 56);
            cmbSupplierName.TabIndex = 14;
            cmbSupplierName.SelectedIndexChanged += cmbSupplierName_SelectedIndexChanged;
            // 
            // btnGenerateBarcodeNo
            // 
            btnGenerateBarcodeNo.Location = new Point(1382, 43);
            btnGenerateBarcodeNo.Margin = new Padding(8, 7, 8, 7);
            btnGenerateBarcodeNo.Name = "btnGenerateBarcodeNo";
            btnGenerateBarcodeNo.Size = new Size(400, 125);
            btnGenerateBarcodeNo.TabIndex = 15;
            btnGenerateBarcodeNo.Text = "Otomatik Barkod No Ver";
            btnGenerateBarcodeNo.UseVisualStyleBackColor = true;
            btnGenerateBarcodeNo.Click += btnGenerateBarcodeNo_Click;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(270, 199);
            lblProductName.Margin = new Padding(8, 0, 8, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(209, 48);
            lblProductName.TabIndex = 16;
            lblProductName.Text = "Ürünün Adı:";
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new Point(58, 300);
            lblProductCode.Margin = new Padding(8, 0, 8, 0);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(375, 48);
            lblProductCode.TabIndex = 17;
            lblProductCode.Text = "Ürün Kodu - Açıklama:";
            // 
            // lblProductGroup
            // 
            lblProductGroup.AutoSize = true;
            lblProductGroup.Location = new Point(168, 403);
            lblProductGroup.Margin = new Padding(8, 0, 8, 0);
            lblProductGroup.Name = "lblProductGroup";
            lblProductGroup.Size = new Size(320, 48);
            lblProductGroup.TabIndex = 18;
            lblProductGroup.Text = "Ürün Grubunu Seç:";
            // 
            // btnAddNewProductGroup
            // 
            btnAddNewProductGroup.Location = new Point(1382, 334);
            btnAddNewProductGroup.Margin = new Padding(8, 7, 8, 7);
            btnAddNewProductGroup.Name = "btnAddNewProductGroup";
            btnAddNewProductGroup.Size = new Size(400, 118);
            btnAddNewProductGroup.TabIndex = 19;
            btnAddNewProductGroup.Text = "Yeni Ürün Grubu Ekle";
            btnAddNewProductGroup.UseVisualStyleBackColor = true;
            btnAddNewProductGroup.Click += btnAddNewProductGroup_Click;
            // 
            // lblPurchasePriceIncludingVAT
            // 
            lblPurchasePriceIncludingVAT.AutoSize = true;
            lblPurchasePriceIncludingVAT.Location = new Point(167, 591);
            lblPurchasePriceIncludingVAT.Margin = new Padding(8, 0, 8, 0);
            lblPurchasePriceIncludingVAT.Name = "lblPurchasePriceIncludingVAT";
            lblPurchasePriceIncludingVAT.Size = new Size(367, 48);
            lblPurchasePriceIncludingVAT.TabIndex = 20;
            lblPurchasePriceIncludingVAT.Text = "Alış Fiyatı (KDV Dahil):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 692);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(369, 48);
            label1.TabIndex = 22;
            label1.Text = "Alış Fiyatı (KDV Hariç):";
            // 
            // lblSalesPrice
            // 
            lblSalesPrice.AutoSize = true;
            lblSalesPrice.Location = new Point(332, 797);
            lblSalesPrice.Margin = new Padding(8, 0, 8, 0);
            lblSalesPrice.Name = "lblSalesPrice";
            lblSalesPrice.Size = new Size(194, 48);
            lblSalesPrice.TabIndex = 23;
            lblSalesPrice.Text = "Satış Fiyatı:";
            // 
            // lblSecondSalesPrice
            // 
            lblSecondSalesPrice.AutoSize = true;
            lblSecondSalesPrice.Location = new Point(200, 898);
            lblSecondSalesPrice.Margin = new Padding(8, 0, 8, 0);
            lblSecondSalesPrice.Name = "lblSecondSalesPrice";
            lblSecondSalesPrice.Size = new Size(287, 48);
            lblSecondSalesPrice.TabIndex = 24;
            lblSecondSalesPrice.Text = "İkinci Satış Fiyatı:";
            // 
            // lblVATRate
            // 
            lblVATRate.AutoSize = true;
            lblVATRate.Location = new Point(290, 490);
            lblVATRate.Margin = new Padding(8, 0, 8, 0);
            lblVATRate.Name = "lblVATRate";
            lblVATRate.Size = new Size(246, 48);
            lblVATRate.TabIndex = 25;
            lblVATRate.Text = "Vergi Oranı %:";
            // 
            // lblStockQuantity
            // 
            lblStockQuantity.AutoSize = true;
            lblStockQuantity.Location = new Point(138, 1008);
            lblStockQuantity.Margin = new Padding(8, 0, 8, 0);
            lblStockQuantity.Name = "lblStockQuantity";
            lblStockQuantity.Size = new Size(345, 48);
            lblStockQuantity.TabIndex = 26;
            lblStockQuantity.Text = "Mevcut Stok Miktarı:";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(333, 1200);
            lblUnit.Margin = new Padding(8, 0, 8, 0);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(203, 48);
            lblUnit.TabIndex = 27;
            lblUnit.Text = "Ölçü Birimi:";
            // 
            // lblMinimumStock
            // 
            lblMinimumStock.AutoSize = true;
            lblMinimumStock.Location = new Point(154, 1099);
            lblMinimumStock.Margin = new Padding(8, 0, 8, 0);
            lblMinimumStock.Name = "lblMinimumStock";
            lblMinimumStock.Size = new Size(380, 48);
            lblMinimumStock.TabIndex = 28;
            lblMinimumStock.Text = "Minimum Stok Miktarı:";
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Location = new Point(250, 1313);
            lblSupplierName.Margin = new Padding(8, 0, 8, 0);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(224, 48);
            lblSupplierName.TabIndex = 29;
            lblSupplierName.Text = "Toptancı Adı:";
            // 
            // btnAddNewSupplier
            // 
            btnAddNewSupplier.Location = new Point(1382, 1236);
            btnAddNewSupplier.Margin = new Padding(8, 7, 8, 7);
            btnAddNewSupplier.Name = "btnAddNewSupplier";
            btnAddNewSupplier.Size = new Size(400, 125);
            btnAddNewSupplier.TabIndex = 30;
            btnAddNewSupplier.Text = "Yeni Toptancı Ekle";
            btnAddNewSupplier.UseVisualStyleBackColor = true;
            btnAddNewSupplier.Click += btnAddNewSupplier_Click;
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Location = new Point(228, 1416);
            lblPaymentMethod.Margin = new Padding(8, 0, 8, 0);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(284, 48);
            lblPaymentMethod.TabIndex = 31;
            lblPaymentMethod.Text = "Ödeme Yöntemi:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(138, 1538);
            btnSave.Margin = new Padding(8, 7, 8, 7);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(350, 216);
            btnSave.TabIndex = 32;
            btnSave.Text = "Kaydet (F1)";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(552, 1538);
            btnCancel.Margin = new Padding(8, 7, 8, 7);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(350, 216);
            btnCancel.TabIndex = 33;
            btnCancel.Text = "Vazgeç";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSearchByProductName
            // 
            btnSearchByProductName.Location = new Point(972, 1538);
            btnSearchByProductName.Margin = new Padding(8, 7, 8, 7);
            btnSearchByProductName.Name = "btnSearchByProductName";
            btnSearchByProductName.Size = new Size(350, 216);
            btnSearchByProductName.TabIndex = 34;
            btnSearchByProductName.Text = "Ürün Adı İle Arama";
            btnSearchByProductName.UseVisualStyleBackColor = true;
            btnSearchByProductName.Click += btnSearchByProductName_Click;
            // 
            // btnInvoiceEntry
            // 
            btnInvoiceEntry.Location = new Point(2188, 1454);
            btnInvoiceEntry.Margin = new Padding(8, 7, 8, 7);
            btnInvoiceEntry.Name = "btnInvoiceEntry";
            btnInvoiceEntry.Size = new Size(350, 216);
            btnInvoiceEntry.TabIndex = 35;
            btnInvoiceEntry.Text = "Invoice Product Entry";
            btnInvoiceEntry.UseVisualStyleBackColor = true;
            btnInvoiceEntry.Click += btnInvoiceEntry_Click;
            // 
            // ProductEnterForm
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1830, 1807);
            Controls.Add(btnInvoiceEntry);
            Controls.Add(btnSearchByProductName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblPaymentMethod);
            Controls.Add(btnAddNewSupplier);
            Controls.Add(lblSupplierName);
            Controls.Add(lblMinimumStock);
            Controls.Add(lblUnit);
            Controls.Add(lblStockQuantity);
            Controls.Add(lblVATRate);
            Controls.Add(lblSecondSalesPrice);
            Controls.Add(lblSalesPrice);
            Controls.Add(label1);
            Controls.Add(lblPurchasePriceIncludingVAT);
            Controls.Add(btnAddNewProductGroup);
            Controls.Add(lblProductGroup);
            Controls.Add(lblProductCode);
            Controls.Add(lblProductName);
            Controls.Add(btnGenerateBarcodeNo);
            Controls.Add(cmbSupplierName);
            Controls.Add(cmbPaymentMethod);
            Controls.Add(txtUnit);
            Controls.Add(txtStockQuantity);
            Controls.Add(txtVATRate);
            Controls.Add(txtMinimumStock);
            Controls.Add(txtSecondSalesPrice);
            Controls.Add(txtSalesPrice);
            Controls.Add(txtPurchasePriceExcludingVAT);
            Controls.Add(txtProductCode);
            Controls.Add(txtProductName);
            Controls.Add(txtPurchasePriceIncludingVAT);
            Controls.Add(lblBarcode);
            Controls.Add(cmbProductGroup);
            Controls.Add(txtBarcode);
            Margin = new Padding(8, 7, 8, 7);
            Name = "ProductEnterForm";
            Text = "ProductEnterForm";
            Load += ProductEnterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBarcode;
        private ComboBox cmbProductGroup;
        private Label lblBarcode;
        private TextBox txtPurchasePriceIncludingVAT;
        private TextBox txtProductName;
        private TextBox txtProductCode;
        private TextBox txtPurchasePriceExcludingVAT;
        private TextBox txtSalesPrice;
        private TextBox txtVATRate;
        private TextBox txtMinimumStock;
        private TextBox txtSecondSalesPrice;
        private TextBox txtUnit;
        private TextBox txtStockQuantity;
        private ComboBox cmbPaymentMethod;
        private ComboBox cmbSupplierName;
        private Button btnGenerateBarcodeNo;
        private Label lblProductName;
        private Label lblProductCode;
        private Label lblProductGroup;
        private Button btnAddNewProductGroup;
        private Label lblPurchasePriceIncludingVAT;
        private GroupBox gbVATOptions;
        private RadioButton rbExcludingVAT;
        private RadioButton rbIncludingVAT;
        private Label label1;
        private Label lblSalesPrice;
        private Label lblSecondSalesPrice;
        private Label lblVATRate;
        private Label lblStockQuantity;
        private Label lblUnit;
        private Label lblMinimumStock;
        private Label lblSupplierName;
        private Button btnAddNewSupplier;
        private Label lblPaymentMethod;
        private Button btnSave;
        private Button btnCancel;
        private Button btnSearchByProductName;
        private Button btnInvoiceEntry;
    }
}