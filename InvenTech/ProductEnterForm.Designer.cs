﻿namespace InvenTech
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
            lblEklenecekMiktarBilgi = new Label();
            txtStockEklenecek = new TextBox();
            lblOldStock = new Label();
            lblNewStock = new Label();
            SuspendLayout();
            // 
            // txtBarcode
            // 
            txtBarcode.BackColor = Color.Yellow;
            txtBarcode.Location = new Point(221, 34);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(280, 27);
            txtBarcode.TabIndex = 0;
            txtBarcode.TextChanged += txtBarcode_TextChanged;
            txtBarcode.KeyDown += txtBarcode_KeyDown;
            // 
            // cmbProductGroup
            // 
            cmbProductGroup.FormattingEnabled = true;
            cmbProductGroup.Location = new Point(221, 160);
            cmbProductGroup.Name = "cmbProductGroup";
            cmbProductGroup.Size = new Size(280, 28);
            cmbProductGroup.TabIndex = 1;
            cmbProductGroup.SelectedIndexChanged += cmbProductGroup_SelectedIndexChanged;
            // 
            // lblBarcode
            // 
            lblBarcode.AutoSize = true;
            lblBarcode.Location = new Point(124, 41);
            lblBarcode.Name = "lblBarcode";
            lblBarcode.Size = new Size(83, 20);
            lblBarcode.TabIndex = 2;
            lblBarcode.Text = "Barkod No:";
            // 
            // txtPurchasePriceIncludingVAT
            // 
            txtPurchasePriceIncludingVAT.Location = new Point(221, 245);
            txtPurchasePriceIncludingVAT.Name = "txtPurchasePriceIncludingVAT";
            txtPurchasePriceIncludingVAT.Size = new Size(125, 27);
            txtPurchasePriceIncludingVAT.TabIndex = 3;
            txtPurchasePriceIncludingVAT.TextChanged += txtPurchasePriceIncludingVAT_TextChanged;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(221, 76);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(350, 27);
            txtProductName.TabIndex = 4;
            txtProductName.TextChanged += txtProductName_TextChanged;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(221, 118);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(280, 27);
            txtProductCode.TabIndex = 5;
            txtProductCode.TextChanged += txtProductCode_TextChanged;
            // 
            // txtPurchasePriceExcludingVAT
            // 
            txtPurchasePriceExcludingVAT.Location = new Point(221, 287);
            txtPurchasePriceExcludingVAT.Name = "txtPurchasePriceExcludingVAT";
            txtPurchasePriceExcludingVAT.Size = new Size(125, 27);
            txtPurchasePriceExcludingVAT.TabIndex = 6;
            txtPurchasePriceExcludingVAT.TextChanged += txtPurchasePriceExcludingVAT_TextChanged;
            // 
            // txtSalesPrice
            // 
            txtSalesPrice.Location = new Point(221, 329);
            txtSalesPrice.Name = "txtSalesPrice";
            txtSalesPrice.Size = new Size(125, 27);
            txtSalesPrice.TabIndex = 7;
            txtSalesPrice.TextChanged += txtSalesPrice_TextChanged;
            // 
            // txtVATRate
            // 
            txtVATRate.Location = new Point(221, 203);
            txtVATRate.Name = "txtVATRate";
            txtVATRate.Size = new Size(75, 27);
            txtVATRate.TabIndex = 10;
            txtVATRate.TextChanged += txtVATRate_TextChanged;
            // 
            // txtMinimumStock
            // 
            txtMinimumStock.BackColor = Color.IndianRed;
            txtMinimumStock.Location = new Point(221, 455);
            txtMinimumStock.Name = "txtMinimumStock";
            txtMinimumStock.Size = new Size(125, 27);
            txtMinimumStock.TabIndex = 9;
            txtMinimumStock.TextChanged += txtMinimumStock_TextChanged;
            // 
            // txtSecondSalesPrice
            // 
            txtSecondSalesPrice.Location = new Point(221, 371);
            txtSecondSalesPrice.Name = "txtSecondSalesPrice";
            txtSecondSalesPrice.Size = new Size(125, 27);
            txtSecondSalesPrice.TabIndex = 8;
            txtSecondSalesPrice.TextChanged += txtSecondSalesPrice_TextChanged;
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(221, 497);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(125, 27);
            txtUnit.TabIndex = 12;
            txtUnit.TextChanged += cmbUnit_TextChanged;
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.BackColor = Color.White;
            txtStockQuantity.Location = new Point(221, 413);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.Size = new Size(125, 27);
            txtStockQuantity.TabIndex = 11;
            txtStockQuantity.TextChanged += txtStockQuantity_TextChanged;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "Credit Card", "Bank Transfer", "To their debt" });
            cmbPaymentMethod.Location = new Point(221, 582);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(280, 28);
            cmbPaymentMethod.TabIndex = 13;
            cmbPaymentMethod.SelectedIndexChanged += cmbPaymentMethod_SelectedIndexChanged;
            // 
            // cmbSupplierName
            // 
            cmbSupplierName.FormattingEnabled = true;
            cmbSupplierName.Location = new Point(221, 539);
            cmbSupplierName.Name = "cmbSupplierName";
            cmbSupplierName.Size = new Size(280, 28);
            cmbSupplierName.TabIndex = 14;
            cmbSupplierName.SelectedIndexChanged += cmbSupplierName_SelectedIndexChanged;
            // 
            // btnGenerateBarcodeNo
            // 
            btnGenerateBarcodeNo.Location = new Point(553, 18);
            btnGenerateBarcodeNo.Name = "btnGenerateBarcodeNo";
            btnGenerateBarcodeNo.Size = new Size(160, 52);
            btnGenerateBarcodeNo.TabIndex = 15;
            btnGenerateBarcodeNo.Text = "Otomatik Barkod No Ver";
            btnGenerateBarcodeNo.UseVisualStyleBackColor = true;
            btnGenerateBarcodeNo.Click += btnGenerateBarcodeNo_Click;
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(108, 83);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(86, 20);
            lblProductName.TabIndex = 16;
            lblProductName.Text = "Ürünün Adı:";
            // 
            // lblProductCode
            // 
            lblProductCode.AutoSize = true;
            lblProductCode.Location = new Point(23, 125);
            lblProductCode.Name = "lblProductCode";
            lblProductCode.Size = new Size(157, 20);
            lblProductCode.TabIndex = 17;
            lblProductCode.Text = "Ürün Kodu - Açıklama:";
            // 
            // lblProductGroup
            // 
            lblProductGroup.AutoSize = true;
            lblProductGroup.Location = new Point(67, 168);
            lblProductGroup.Name = "lblProductGroup";
            lblProductGroup.Size = new Size(130, 20);
            lblProductGroup.TabIndex = 18;
            lblProductGroup.Text = "Ürün Grubunu Seç:";
            // 
            // btnAddNewProductGroup
            // 
            btnAddNewProductGroup.Location = new Point(553, 139);
            btnAddNewProductGroup.Name = "btnAddNewProductGroup";
            btnAddNewProductGroup.Size = new Size(160, 49);
            btnAddNewProductGroup.TabIndex = 19;
            btnAddNewProductGroup.Text = "Yeni Ürün Grubu Ekle";
            btnAddNewProductGroup.UseVisualStyleBackColor = true;
            btnAddNewProductGroup.Click += btnAddNewProductGroup_Click;
            // 
            // lblPurchasePriceIncludingVAT
            // 
            lblPurchasePriceIncludingVAT.AutoSize = true;
            lblPurchasePriceIncludingVAT.Location = new Point(67, 246);
            lblPurchasePriceIncludingVAT.Name = "lblPurchasePriceIncludingVAT";
            lblPurchasePriceIncludingVAT.Size = new Size(157, 20);
            lblPurchasePriceIncludingVAT.TabIndex = 20;
            lblPurchasePriceIncludingVAT.Text = "Alış Fiyatı (KDV Dahil):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 288);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 22;
            label1.Text = "Alış Fiyatı (KDV Hariç):";
            // 
            // lblSalesPrice
            // 
            lblSalesPrice.AutoSize = true;
            lblSalesPrice.Location = new Point(133, 332);
            lblSalesPrice.Name = "lblSalesPrice";
            lblSalesPrice.Size = new Size(82, 20);
            lblSalesPrice.TabIndex = 23;
            lblSalesPrice.Text = "Satış Fiyatı:";
            // 
            // lblSecondSalesPrice
            // 
            lblSecondSalesPrice.AutoSize = true;
            lblSecondSalesPrice.Location = new Point(80, 374);
            lblSecondSalesPrice.Name = "lblSecondSalesPrice";
            lblSecondSalesPrice.Size = new Size(120, 20);
            lblSecondSalesPrice.TabIndex = 24;
            lblSecondSalesPrice.Text = "İkinci Satış Fiyatı:";
            // 
            // lblVATRate
            // 
            lblVATRate.AutoSize = true;
            lblVATRate.Location = new Point(116, 204);
            lblVATRate.Name = "lblVATRate";
            lblVATRate.Size = new Size(102, 20);
            lblVATRate.TabIndex = 25;
            lblVATRate.Text = "Vergi Oranı %:";
            // 
            // lblStockQuantity
            // 
            lblStockQuantity.AutoSize = true;
            lblStockQuantity.Location = new Point(72, 416);
            lblStockQuantity.Name = "lblStockQuantity";
            lblStockQuantity.Size = new Size(143, 20);
            lblStockQuantity.TabIndex = 26;
            lblStockQuantity.Text = "Mevcut Stok Miktarı:";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(133, 500);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(85, 20);
            lblUnit.TabIndex = 27;
            lblUnit.Text = "Ölçü Birimi:";
            // 
            // lblMinimumStock
            // 
            lblMinimumStock.AutoSize = true;
            lblMinimumStock.Location = new Point(62, 458);
            lblMinimumStock.Name = "lblMinimumStock";
            lblMinimumStock.Size = new Size(158, 20);
            lblMinimumStock.TabIndex = 28;
            lblMinimumStock.Text = "Minimum Stok Miktarı:";
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Location = new Point(100, 547);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(96, 20);
            lblSupplierName.TabIndex = 29;
            lblSupplierName.Text = "Toptancı Adı:";
            // 
            // btnAddNewSupplier
            // 
            btnAddNewSupplier.Location = new Point(553, 515);
            btnAddNewSupplier.Name = "btnAddNewSupplier";
            btnAddNewSupplier.Size = new Size(160, 52);
            btnAddNewSupplier.TabIndex = 30;
            btnAddNewSupplier.Text = "Yeni Toptancı Ekle";
            btnAddNewSupplier.UseVisualStyleBackColor = true;
            btnAddNewSupplier.Click += btnAddNewSupplier_Click;
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Location = new Point(91, 590);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(119, 20);
            lblPaymentMethod.TabIndex = 31;
            lblPaymentMethod.Text = "Ödeme Yöntemi:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(55, 641);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 90);
            btnSave.TabIndex = 32;
            btnSave.Text = "Kaydet (F1)";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(221, 641);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 90);
            btnCancel.TabIndex = 33;
            btnCancel.Text = "Vazgeç";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSearchByProductName
            // 
            btnSearchByProductName.Location = new Point(389, 641);
            btnSearchByProductName.Name = "btnSearchByProductName";
            btnSearchByProductName.Size = new Size(140, 90);
            btnSearchByProductName.TabIndex = 34;
            btnSearchByProductName.Text = "Ürün Adı İle Arama";
            btnSearchByProductName.UseVisualStyleBackColor = true;
            btnSearchByProductName.Click += btnSearchByProductName_Click;
            // 
            // lblEklenecekMiktarBilgi
            // 
            lblEklenecekMiktarBilgi.AutoSize = true;
            lblEklenecekMiktarBilgi.Location = new Point(91, 416);
            lblEklenecekMiktarBilgi.Name = "lblEklenecekMiktarBilgi";
            lblEklenecekMiktarBilgi.Size = new Size(123, 20);
            lblEklenecekMiktarBilgi.TabIndex = 35;
            lblEklenecekMiktarBilgi.Text = "Eklenecek Miktar:";
            lblEklenecekMiktarBilgi.Visible = false;
            lblEklenecekMiktarBilgi.Click += lblEklenecekMiktarBilgi_Click;
            // 
            // txtStockEklenecek
            // 
            txtStockEklenecek.Location = new Point(221, 413);
            txtStockEklenecek.Name = "txtStockEklenecek";
            txtStockEklenecek.Size = new Size(125, 27);
            txtStockEklenecek.TabIndex = 36;
            txtStockEklenecek.Visible = false;
            txtStockEklenecek.TextChanged += txtStockEklenecek_TextChanged;
            // 
            // lblOldStock
            // 
            lblOldStock.AutoSize = true;
            lblOldStock.BackColor = SystemColors.Control;
            lblOldStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOldStock.ForeColor = Color.Black;
            lblOldStock.Location = new Point(415, 420);
            lblOldStock.Name = "lblOldStock";
            lblOldStock.Size = new Size(0, 20);
            lblOldStock.TabIndex = 37;
            lblOldStock.Visible = false;
            // 
            // lblNewStock
            // 
            lblNewStock.AutoSize = true;
            lblNewStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblNewStock.ForeColor = Color.Lime;
            lblNewStock.Location = new Point(553, 420);
            lblNewStock.Name = "lblNewStock";
            lblNewStock.Size = new Size(0, 20);
            lblNewStock.TabIndex = 38;
            // 
            // ProductEnterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 776);
            Controls.Add(lblNewStock);
            Controls.Add(lblOldStock);
            Controls.Add(txtStockEklenecek);
            Controls.Add(lblEklenecekMiktarBilgi);
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
        private Label lblEklenecekMiktarBilgi;
        private TextBox txtStockEklenecek;
        private Label lblOldStock;
        private Label lblNewStock;
    }
}