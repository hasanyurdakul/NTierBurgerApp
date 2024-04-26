namespace BurgerAppPresentation.OrdersScreenAndContents
{
    partial class BurgerAppAskPhoneNumber
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
            tbox_PhoneNumber = new MaskedTextBox();
            btn_Discard = new Button();
            btn_Apply = new Button();
            pnl_Title = new Panel();
            lbl_AskPhoneNumberTitle = new Label();
            label1 = new Label();
            lbl_Text = new Label();
            pnl_Title.SuspendLayout();
            SuspendLayout();
            // 
            // tbox_PhoneNumber
            // 
            tbox_PhoneNumber.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbox_PhoneNumber.Location = new Point(86, 111);
            tbox_PhoneNumber.Mask = "(599) 000-0000";
            tbox_PhoneNumber.Name = "tbox_PhoneNumber";
            tbox_PhoneNumber.Size = new Size(219, 57);
            tbox_PhoneNumber.TabIndex = 5;
            // 
            // btn_Discard
            // 
            btn_Discard.BackColor = Color.FromArgb(255, 60, 47);
            btn_Discard.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Discard.Cursor = Cursors.Hand;
            btn_Discard.FlatAppearance.BorderSize = 0;
            btn_Discard.FlatStyle = FlatStyle.Flat;
            btn_Discard.ForeColor = Color.Coral;
            btn_Discard.Image = Properties.Resources.Discard;
            btn_Discard.Location = new Point(28, 189);
            btn_Discard.Name = "btn_Discard";
            btn_Discard.Size = new Size(150, 80);
            btn_Discard.TabIndex = 28;
            btn_Discard.UseVisualStyleBackColor = false;
            btn_Discard.Click += btn_Discard_Click;
            // 
            // btn_Apply
            // 
            btn_Apply.BackColor = Color.FromArgb(255, 60, 47);
            btn_Apply.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Apply.Cursor = Cursors.Hand;
            btn_Apply.FlatAppearance.BorderSize = 0;
            btn_Apply.FlatStyle = FlatStyle.Flat;
            btn_Apply.ForeColor = Color.Coral;
            btn_Apply.Image = Properties.Resources.Done;
            btn_Apply.Location = new Point(192, 189);
            btn_Apply.Name = "btn_Apply";
            btn_Apply.Size = new Size(150, 80);
            btn_Apply.TabIndex = 27;
            btn_Apply.UseVisualStyleBackColor = false;
            btn_Apply.Click += btn_Apply_Click;
            // 
            // pnl_Title
            // 
            pnl_Title.BackColor = Color.FromArgb(255, 60, 47);
            pnl_Title.Controls.Add(lbl_AskPhoneNumberTitle);
            pnl_Title.Controls.Add(label1);
            pnl_Title.Dock = DockStyle.Top;
            pnl_Title.Location = new Point(0, 0);
            pnl_Title.Name = "pnl_Title";
            pnl_Title.Size = new Size(371, 27);
            pnl_Title.TabIndex = 29;
            // 
            // lbl_AskPhoneNumberTitle
            // 
            lbl_AskPhoneNumberTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_AskPhoneNumberTitle.AutoSize = true;
            lbl_AskPhoneNumberTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_AskPhoneNumberTitle.ForeColor = Color.FromArgb(14, 14, 14);
            lbl_AskPhoneNumberTitle.Location = new Point(87, 1);
            lbl_AskPhoneNumberTitle.Name = "lbl_AskPhoneNumberTitle";
            lbl_AskPhoneNumberTitle.Size = new Size(284, 25);
            lbl_AskPhoneNumberTitle.TabIndex = 14;
            lbl_AskPhoneNumberTitle.Text = "CUSTOMER'S PHONE NUMBER";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(14, 14, 14);
            label1.Location = new Point(1126, 1);
            label1.Name = "label1";
            label1.Size = new Size(346, 25);
            label1.TabIndex = 12;
            label1.Text = "WISSEN BURGER COMS - CUSTOMERS";
            // 
            // lbl_Text
            // 
            lbl_Text.AutoSize = true;
            lbl_Text.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Text.ForeColor = Color.White;
            lbl_Text.Location = new Point(59, 49);
            lbl_Text.Name = "lbl_Text";
            lbl_Text.Size = new Size(266, 50);
            lbl_Text.TabIndex = 15;
            lbl_Text.Text = "PLEASE ENTER CUSTOMER'S \r\nPHONE NUMBER";
            lbl_Text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BurgerAppAskPhoneNumber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(371, 297);
            Controls.Add(lbl_Text);
            Controls.Add(pnl_Title);
            Controls.Add(btn_Discard);
            Controls.Add(btn_Apply);
            Controls.Add(tbox_PhoneNumber);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BurgerAppAskPhoneNumber";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BurgerAppAskPhoneNumber";
            pnl_Title.ResumeLayout(false);
            pnl_Title.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox tbox_PhoneNumber;
        private Button btn_Discard;
        private Button btn_Apply;
        private Panel pnl_Title;
        private Label lbl_AskPhoneNumberTitle;
        private Label label1;
        private Label lbl_Text;
    }
}