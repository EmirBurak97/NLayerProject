namespace Example.WebFormsUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgwProducts = new DataGridView();
            gbxCategory = new GroupBox();
            cbxCategory = new ComboBox();
            lblCategory = new Label();
            gbxSearch = new GroupBox();
            tbxSearch = new TextBox();
            lblSearch = new Label();
            gbxNewProduct = new GroupBox();
            btnAdd = new Button();
            cbxAddCategory = new ComboBox();
            tbxUnitsInStock = new TextBox();
            tbxUnitPrice = new TextBox();
            tbxProductName = new TextBox();
            lblUnitsInStock = new Label();
            lblUnitPrice = new Label();
            lblAddCategory = new Label();
            lblProductName = new Label();
            gbxUpdate = new GroupBox();
            btnUpdate = new Button();
            cbxUpdateCategories = new ComboBox();
            tbxUpdateUnitsInStock = new TextBox();
            tbxUpdateUnitPrice = new TextBox();
            tbxUpdateProductName = new TextBox();
            lblUpdateUnitsInPrice = new Label();
            lblUpdateUnitPrice = new Label();
            lblUpdateCategory = new Label();
            lblUpdateProductName = new Label();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).BeginInit();
            gbxCategory.SuspendLayout();
            gbxSearch.SuspendLayout();
            gbxNewProduct.SuspendLayout();
            gbxUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // dgwProducts
            // 
            dgwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProducts.Location = new Point(12, 244);
            dgwProducts.Name = "dgwProducts";
            dgwProducts.RowTemplate.Height = 25;
            dgwProducts.Size = new Size(776, 254);
            dgwProducts.TabIndex = 0;
            dgwProducts.CellClick += dgwProducts_CellClick;
            // 
            // gbxCategory
            // 
            gbxCategory.Controls.Add(cbxCategory);
            gbxCategory.Controls.Add(lblCategory);
            gbxCategory.Location = new Point(12, 12);
            gbxCategory.Name = "gbxCategory";
            gbxCategory.Size = new Size(776, 110);
            gbxCategory.TabIndex = 1;
            gbxCategory.TabStop = false;
            gbxCategory.Text = "Kategoriye göre ara";
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(76, 43);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(221, 23);
            cbxCategory.TabIndex = 1;
            cbxCategory.SelectedIndexChanged += cbxCategory_SelectedIndexChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(15, 46);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(51, 15);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Kategori";
            // 
            // gbxSearch
            // 
            gbxSearch.Controls.Add(tbxSearch);
            gbxSearch.Controls.Add(lblSearch);
            gbxSearch.Location = new Point(12, 128);
            gbxSearch.Name = "gbxSearch";
            gbxSearch.Size = new Size(776, 110);
            gbxSearch.TabIndex = 2;
            gbxSearch.TabStop = false;
            gbxSearch.Text = "Ürün adına göre ara";
            // 
            // tbxSearch
            // 
            tbxSearch.Location = new Point(76, 43);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(221, 23);
            tbxSearch.TabIndex = 1;
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(15, 46);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(52, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Ürün adı";
            // 
            // gbxNewProduct
            // 
            gbxNewProduct.Controls.Add(btnAdd);
            gbxNewProduct.Controls.Add(cbxAddCategory);
            gbxNewProduct.Controls.Add(tbxUnitsInStock);
            gbxNewProduct.Controls.Add(tbxUnitPrice);
            gbxNewProduct.Controls.Add(tbxProductName);
            gbxNewProduct.Controls.Add(lblUnitsInStock);
            gbxNewProduct.Controls.Add(lblUnitPrice);
            gbxNewProduct.Controls.Add(lblAddCategory);
            gbxNewProduct.Controls.Add(lblProductName);
            gbxNewProduct.Location = new Point(12, 504);
            gbxNewProduct.Name = "gbxNewProduct";
            gbxNewProduct.Size = new Size(565, 121);
            gbxNewProduct.TabIndex = 3;
            gbxNewProduct.TabStop = false;
            gbxNewProduct.Text = "Yeni ürün ekle";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(451, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(108, 76);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbxAddCategory
            // 
            cbxAddCategory.FormattingEnabled = true;
            cbxAddCategory.Location = new Point(90, 79);
            cbxAddCategory.Name = "cbxAddCategory";
            cbxAddCategory.Size = new Size(132, 23);
            cbxAddCategory.TabIndex = 7;
            // 
            // tbxUnitsInStock
            // 
            tbxUnitsInStock.Location = new Point(313, 79);
            tbxUnitsInStock.Name = "tbxUnitsInStock";
            tbxUnitsInStock.Size = new Size(132, 23);
            tbxUnitsInStock.TabIndex = 6;
            // 
            // tbxUnitPrice
            // 
            tbxUnitPrice.Location = new Point(313, 27);
            tbxUnitPrice.Name = "tbxUnitPrice";
            tbxUnitPrice.Size = new Size(132, 23);
            tbxUnitPrice.TabIndex = 5;
            // 
            // tbxProductName
            // 
            tbxProductName.Location = new Point(90, 27);
            tbxProductName.Name = "tbxProductName";
            tbxProductName.Size = new Size(132, 23);
            tbxProductName.TabIndex = 4;
            // 
            // lblUnitsInStock
            // 
            lblUnitsInStock.AutoSize = true;
            lblUnitsInStock.Location = new Point(243, 82);
            lblUnitsInStock.Name = "lblUnitsInStock";
            lblUnitsInStock.Size = new Size(64, 15);
            lblUnitsInStock.TabIndex = 3;
            lblUnitsInStock.Text = "Stok Adedi";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(243, 30);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(32, 15);
            lblUnitPrice.TabIndex = 2;
            lblUnitPrice.Text = "Fiyat";
            // 
            // lblAddCategory
            // 
            lblAddCategory.AutoSize = true;
            lblAddCategory.Location = new Point(15, 82);
            lblAddCategory.Name = "lblAddCategory";
            lblAddCategory.Size = new Size(51, 15);
            lblAddCategory.TabIndex = 1;
            lblAddCategory.Text = "Kategori";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(15, 30);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(54, 15);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Ürün Adı";
            // 
            // gbxUpdate
            // 
            gbxUpdate.Controls.Add(btnUpdate);
            gbxUpdate.Controls.Add(cbxUpdateCategories);
            gbxUpdate.Controls.Add(tbxUpdateUnitsInStock);
            gbxUpdate.Controls.Add(tbxUpdateUnitPrice);
            gbxUpdate.Controls.Add(tbxUpdateProductName);
            gbxUpdate.Controls.Add(lblUpdateUnitsInPrice);
            gbxUpdate.Controls.Add(lblUpdateUnitPrice);
            gbxUpdate.Controls.Add(lblUpdateCategory);
            gbxUpdate.Controls.Add(lblUpdateProductName);
            gbxUpdate.Location = new Point(12, 631);
            gbxUpdate.Name = "gbxUpdate";
            gbxUpdate.Size = new Size(565, 121);
            gbxUpdate.TabIndex = 4;
            gbxUpdate.TabStop = false;
            gbxUpdate.Text = "Ürün güncelle";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(451, 26);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(108, 76);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cbxUpdateCategories
            // 
            cbxUpdateCategories.FormattingEnabled = true;
            cbxUpdateCategories.Location = new Point(90, 79);
            cbxUpdateCategories.Name = "cbxUpdateCategories";
            cbxUpdateCategories.Size = new Size(132, 23);
            cbxUpdateCategories.TabIndex = 7;
            // 
            // tbxUpdateUnitsInStock
            // 
            tbxUpdateUnitsInStock.Location = new Point(313, 79);
            tbxUpdateUnitsInStock.Name = "tbxUpdateUnitsInStock";
            tbxUpdateUnitsInStock.Size = new Size(132, 23);
            tbxUpdateUnitsInStock.TabIndex = 6;
            // 
            // tbxUpdateUnitPrice
            // 
            tbxUpdateUnitPrice.Location = new Point(313, 27);
            tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
            tbxUpdateUnitPrice.Size = new Size(132, 23);
            tbxUpdateUnitPrice.TabIndex = 5;
            // 
            // tbxUpdateProductName
            // 
            tbxUpdateProductName.Location = new Point(90, 27);
            tbxUpdateProductName.Name = "tbxUpdateProductName";
            tbxUpdateProductName.Size = new Size(132, 23);
            tbxUpdateProductName.TabIndex = 4;
            // 
            // lblUpdateUnitsInPrice
            // 
            lblUpdateUnitsInPrice.AutoSize = true;
            lblUpdateUnitsInPrice.Location = new Point(243, 82);
            lblUpdateUnitsInPrice.Name = "lblUpdateUnitsInPrice";
            lblUpdateUnitsInPrice.Size = new Size(64, 15);
            lblUpdateUnitsInPrice.TabIndex = 3;
            lblUpdateUnitsInPrice.Text = "Stok Adedi";
            // 
            // lblUpdateUnitPrice
            // 
            lblUpdateUnitPrice.AutoSize = true;
            lblUpdateUnitPrice.Location = new Point(243, 30);
            lblUpdateUnitPrice.Name = "lblUpdateUnitPrice";
            lblUpdateUnitPrice.Size = new Size(32, 15);
            lblUpdateUnitPrice.TabIndex = 2;
            lblUpdateUnitPrice.Text = "Fiyat";
            // 
            // lblUpdateCategory
            // 
            lblUpdateCategory.AutoSize = true;
            lblUpdateCategory.Location = new Point(15, 82);
            lblUpdateCategory.Name = "lblUpdateCategory";
            lblUpdateCategory.Size = new Size(51, 15);
            lblUpdateCategory.TabIndex = 1;
            lblUpdateCategory.Text = "Kategori";
            // 
            // lblUpdateProductName
            // 
            lblUpdateProductName.AutoSize = true;
            lblUpdateProductName.Location = new Point(15, 30);
            lblUpdateProductName.Name = "lblUpdateProductName";
            lblUpdateProductName.Size = new Size(54, 15);
            lblUpdateProductName.TabIndex = 0;
            lblUpdateProductName.Text = "Ürün Adı";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(583, 513);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(205, 239);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 776);
            Controls.Add(btnDelete);
            Controls.Add(gbxUpdate);
            Controls.Add(gbxNewProduct);
            Controls.Add(gbxSearch);
            Controls.Add(gbxCategory);
            Controls.Add(dgwProducts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwProducts).EndInit();
            gbxCategory.ResumeLayout(false);
            gbxCategory.PerformLayout();
            gbxSearch.ResumeLayout(false);
            gbxSearch.PerformLayout();
            gbxNewProduct.ResumeLayout(false);
            gbxNewProduct.PerformLayout();
            gbxUpdate.ResumeLayout(false);
            gbxUpdate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwProducts;
        private GroupBox gbxCategory;
        private ComboBox cbxCategory;
        private Label lblCategory;
        private GroupBox gbxSearch;
        private TextBox tbxSearch;
        private Label lblSearch;
        private GroupBox gbxNewProduct;
        private Button btnAdd;
        private ComboBox cbxAddCategory;
        private TextBox tbxUnitsInStock;
        private TextBox tbxUnitPrice;
        private TextBox tbxProductName;
        private Label lblUnitsInStock;
        private Label lblUnitPrice;
        private Label lblAddCategory;
        private Label lblProductName;
        private GroupBox gbxUpdate;
        private Button btnUpdate;
        private ComboBox cbxUpdateCategories;
        private TextBox tbxUpdateUnitsInStock;
        private TextBox tbxUpdateUnitPrice;
        private TextBox tbxUpdateProductName;
        private Label lblUpdateUnitsInPrice;
        private Label lblUpdateUnitPrice;
        private Label lblUpdateCategory;
        private Label lblUpdateProductName;
        private Button btnDelete;
    }
}