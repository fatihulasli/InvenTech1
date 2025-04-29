namespace InvenTech
{
    partial class ProductSearchForm
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
            lblSearchTitle = new Label();
            txtSearchProductName = new TextBox();
            dgvProducts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // lblSearchTitle
            // 
            lblSearchTitle.Dock = DockStyle.Top;
            lblSearchTitle.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSearchTitle.Location = new Point(0, 0);
            lblSearchTitle.Name = "lblSearchTitle";
            lblSearchTitle.Size = new Size(800, 30);
            lblSearchTitle.TabIndex = 0;
            lblSearchTitle.Text = "ÜRÜNÜN ADI";
            lblSearchTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearchProductName
            // 
            txtSearchProductName.BackColor = Color.Yellow;
            txtSearchProductName.Dock = DockStyle.Top;
            txtSearchProductName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtSearchProductName.Location = new Point(0, 30);
            txtSearchProductName.Name = "txtSearchProductName";
            txtSearchProductName.PlaceholderText = "\"Ürün adı veya barkod giriniz...\"";
            txtSearchProductName.Size = new Size(800, 30);
            txtSearchProductName.TabIndex = 1;
            txtSearchProductName.TextChanged += txtSearchProductName_TextChanged;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(0, 60);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(800, 390);
            dgvProducts.TabIndex = 2;
            dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
            // 
            // ProductSearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProducts);
            Controls.Add(txtSearchProductName);
            Controls.Add(lblSearchTitle);
            Name = "ProductSearchForm";
            Text = "ProductSearchForm";
            Load += ProductSearchForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearchTitle;
        private TextBox txtSearchProductName;
        private DataGridView dgvProducts;
    }
}