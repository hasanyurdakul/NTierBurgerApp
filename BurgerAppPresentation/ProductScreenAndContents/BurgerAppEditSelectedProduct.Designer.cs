namespace BurgerAppPresentation.ProductScreenAndContents
{
    partial class BurgerAppEditSelectedProduct
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
            pnl_Title = new Panel();
            lbl_Title = new Label();
            btn_Discard = new Button();
            btn_Apply = new Button();
            lbl_ProductName = new Label();
            tbox_ProductName = new TextBox();
            lbl_UnitPrice = new Label();
            tbox_UnitPrice = new MaskedTextBox();
            lbl_Description = new Label();
            tbox_Description = new TextBox();
            pnl_Title.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Title
            // 
            pnl_Title.BackColor = Color.FromArgb(255, 60, 47);
            pnl_Title.Controls.Add(lbl_Title);
            pnl_Title.Dock = DockStyle.Top;
            pnl_Title.Location = new Point(0, 0);
            pnl_Title.Name = "pnl_Title";
            pnl_Title.Size = new Size(338, 27);
            pnl_Title.TabIndex = 14;
            // 
            // lbl_Title
            // 
            lbl_Title.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.FromArgb(14, 14, 14);
            lbl_Title.Location = new Point(99, 1);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(239, 25);
            lbl_Title.TabIndex = 14;
            lbl_Title.Text = "EDIT SELECTED PRODUCT";
            // 
            // btn_Discard
            // 
            btn_Discard.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Discard.BackColor = Color.FromArgb(255, 60, 47);
            btn_Discard.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Discard.Cursor = Cursors.Hand;
            btn_Discard.FlatAppearance.BorderSize = 0;
            btn_Discard.FlatStyle = FlatStyle.Flat;
            btn_Discard.ForeColor = Color.Coral;
            btn_Discard.Image = Properties.Resources.Discard;
            btn_Discard.Location = new Point(12, 460);
            btn_Discard.Name = "btn_Discard";
            btn_Discard.Size = new Size(150, 80);
            btn_Discard.TabIndex = 28;
            btn_Discard.UseVisualStyleBackColor = false;
            btn_Discard.Click += btn_Discard_Click;
            // 
            // btn_Apply
            // 
            btn_Apply.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Apply.BackColor = Color.FromArgb(255, 60, 47);
            btn_Apply.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Apply.Cursor = Cursors.Hand;
            btn_Apply.FlatAppearance.BorderSize = 0;
            btn_Apply.FlatStyle = FlatStyle.Flat;
            btn_Apply.ForeColor = Color.Coral;
            btn_Apply.Image = Properties.Resources.Done;
            btn_Apply.Location = new Point(176, 460);
            btn_Apply.Name = "btn_Apply";
            btn_Apply.Size = new Size(150, 80);
            btn_Apply.TabIndex = 27;
            btn_Apply.UseVisualStyleBackColor = false;
            btn_Apply.Click += btn_Apply_Click;
            // 
            // lbl_ProductName
            // 
            lbl_ProductName.AutoSize = true;
            lbl_ProductName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ProductName.ForeColor = Color.White;
            lbl_ProductName.Location = new Point(12, 41);
            lbl_ProductName.Name = "lbl_ProductName";
            lbl_ProductName.Size = new Size(161, 30);
            lbl_ProductName.TabIndex = 30;
            lbl_ProductName.Text = "Product Name:";
            // 
            // tbox_ProductName
            // 
            tbox_ProductName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbox_ProductName.Location = new Point(188, 38);
            tbox_ProductName.Name = "tbox_ProductName";
            tbox_ProductName.Size = new Size(131, 35);
            tbox_ProductName.TabIndex = 29;
            tbox_ProductName.Text = "Product Name";
            // 
            // lbl_UnitPrice
            // 
            lbl_UnitPrice.AutoSize = true;
            lbl_UnitPrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_UnitPrice.ForeColor = Color.White;
            lbl_UnitPrice.Location = new Point(12, 92);
            lbl_UnitPrice.Name = "lbl_UnitPrice";
            lbl_UnitPrice.Size = new Size(115, 30);
            lbl_UnitPrice.TabIndex = 32;
            lbl_UnitPrice.Text = "Unit Price:";
            lbl_UnitPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbox_UnitPrice
            // 
            tbox_UnitPrice.Font = new Font("Segoe UI", 15.75F);
            tbox_UnitPrice.Location = new Point(188, 89);
            tbox_UnitPrice.Mask = "0000";
            tbox_UnitPrice.Name = "tbox_UnitPrice";
            tbox_UnitPrice.Size = new Size(131, 35);
            tbox_UnitPrice.TabIndex = 33;
            tbox_UnitPrice.ValidatingType = typeof(int);
            // 
            // lbl_Description
            // 
            lbl_Description.AutoSize = true;
            lbl_Description.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Description.ForeColor = Color.White;
            lbl_Description.Location = new Point(12, 146);
            lbl_Description.Name = "lbl_Description";
            lbl_Description.Size = new Size(131, 30);
            lbl_Description.TabIndex = 35;
            lbl_Description.Text = "Description:";
            // 
            // tbox_Description
            // 
            tbox_Description.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbox_Description.Location = new Point(188, 143);
            tbox_Description.Multiline = true;
            tbox_Description.Name = "tbox_Description";
            tbox_Description.Size = new Size(131, 299);
            tbox_Description.TabIndex = 34;
            tbox_Description.Text = "Description";
            // 
            // BurgerAppEditSelectedProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(338, 552);
            Controls.Add(lbl_Description);
            Controls.Add(tbox_Description);
            Controls.Add(tbox_UnitPrice);
            Controls.Add(lbl_UnitPrice);
            Controls.Add(lbl_ProductName);
            Controls.Add(tbox_ProductName);
            Controls.Add(btn_Discard);
            Controls.Add(btn_Apply);
            Controls.Add(pnl_Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BurgerAppEditSelectedProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BurgerAppEditSelectedProduct";
            Load += BurgerAppEditSelectedProduct_Load;
            pnl_Title.ResumeLayout(false);
            pnl_Title.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnl_Title;
        private Label lbl_Title;
        private Button btn_Discard;
        private Button btn_Apply;
        private Label lbl_ProductName;
        private TextBox tbox_ProductName;
        private Label lbl_UnitPrice;
        private MaskedTextBox tbox_UnitPrice;
        private Label lbl_Description;
        private TextBox tbox_Description;
    }
}