namespace BurgerAppPresentation
{
    partial class BurgerAppEditSelectedCustomer
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
            label1 = new Label();
            tbox_FirstName = new TextBox();
            lbl_FirstName = new Label();
            lbl_LastName = new Label();
            tbox_LastName = new TextBox();
            lbl_Email = new Label();
            tbox_Email = new TextBox();
            lbl_PhoneNumber = new Label();
            lbl_Address = new Label();
            tbox_Adress = new TextBox();
            tbox_PhoneNumber = new MaskedTextBox();
            btn_Apply = new Button();
            btn_Discard = new Button();
            pnl_Title.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Title
            // 
            pnl_Title.BackColor = Color.FromArgb(255, 60, 47);
            pnl_Title.Controls.Add(lbl_Title);
            pnl_Title.Controls.Add(label1);
            pnl_Title.Dock = DockStyle.Top;
            pnl_Title.Location = new Point(0, 0);
            pnl_Title.Name = "pnl_Title";
            pnl_Title.Size = new Size(338, 27);
            pnl_Title.TabIndex = 13;
            // 
            // lbl_Title
            // 
            lbl_Title.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.FromArgb(14, 14, 14);
            lbl_Title.Location = new Point(88, 1);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(250, 25);
            lbl_Title.TabIndex = 14;
            lbl_Title.Text = "EDIT SELECTED CUSTOMER";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(14, 14, 14);
            label1.Location = new Point(917, 1);
            label1.Name = "label1";
            label1.Size = new Size(346, 25);
            label1.TabIndex = 12;
            label1.Text = "WISSEN BURGER COMS - CUSTOMERS";
            // 
            // tbox_FirstName
            // 
            tbox_FirstName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbox_FirstName.Location = new Point(188, 38);
            tbox_FirstName.Name = "tbox_FirstName";
            tbox_FirstName.Size = new Size(131, 35);
            tbox_FirstName.TabIndex = 1;
            tbox_FirstName.Text = "First Name";
            // 
            // lbl_FirstName
            // 
            lbl_FirstName.AutoSize = true;
            lbl_FirstName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_FirstName.ForeColor = Color.White;
            lbl_FirstName.Location = new Point(12, 43);
            lbl_FirstName.Name = "lbl_FirstName";
            lbl_FirstName.Size = new Size(125, 30);
            lbl_FirstName.TabIndex = 15;
            lbl_FirstName.Text = "First Name:";
            // 
            // lbl_LastName
            // 
            lbl_LastName.AutoSize = true;
            lbl_LastName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_LastName.ForeColor = Color.White;
            lbl_LastName.Location = new Point(12, 98);
            lbl_LastName.Name = "lbl_LastName";
            lbl_LastName.Size = new Size(122, 30);
            lbl_LastName.TabIndex = 17;
            lbl_LastName.Text = "Last Name:";
            // 
            // tbox_LastName
            // 
            tbox_LastName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbox_LastName.Location = new Point(188, 93);
            tbox_LastName.Name = "tbox_LastName";
            tbox_LastName.Size = new Size(131, 35);
            tbox_LastName.TabIndex = 2;
            tbox_LastName.Text = "Last Name";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Email.ForeColor = Color.White;
            lbl_Email.Location = new Point(12, 153);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(72, 30);
            lbl_Email.TabIndex = 19;
            lbl_Email.Text = "Email:";
            // 
            // tbox_Email
            // 
            tbox_Email.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbox_Email.Location = new Point(188, 148);
            tbox_Email.Name = "tbox_Email";
            tbox_Email.Size = new Size(131, 35);
            tbox_Email.TabIndex = 3;
            tbox_Email.Text = "Email";
            // 
            // lbl_PhoneNumber
            // 
            lbl_PhoneNumber.AutoSize = true;
            lbl_PhoneNumber.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_PhoneNumber.ForeColor = Color.White;
            lbl_PhoneNumber.Location = new Point(12, 208);
            lbl_PhoneNumber.Name = "lbl_PhoneNumber";
            lbl_PhoneNumber.Size = new Size(170, 30);
            lbl_PhoneNumber.TabIndex = 21;
            lbl_PhoneNumber.Text = "Phone Number:";
            // 
            // lbl_Address
            // 
            lbl_Address.AutoSize = true;
            lbl_Address.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Address.ForeColor = Color.White;
            lbl_Address.Location = new Point(12, 263);
            lbl_Address.Name = "lbl_Address";
            lbl_Address.Size = new Size(97, 30);
            lbl_Address.TabIndex = 23;
            lbl_Address.Text = "Address:";
            // 
            // tbox_Adress
            // 
            tbox_Adress.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbox_Adress.Location = new Point(188, 258);
            tbox_Adress.Multiline = true;
            tbox_Adress.Name = "tbox_Adress";
            tbox_Adress.Size = new Size(131, 180);
            tbox_Adress.TabIndex = 5;
            tbox_Adress.Text = "Address";
            // 
            // tbox_PhoneNumber
            // 
            tbox_PhoneNumber.Font = new Font("Segoe UI", 15.75F);
            tbox_PhoneNumber.Location = new Point(188, 203);
            tbox_PhoneNumber.Mask = "(599) 000-0000";
            tbox_PhoneNumber.Name = "tbox_PhoneNumber";
            tbox_PhoneNumber.Size = new Size(131, 35);
            tbox_PhoneNumber.TabIndex = 4;
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
            btn_Apply.TabIndex = 25;
            btn_Apply.UseVisualStyleBackColor = false;
            btn_Apply.Click += btn_Apply_Click;
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
            btn_Discard.TabIndex = 26;
            btn_Discard.UseVisualStyleBackColor = false;
            btn_Discard.Click += btn_Discard_Click;
            // 
            // BurgerAppEditSelectedCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(338, 552);
            Controls.Add(btn_Discard);
            Controls.Add(btn_Apply);
            Controls.Add(tbox_PhoneNumber);
            Controls.Add(lbl_Address);
            Controls.Add(tbox_Adress);
            Controls.Add(lbl_PhoneNumber);
            Controls.Add(lbl_Email);
            Controls.Add(tbox_Email);
            Controls.Add(lbl_LastName);
            Controls.Add(tbox_LastName);
            Controls.Add(lbl_FirstName);
            Controls.Add(tbox_FirstName);
            Controls.Add(pnl_Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BurgerAppEditSelectedCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BurgerAppEditSelectedCustomer";
            Load += BurgerAppEditSelectedCustomer_Load;
            pnl_Title.ResumeLayout(false);
            pnl_Title.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnl_Title;
        private Label label1;
        private Label lbl_Title;
        private TextBox tbox_FirstName;
        private Label lbl_FirstName;
        private Label lbl_LastName;
        private TextBox tbox_LastName;
        private Label lbl_Email;
        private TextBox tbox_Email;
        private Label lbl_PhoneNumber;
        private Label lbl_Address;
        private TextBox tbox_Adress;
        private MaskedTextBox tbox_PhoneNumber;
        private Button btn_Apply;
        private Button btn_Discard;
    }
}