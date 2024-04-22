namespace BurgerAppPresentation
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
            pnl_Title = new Panel();
            lbl_AddOrderTitle = new Label();
            lbl_Title = new Label();
            btn_Back = new Button();
            pnl_Title.SuspendLayout();
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
            pnl_Title.Size = new Size(800, 27);
            pnl_Title.TabIndex = 4;
            // 
            // lbl_AddOrderTitle
            // 
            lbl_AddOrderTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_AddOrderTitle.AutoSize = true;
            lbl_AddOrderTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_AddOrderTitle.ForeColor = Color.FromArgb(14, 14, 14);
            lbl_AddOrderTitle.Location = new Point(680, 1);
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
            lbl_Title.Location = new Point(1546, 1);
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
            btn_Back.Location = new Point(724, 374);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(64, 64);
            btn_Back.TabIndex = 10;
            btn_Back.UseVisualStyleBackColor = false;
            // 
            // BurgerAppAddOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Back);
            Controls.Add(pnl_Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BurgerAppAddOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BurgerAppAddOrder";
            pnl_Title.ResumeLayout(false);
            pnl_Title.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Title;
        private Label lbl_AddOrderTitle;
        private Label lbl_Title;
        private Button btn_Back;
    }
}