namespace BurgerAppPresentation
{
    partial class BurgerAppDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BurgerAppDashboard));
            btn_Exit = new Button();
            btn_Customers = new Button();
            btn_Orders = new Button();
            btn_Reports = new Button();
            btn_Settings = new Button();
            SuspendLayout();
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = Color.FromArgb(255, 60, 47);
            btn_Exit.BackgroundImage = (Image)resources.GetObject("btn_Exit.BackgroundImage");
            btn_Exit.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Exit.Cursor = Cursors.Hand;
            btn_Exit.FlatAppearance.BorderSize = 0;
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.ForeColor = Color.Coral;
            btn_Exit.Location = new Point(924, 424);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(64, 64);
            btn_Exit.TabIndex = 0;
            btn_Exit.UseVisualStyleBackColor = false;
            // 
            // btn_Customers
            // 
            btn_Customers.BackColor = Color.FromArgb(255, 60, 47);
            btn_Customers.BackgroundImage = (Image)resources.GetObject("btn_Customers.BackgroundImage");
            btn_Customers.BackgroundImageLayout = ImageLayout.None;
            btn_Customers.Cursor = Cursors.Hand;
            btn_Customers.FlatAppearance.BorderSize = 0;
            btn_Customers.FlatStyle = FlatStyle.Flat;
            btn_Customers.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Customers.ForeColor = Color.FromArgb(14, 14, 14);
            btn_Customers.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Customers.Location = new Point(12, 12);
            btn_Customers.Name = "btn_Customers";
            btn_Customers.Size = new Size(290, 95);
            btn_Customers.TabIndex = 1;
            btn_Customers.Text = "Customers";
            btn_Customers.TextAlign = ContentAlignment.MiddleRight;
            btn_Customers.UseVisualStyleBackColor = false;
            // 
            // btn_Orders
            // 
            btn_Orders.BackColor = Color.FromArgb(255, 60, 47);
            btn_Orders.BackgroundImageLayout = ImageLayout.None;
            btn_Orders.Cursor = Cursors.Hand;
            btn_Orders.FlatAppearance.BorderSize = 0;
            btn_Orders.FlatStyle = FlatStyle.Flat;
            btn_Orders.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Orders.ForeColor = Color.FromArgb(14, 14, 14);
            btn_Orders.Image = (Image)resources.GetObject("btn_Orders.Image");
            btn_Orders.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Orders.Location = new Point(12, 129);
            btn_Orders.Name = "btn_Orders";
            btn_Orders.Size = new Size(290, 95);
            btn_Orders.TabIndex = 2;
            btn_Orders.Text = "Orders";
            btn_Orders.TextAlign = ContentAlignment.MiddleRight;
            btn_Orders.UseVisualStyleBackColor = false;
            // 
            // btn_Reports
            // 
            btn_Reports.BackColor = Color.FromArgb(255, 60, 47);
            btn_Reports.BackgroundImageLayout = ImageLayout.None;
            btn_Reports.Cursor = Cursors.Hand;
            btn_Reports.FlatAppearance.BorderSize = 0;
            btn_Reports.FlatStyle = FlatStyle.Flat;
            btn_Reports.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Reports.ForeColor = Color.FromArgb(14, 14, 14);
            btn_Reports.Image = (Image)resources.GetObject("btn_Reports.Image");
            btn_Reports.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Reports.Location = new Point(12, 249);
            btn_Reports.Name = "btn_Reports";
            btn_Reports.Size = new Size(290, 95);
            btn_Reports.TabIndex = 3;
            btn_Reports.Text = "Reports";
            btn_Reports.TextAlign = ContentAlignment.MiddleRight;
            btn_Reports.UseVisualStyleBackColor = false;
            // 
            // btn_Settings
            // 
            btn_Settings.BackColor = Color.FromArgb(255, 60, 47);
            btn_Settings.BackgroundImageLayout = ImageLayout.None;
            btn_Settings.Cursor = Cursors.Hand;
            btn_Settings.FlatAppearance.BorderSize = 0;
            btn_Settings.FlatStyle = FlatStyle.Flat;
            btn_Settings.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Settings.ForeColor = Color.FromArgb(14, 14, 14);
            btn_Settings.Image = (Image)resources.GetObject("btn_Settings.Image");
            btn_Settings.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Settings.Location = new Point(12, 372);
            btn_Settings.Name = "btn_Settings";
            btn_Settings.Size = new Size(290, 95);
            btn_Settings.TabIndex = 4;
            btn_Settings.Text = "Settings";
            btn_Settings.TextAlign = ContentAlignment.MiddleRight;
            btn_Settings.UseVisualStyleBackColor = false;
            // 
            // BurgerAppDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(1000, 500);
            Controls.Add(btn_Settings);
            Controls.Add(btn_Reports);
            Controls.Add(btn_Orders);
            Controls.Add(btn_Customers);
            Controls.Add(btn_Exit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BurgerAppDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BurgerAppDashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Exit;
        private Button btn_Customers;
        private Button btn_Orders;
        private Button btn_Reports;
        private Button btn_Settings;
    }
}