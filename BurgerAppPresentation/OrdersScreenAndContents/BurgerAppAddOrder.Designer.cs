﻿namespace BurgerAppPresentation
{
    partial class BurgerAppAddOrder
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
            lbl_AddOrderTitle = new Label();
            lbl_Title = new Label();
            btn_Back = new Button();
            lbox_OrderList = new ListBox();
            btn_AddBasket = new Button();
            btn_RemoveBasket = new Button();
            btn_ConfirmOrder = new Button();
            pnl_TotalPrice = new Panel();
            pbox_ProductImage = new PictureBox();
            cmbox_Products = new ComboBox();
            productBindingSource = new BindingSource(components);
            pnl_Sizes = new Panel();
            chbox_Mustard = new CheckBox();
            rb_Large = new RadioButton();
            rb_Medium = new RadioButton();
            rb_Small = new RadioButton();
            chbox_Mayonnaise = new CheckBox();
            chbox_Ketchup = new CheckBox();
            panel1 = new Panel();
            lbl_OrderId = new Label();
            lbl_OrderIdTitle = new Label();
            imgList_Products = new ImageList(components);
            pnl_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbox_ProductImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            pnl_Sizes.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Title
            // 
            pnl_Title.BackColor = Color.FromArgb(255, 60, 47);
            pnl_Title.Controls.Add(lbl_AddOrderTitle);
            pnl_Title.Controls.Add(lbl_Title);
            pnl_Title.Dock = DockStyle.Top;
            pnl_Title.Location = new Point(0, 0);
            pnl_Title.Name = "pnl_Title";
            pnl_Title.Size = new Size(1023, 27);
            pnl_Title.TabIndex = 4;
            // 
            // lbl_AddOrderTitle
            // 
            lbl_AddOrderTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_AddOrderTitle.AutoSize = true;
            lbl_AddOrderTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_AddOrderTitle.ForeColor = Color.FromArgb(14, 14, 14);
            lbl_AddOrderTitle.Location = new Point(900, 1);
            lbl_AddOrderTitle.Name = "lbl_AddOrderTitle";
            lbl_AddOrderTitle.Size = new Size(120, 25);
            lbl_AddOrderTitle.TabIndex = 13;
            lbl_AddOrderTitle.Text = "ADD ORDER";
            // 
            // lbl_Title
            // 
            lbl_Title.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.FromArgb(14, 14, 14);
            lbl_Title.Location = new Point(1766, 1);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(346, 25);
            lbl_Title.TabIndex = 12;
            lbl_Title.Text = "WISSEN BURGER COMS - CUSTOMERS";
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
            btn_Back.Location = new Point(947, 552);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(64, 64);
            btn_Back.TabIndex = 10;
            btn_Back.UseVisualStyleBackColor = false;
            // 
            // lbox_OrderList
            // 
            lbox_OrderList.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbox_OrderList.FormattingEnabled = true;
            lbox_OrderList.ItemHeight = 15;
            lbox_OrderList.Location = new Point(484, 41);
            lbox_OrderList.Name = "lbox_OrderList";
            lbox_OrderList.Size = new Size(527, 199);
            lbox_OrderList.TabIndex = 11;
            // 
            // btn_AddBasket
            // 
            btn_AddBasket.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_AddBasket.BackColor = Color.FromArgb(255, 60, 47);
            btn_AddBasket.BackgroundImageLayout = ImageLayout.Stretch;
            btn_AddBasket.Cursor = Cursors.Hand;
            btn_AddBasket.FlatAppearance.BorderSize = 0;
            btn_AddBasket.FlatStyle = FlatStyle.Flat;
            btn_AddBasket.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            btn_AddBasket.ForeColor = Color.FromArgb(14, 14, 14);
            btn_AddBasket.Image = Properties.Resources.AddBasket;
            btn_AddBasket.ImageAlign = ContentAlignment.MiddleLeft;
            btn_AddBasket.Location = new Point(484, 252);
            btn_AddBasket.Name = "btn_AddBasket";
            btn_AddBasket.Size = new Size(352, 142);
            btn_AddBasket.TabIndex = 12;
            btn_AddBasket.Text = "Add to\r\nBasket";
            btn_AddBasket.TextAlign = ContentAlignment.MiddleRight;
            btn_AddBasket.UseVisualStyleBackColor = false;
            // 
            // btn_RemoveBasket
            // 
            btn_RemoveBasket.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_RemoveBasket.BackColor = Color.FromArgb(255, 60, 47);
            btn_RemoveBasket.BackgroundImageLayout = ImageLayout.Stretch;
            btn_RemoveBasket.Cursor = Cursors.Hand;
            btn_RemoveBasket.FlatAppearance.BorderSize = 0;
            btn_RemoveBasket.FlatStyle = FlatStyle.Flat;
            btn_RemoveBasket.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            btn_RemoveBasket.ForeColor = Color.FromArgb(14, 14, 14);
            btn_RemoveBasket.Image = Properties.Resources.RemoveBasket;
            btn_RemoveBasket.ImageAlign = ContentAlignment.MiddleLeft;
            btn_RemoveBasket.Location = new Point(484, 400);
            btn_RemoveBasket.Name = "btn_RemoveBasket";
            btn_RemoveBasket.Size = new Size(352, 146);
            btn_RemoveBasket.TabIndex = 13;
            btn_RemoveBasket.Text = "Remove From Basket";
            btn_RemoveBasket.TextAlign = ContentAlignment.MiddleRight;
            btn_RemoveBasket.UseVisualStyleBackColor = false;
            // 
            // btn_ConfirmOrder
            // 
            btn_ConfirmOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_ConfirmOrder.BackColor = Color.FromArgb(255, 60, 47);
            btn_ConfirmOrder.BackgroundImageLayout = ImageLayout.Stretch;
            btn_ConfirmOrder.Cursor = Cursors.Hand;
            btn_ConfirmOrder.FlatAppearance.BorderSize = 0;
            btn_ConfirmOrder.FlatStyle = FlatStyle.Flat;
            btn_ConfirmOrder.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold);
            btn_ConfirmOrder.ForeColor = Color.FromArgb(14, 14, 14);
            btn_ConfirmOrder.Image = Properties.Resources.ConfirmOrder;
            btn_ConfirmOrder.ImageAlign = ContentAlignment.TopCenter;
            btn_ConfirmOrder.Location = new Point(842, 252);
            btn_ConfirmOrder.Name = "btn_ConfirmOrder";
            btn_ConfirmOrder.Size = new Size(169, 294);
            btn_ConfirmOrder.TabIndex = 14;
            btn_ConfirmOrder.Text = "Confirm Order";
            btn_ConfirmOrder.TextAlign = ContentAlignment.BottomCenter;
            btn_ConfirmOrder.UseVisualStyleBackColor = false;
            // 
            // pnl_TotalPrice
            // 
            pnl_TotalPrice.BackColor = Color.FromArgb(255, 255, 192);
            pnl_TotalPrice.Location = new Point(484, 552);
            pnl_TotalPrice.Name = "pnl_TotalPrice";
            pnl_TotalPrice.Size = new Size(457, 64);
            pnl_TotalPrice.TabIndex = 15;
            // 
            // pbox_ProductImage
            // 
            pbox_ProductImage.BackColor = Color.FromArgb(14, 14, 14);
            pbox_ProductImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbox_ProductImage.Location = new Point(12, 111);
            pbox_ProductImage.Name = "pbox_ProductImage";
            pbox_ProductImage.Size = new Size(209, 200);
            pbox_ProductImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbox_ProductImage.TabIndex = 16;
            pbox_ProductImage.TabStop = false;
            // 
            // cmbox_Products
            // 
            cmbox_Products.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbox_Products.FormattingEnabled = true;
            cmbox_Products.Location = new Point(12, 317);
            cmbox_Products.Name = "cmbox_Products";
            cmbox_Products.Size = new Size(210, 40);
            cmbox_Products.TabIndex = 17;
            cmbox_Products.SelectedIndexChanged += cmbox_Products_SelectedIndexChanged;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(BurgerAppDomain.Product);
            // 
            // pnl_Sizes
            // 
            pnl_Sizes.BackColor = Color.FromArgb(14, 14, 14);
            pnl_Sizes.Controls.Add(chbox_Mustard);
            pnl_Sizes.Controls.Add(rb_Large);
            pnl_Sizes.Controls.Add(rb_Medium);
            pnl_Sizes.Controls.Add(rb_Small);
            pnl_Sizes.Controls.Add(chbox_Mayonnaise);
            pnl_Sizes.Controls.Add(chbox_Ketchup);
            pnl_Sizes.Location = new Point(-4, 363);
            pnl_Sizes.Name = "pnl_Sizes";
            pnl_Sizes.Size = new Size(245, 253);
            pnl_Sizes.TabIndex = 18;
            // 
            // chbox_Mustard
            // 
            chbox_Mustard.Appearance = Appearance.Button;
            chbox_Mustard.AutoSize = true;
            chbox_Mustard.FlatAppearance.BorderColor = Color.FromArgb(255, 60, 47);
            chbox_Mustard.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 60, 47);
            chbox_Mustard.FlatStyle = FlatStyle.Flat;
            chbox_Mustard.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            chbox_Mustard.ForeColor = Color.White;
            chbox_Mustard.Location = new Point(16, 198);
            chbox_Mustard.MinimumSize = new Size(210, 55);
            chbox_Mustard.Name = "chbox_Mustard";
            chbox_Mustard.Size = new Size(210, 55);
            chbox_Mustard.TabIndex = 22;
            chbox_Mustard.Text = "Mustard";
            chbox_Mustard.TextAlign = ContentAlignment.MiddleCenter;
            chbox_Mustard.UseVisualStyleBackColor = true;
            // 
            // rb_Large
            // 
            rb_Large.Appearance = Appearance.Button;
            rb_Large.AutoSize = true;
            rb_Large.Cursor = Cursors.Hand;
            rb_Large.FlatAppearance.BorderColor = Color.FromArgb(255, 60, 47);
            rb_Large.FlatAppearance.BorderSize = 2;
            rb_Large.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 60, 47);
            rb_Large.FlatStyle = FlatStyle.Flat;
            rb_Large.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            rb_Large.ForeColor = Color.White;
            rb_Large.Location = new Point(175, 8);
            rb_Large.Name = "rb_Large";
            rb_Large.Size = new Size(50, 59);
            rb_Large.TabIndex = 2;
            rb_Large.Text = "L";
            rb_Large.TextAlign = ContentAlignment.MiddleCenter;
            rb_Large.UseVisualStyleBackColor = true;
            // 
            // rb_Medium
            // 
            rb_Medium.Appearance = Appearance.Button;
            rb_Medium.AutoSize = true;
            rb_Medium.Cursor = Cursors.Hand;
            rb_Medium.FlatAppearance.BorderColor = Color.FromArgb(255, 60, 47);
            rb_Medium.FlatAppearance.BorderSize = 2;
            rb_Medium.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 60, 47);
            rb_Medium.FlatStyle = FlatStyle.Flat;
            rb_Medium.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            rb_Medium.ForeColor = Color.White;
            rb_Medium.Location = new Point(89, 8);
            rb_Medium.Name = "rb_Medium";
            rb_Medium.Size = new Size(65, 59);
            rb_Medium.TabIndex = 1;
            rb_Medium.Text = "M";
            rb_Medium.TextAlign = ContentAlignment.MiddleCenter;
            rb_Medium.UseVisualStyleBackColor = true;
            // 
            // rb_Small
            // 
            rb_Small.Appearance = Appearance.Button;
            rb_Small.AutoSize = true;
            rb_Small.Cursor = Cursors.Hand;
            rb_Small.FlatAppearance.BorderColor = Color.FromArgb(255, 60, 47);
            rb_Small.FlatAppearance.BorderSize = 2;
            rb_Small.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 60, 47);
            rb_Small.FlatStyle = FlatStyle.Flat;
            rb_Small.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            rb_Small.ForeColor = Color.White;
            rb_Small.Location = new Point(16, 8);
            rb_Small.Name = "rb_Small";
            rb_Small.Size = new Size(52, 59);
            rb_Small.TabIndex = 0;
            rb_Small.Text = "S";
            rb_Small.TextAlign = ContentAlignment.MiddleCenter;
            rb_Small.UseVisualStyleBackColor = true;
            // 
            // chbox_Mayonnaise
            // 
            chbox_Mayonnaise.Appearance = Appearance.Button;
            chbox_Mayonnaise.AutoSize = true;
            chbox_Mayonnaise.FlatAppearance.BorderColor = Color.FromArgb(255, 60, 47);
            chbox_Mayonnaise.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 60, 47);
            chbox_Mayonnaise.FlatStyle = FlatStyle.Flat;
            chbox_Mayonnaise.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            chbox_Mayonnaise.ForeColor = Color.White;
            chbox_Mayonnaise.Location = new Point(16, 137);
            chbox_Mayonnaise.Name = "chbox_Mayonnaise";
            chbox_Mayonnaise.Size = new Size(210, 55);
            chbox_Mayonnaise.TabIndex = 21;
            chbox_Mayonnaise.Text = "Mayonnaise";
            chbox_Mayonnaise.TextAlign = ContentAlignment.MiddleCenter;
            chbox_Mayonnaise.UseVisualStyleBackColor = true;
            // 
            // chbox_Ketchup
            // 
            chbox_Ketchup.Appearance = Appearance.Button;
            chbox_Ketchup.AutoSize = true;
            chbox_Ketchup.FlatAppearance.BorderColor = Color.FromArgb(255, 60, 47);
            chbox_Ketchup.FlatAppearance.CheckedBackColor = Color.FromArgb(255, 60, 47);
            chbox_Ketchup.FlatStyle = FlatStyle.Flat;
            chbox_Ketchup.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            chbox_Ketchup.ForeColor = Color.White;
            chbox_Ketchup.Location = new Point(16, 74);
            chbox_Ketchup.MinimumSize = new Size(210, 55);
            chbox_Ketchup.Name = "chbox_Ketchup";
            chbox_Ketchup.Size = new Size(210, 55);
            chbox_Ketchup.TabIndex = 20;
            chbox_Ketchup.Text = "Ketchup";
            chbox_Ketchup.TextAlign = ContentAlignment.MiddleCenter;
            chbox_Ketchup.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 14, 14);
            panel1.Controls.Add(lbl_OrderId);
            panel1.Controls.Add(lbl_OrderIdTitle);
            panel1.Location = new Point(12, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 64);
            panel1.TabIndex = 16;
            // 
            // lbl_OrderId
            // 
            lbl_OrderId.AutoSize = true;
            lbl_OrderId.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbl_OrderId.ForeColor = Color.White;
            lbl_OrderId.Location = new Point(135, 0);
            lbl_OrderId.Name = "lbl_OrderId";
            lbl_OrderId.Size = new Size(56, 32);
            lbl_OrderId.TabIndex = 15;
            lbl_OrderId.Text = "100";
            // 
            // lbl_OrderIdTitle
            // 
            lbl_OrderIdTitle.AutoSize = true;
            lbl_OrderIdTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbl_OrderIdTitle.ForeColor = Color.White;
            lbl_OrderIdTitle.Location = new Point(0, 0);
            lbl_OrderIdTitle.Name = "lbl_OrderIdTitle";
            lbl_OrderIdTitle.Size = new Size(142, 32);
            lbl_OrderIdTitle.TabIndex = 14;
            lbl_OrderIdTitle.Text = "ORDER ID: ";
            // 
            // imgList_Products
            // 
            imgList_Products.ColorDepth = ColorDepth.Depth32Bit;
            imgList_Products.ImageSize = new Size(16, 16);
            imgList_Products.TransparentColor = Color.Transparent;
            // 
            // BurgerAppAddOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(1023, 628);
            Controls.Add(panel1);
            Controls.Add(pnl_Sizes);
            Controls.Add(cmbox_Products);
            Controls.Add(pbox_ProductImage);
            Controls.Add(pnl_TotalPrice);
            Controls.Add(btn_ConfirmOrder);
            Controls.Add(btn_RemoveBasket);
            Controls.Add(btn_AddBasket);
            Controls.Add(lbox_OrderList);
            Controls.Add(btn_Back);
            Controls.Add(pnl_Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BurgerAppAddOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BurgerAppAddOrder";
            Load += BurgerAppAddOrder_Load;
            pnl_Title.ResumeLayout(false);
            pnl_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbox_ProductImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            pnl_Sizes.ResumeLayout(false);
            pnl_Sizes.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Title;
        private Label lbl_AddOrderTitle;
        private Label lbl_Title;
        private Button btn_Back;
        private ListBox lbox_OrderList;
        private Button btn_AddBasket;
        private Button btn_RemoveBasket;
        private Button btn_ConfirmOrder;
        private Panel pnl_TotalPrice;
        private PictureBox pbox_ProductImage;
        private ComboBox cmbox_Products;
        private BindingSource productBindingSource;
        private Panel pnl_Sizes;
        private RadioButton rb_Large;
        private RadioButton rb_Medium;
        private RadioButton rb_Small;
        private Panel panel1;
        private CheckBox chbox_Mayonnaise;
        private CheckBox chbox_Ketchup;
        private CheckBox chbox_Mustard;
        private Label lbl_OrderId;
        private Label lbl_OrderIdTitle;
        private ImageList imgList_Products;
    }
}