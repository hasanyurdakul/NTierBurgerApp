namespace BurgerAppPresentation.OrdersScreenAndContents
{
    partial class BurgerAppEditOrderStatus
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
            lbl_EditOrderStatusTitle = new Label();
            lbl_OrdersTitle = new Label();
            lbl_Title = new Label();
            btn_Discard = new Button();
            btn_Apply = new Button();
            lbl_OrderIdTitle = new Label();
            lbl_OrderId = new Label();
            lbl_StatusTitle = new Label();
            cmbox_Status = new ComboBox();
            label1 = new Label();
            pnl_Title.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Title
            // 
            pnl_Title.BackColor = Color.FromArgb(255, 60, 47);
            pnl_Title.Controls.Add(lbl_EditOrderStatusTitle);
            pnl_Title.Controls.Add(lbl_OrdersTitle);
            pnl_Title.Controls.Add(lbl_Title);
            pnl_Title.Dock = DockStyle.Top;
            pnl_Title.Location = new Point(0, 0);
            pnl_Title.Name = "pnl_Title";
            pnl_Title.Size = new Size(344, 27);
            pnl_Title.TabIndex = 4;
            // 
            // lbl_EditOrderStatusTitle
            // 
            lbl_EditOrderStatusTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_EditOrderStatusTitle.AutoSize = true;
            lbl_EditOrderStatusTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_EditOrderStatusTitle.ForeColor = Color.FromArgb(14, 14, 14);
            lbl_EditOrderStatusTitle.Location = new Point(150, 1);
            lbl_EditOrderStatusTitle.Name = "lbl_EditOrderStatusTitle";
            lbl_EditOrderStatusTitle.Size = new Size(194, 25);
            lbl_EditOrderStatusTitle.TabIndex = 14;
            lbl_EditOrderStatusTitle.Text = "EDIT ORDER STATUS";
            // 
            // lbl_OrdersTitle
            // 
            lbl_OrdersTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_OrdersTitle.AutoSize = true;
            lbl_OrdersTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_OrdersTitle.ForeColor = Color.FromArgb(14, 14, 14);
            lbl_OrdersTitle.Location = new Point(868, 1);
            lbl_OrdersTitle.Name = "lbl_OrdersTitle";
            lbl_OrdersTitle.Size = new Size(308, 25);
            lbl_OrdersTitle.TabIndex = 13;
            lbl_OrdersTitle.Text = "WISSEN BURGER COMS - ORDERS";
            // 
            // lbl_Title
            // 
            lbl_Title.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.FromArgb(14, 14, 14);
            lbl_Title.Location = new Point(1784, 1);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(346, 25);
            lbl_Title.TabIndex = 12;
            lbl_Title.Text = "WISSEN BURGER COMS - CUSTOMERS";
            // 
            // btn_Discard
            // 
            btn_Discard.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_Discard.BackColor = Color.FromArgb(255, 60, 47);
            btn_Discard.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Discard.Cursor = Cursors.Hand;
            btn_Discard.FlatAppearance.BorderSize = 0;
            btn_Discard.FlatStyle = FlatStyle.Flat;
            btn_Discard.ForeColor = Color.Coral;
            btn_Discard.Image = Properties.Resources.Discard;
            btn_Discard.Location = new Point(15, 288);
            btn_Discard.Name = "btn_Discard";
            btn_Discard.Size = new Size(150, 80);
            btn_Discard.TabIndex = 28;
            btn_Discard.UseVisualStyleBackColor = false;
            btn_Discard.Click += btn_Discard_Click;
            // 
            // btn_Apply
            // 
            btn_Apply.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_Apply.BackColor = Color.FromArgb(255, 60, 47);
            btn_Apply.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Apply.Cursor = Cursors.Hand;
            btn_Apply.FlatAppearance.BorderSize = 0;
            btn_Apply.FlatStyle = FlatStyle.Flat;
            btn_Apply.ForeColor = Color.Coral;
            btn_Apply.Image = Properties.Resources.Done;
            btn_Apply.Location = new Point(179, 288);
            btn_Apply.Name = "btn_Apply";
            btn_Apply.Size = new Size(150, 80);
            btn_Apply.TabIndex = 27;
            btn_Apply.UseVisualStyleBackColor = false;
            btn_Apply.Click += btn_Apply_Click;
            // 
            // lbl_OrderIdTitle
            // 
            lbl_OrderIdTitle.AutoSize = true;
            lbl_OrderIdTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_OrderIdTitle.ForeColor = Color.White;
            lbl_OrderIdTitle.Location = new Point(15, 47);
            lbl_OrderIdTitle.Name = "lbl_OrderIdTitle";
            lbl_OrderIdTitle.Size = new Size(111, 30);
            lbl_OrderIdTitle.TabIndex = 29;
            lbl_OrderIdTitle.Text = "ORDER ID";
            // 
            // lbl_OrderId
            // 
            lbl_OrderId.AutoSize = true;
            lbl_OrderId.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_OrderId.ForeColor = Color.White;
            lbl_OrderId.Location = new Point(77, 77);
            lbl_OrderId.Name = "lbl_OrderId";
            lbl_OrderId.Size = new Size(185, 86);
            lbl_OrderId.TabIndex = 30;
            lbl_OrderId.Text = "0000";
            // 
            // lbl_StatusTitle
            // 
            lbl_StatusTitle.AutoSize = true;
            lbl_StatusTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_StatusTitle.ForeColor = Color.White;
            lbl_StatusTitle.Location = new Point(15, 163);
            lbl_StatusTitle.Name = "lbl_StatusTitle";
            lbl_StatusTitle.Size = new Size(89, 30);
            lbl_StatusTitle.TabIndex = 31;
            lbl_StatusTitle.Text = "STATUS";
            // 
            // cmbox_Status
            // 
            cmbox_Status.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbox_Status.FormattingEnabled = true;
            cmbox_Status.Items.AddRange(new object[] { "Preparing", "Completed" });
            cmbox_Status.Location = new Point(15, 209);
            cmbox_Status.Name = "cmbox_Status";
            cmbox_Status.Size = new Size(271, 58);
            cmbox_Status.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 77);
            label1.Name = "label1";
            label1.Size = new Size(75, 86);
            label1.TabIndex = 33;
            label1.Text = "#";
            // 
            // BurgerAppEditOrderStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(344, 400);
            Controls.Add(label1);
            Controls.Add(cmbox_Status);
            Controls.Add(lbl_StatusTitle);
            Controls.Add(lbl_OrderId);
            Controls.Add(lbl_OrderIdTitle);
            Controls.Add(btn_Discard);
            Controls.Add(btn_Apply);
            Controls.Add(pnl_Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BurgerAppEditOrderStatus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BurgerAppEditOrderStatus";
            Load += BurgerAppEditOrderStatus_Load;
            pnl_Title.ResumeLayout(false);
            pnl_Title.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnl_Title;
        private Label lbl_OrdersTitle;
        private Label lbl_Title;
        private Label lbl_EditOrderStatusTitle;
        private Button btn_Discard;
        private Button btn_Apply;
        private Label lbl_OrderIdTitle;
        private Label lbl_OrderId;
        private Label lbl_StatusTitle;
        private ComboBox cmbox_Status;
        private Label label1;
    }
}