namespace BurgerAppPresentation.ProductScreenAndContents
{
    partial class BurgerAppProducts
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
            components = new System.ComponentModel.Container();
            pnl_Title = new Panel();
            lbl_ProductsTitle = new Label();
            label1 = new Label();
            pnl_DataGridView = new Panel();
            dgv_Products = new DataGridView();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            btn_EditProduct = new Button();
            btn_RemoveProduct = new Button();
            btn_AddProduct = new Button();
            btn_Back = new Button();
            pnl_Title.SuspendLayout();
            pnl_DataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Products).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pnl_Title
            // 
            pnl_Title.BackColor = Color.FromArgb(255, 60, 47);
            pnl_Title.Controls.Add(lbl_ProductsTitle);
            pnl_Title.Controls.Add(label1);
            pnl_Title.Dock = DockStyle.Top;
            pnl_Title.Location = new Point(0, 0);
            pnl_Title.Name = "pnl_Title";
            pnl_Title.Size = new Size(924, 27);
            pnl_Title.TabIndex = 30;
            // 
            // lbl_ProductsTitle
            // 
            lbl_ProductsTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_ProductsTitle.AutoSize = true;
            lbl_ProductsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_ProductsTitle.ForeColor = Color.FromArgb(14, 14, 14);
            lbl_ProductsTitle.Location = new Point(593, 1);
            lbl_ProductsTitle.Name = "lbl_ProductsTitle";
            lbl_ProductsTitle.Size = new Size(335, 25);
            lbl_ProductsTitle.TabIndex = 14;
            lbl_ProductsTitle.Text = "WISSEN BURGER COMS - PRODUCTS";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(14, 14, 14);
            label1.Location = new Point(1854, 1);
            label1.Name = "label1";
            label1.Size = new Size(346, 25);
            label1.TabIndex = 12;
            label1.Text = "WISSEN BURGER COMS - CUSTOMERS";
            // 
            // pnl_DataGridView
            // 
            pnl_DataGridView.Controls.Add(dgv_Products);
            pnl_DataGridView.Dock = DockStyle.Left;
            pnl_DataGridView.Location = new Point(0, 27);
            pnl_DataGridView.Name = "pnl_DataGridView";
            pnl_DataGridView.Size = new Size(443, 563);
            pnl_DataGridView.TabIndex = 31;
            // 
            // dgv_Products
            // 
            dgv_Products.AllowUserToAddRows = false;
            dgv_Products.AllowUserToDeleteRows = false;
            dgv_Products.AutoGenerateColumns = false;
            dgv_Products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Products.Columns.AddRange(new DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, unitPriceDataGridViewTextBoxColumn, stockDataGridViewTextBoxColumn });
            dgv_Products.DataSource = productBindingSource;
            dgv_Products.Dock = DockStyle.Fill;
            dgv_Products.Location = new Point(0, 0);
            dgv_Products.Name = "dgv_Products";
            dgv_Products.ReadOnly = true;
            dgv_Products.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Products.Size = new Size(443, 563);
            dgv_Products.TabIndex = 0;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(BurgerAppDomain.Product);
            // 
            // btn_EditProduct
            // 
            btn_EditProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_EditProduct.BackColor = Color.FromArgb(255, 60, 47);
            btn_EditProduct.BackgroundImageLayout = ImageLayout.None;
            btn_EditProduct.Cursor = Cursors.Hand;
            btn_EditProduct.FlatAppearance.BorderSize = 0;
            btn_EditProduct.FlatStyle = FlatStyle.Flat;
            btn_EditProduct.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EditProduct.ForeColor = Color.FromArgb(14, 14, 14);
            btn_EditProduct.Image = Properties.Resources.Edit;
            btn_EditProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btn_EditProduct.Location = new Point(455, 195);
            btn_EditProduct.Name = "btn_EditProduct";
            btn_EditProduct.Size = new Size(457, 115);
            btn_EditProduct.TabIndex = 34;
            btn_EditProduct.Text = "Edit Selected \r\nProduct";
            btn_EditProduct.TextAlign = ContentAlignment.MiddleRight;
            btn_EditProduct.UseVisualStyleBackColor = false;
            btn_EditProduct.Click += btn_EditProduct_Click;
            // 
            // btn_RemoveProduct
            // 
            btn_RemoveProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_RemoveProduct.BackColor = Color.FromArgb(255, 60, 47);
            btn_RemoveProduct.BackgroundImageLayout = ImageLayout.None;
            btn_RemoveProduct.Cursor = Cursors.Hand;
            btn_RemoveProduct.FlatAppearance.BorderSize = 0;
            btn_RemoveProduct.FlatStyle = FlatStyle.Flat;
            btn_RemoveProduct.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_RemoveProduct.ForeColor = Color.FromArgb(14, 14, 14);
            btn_RemoveProduct.Image = Properties.Resources.Remove;
            btn_RemoveProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btn_RemoveProduct.Location = new Point(455, 335);
            btn_RemoveProduct.Name = "btn_RemoveProduct";
            btn_RemoveProduct.Size = new Size(457, 115);
            btn_RemoveProduct.TabIndex = 33;
            btn_RemoveProduct.Text = "Remove Product";
            btn_RemoveProduct.TextAlign = ContentAlignment.MiddleRight;
            btn_RemoveProduct.UseVisualStyleBackColor = false;
            btn_RemoveProduct.Click += btn_RemoveProduct_Click;
            // 
            // btn_AddProduct
            // 
            btn_AddProduct.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_AddProduct.BackColor = Color.FromArgb(255, 60, 47);
            btn_AddProduct.BackgroundImageLayout = ImageLayout.None;
            btn_AddProduct.Cursor = Cursors.Hand;
            btn_AddProduct.FlatAppearance.BorderSize = 0;
            btn_AddProduct.FlatStyle = FlatStyle.Flat;
            btn_AddProduct.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddProduct.ForeColor = Color.FromArgb(14, 14, 14);
            btn_AddProduct.Image = Properties.Resources.Plus;
            btn_AddProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btn_AddProduct.Location = new Point(455, 55);
            btn_AddProduct.Name = "btn_AddProduct";
            btn_AddProduct.Size = new Size(457, 115);
            btn_AddProduct.TabIndex = 32;
            btn_AddProduct.Text = "Add New Product";
            btn_AddProduct.TextAlign = ContentAlignment.MiddleRight;
            btn_AddProduct.UseVisualStyleBackColor = false;
            btn_AddProduct.Click += btn_AddProduct_Click;
            // 
            // btn_Back
            // 
            btn_Back.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Back.BackColor = Color.FromArgb(255, 60, 47);
            btn_Back.BackgroundImage = Properties.Resources.Back;
            btn_Back.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Back.Cursor = Cursors.Hand;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.ForeColor = Color.Coral;
            btn_Back.Location = new Point(848, 514);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(64, 64);
            btn_Back.TabIndex = 35;
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // BurgerAppProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(924, 590);
            Controls.Add(btn_Back);
            Controls.Add(btn_EditProduct);
            Controls.Add(btn_RemoveProduct);
            Controls.Add(btn_AddProduct);
            Controls.Add(pnl_DataGridView);
            Controls.Add(pnl_Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BurgerAppProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BurgerAppProducts";
            Load += BurgerAppProducts_Load;
            pnl_Title.ResumeLayout(false);
            pnl_Title.PerformLayout();
            pnl_DataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Products).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Title;
        private Label lbl_ProductsTitle;
        private Label label1;
        private Panel pnl_DataGridView;
        private DataGridView dgv_Products;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private BindingSource productBindingSource;
        private Button btn_EditProduct;
        private Button btn_RemoveProduct;
        private Button btn_AddProduct;
        private Button btn_Back;
    }
}