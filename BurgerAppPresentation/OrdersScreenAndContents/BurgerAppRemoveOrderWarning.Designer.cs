namespace BurgerAppPresentation
{
    partial class BurgerAppRemoveOrderWarning
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
            lbl_Warning = new Label();
            lbl_Title = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btn_Discard = new Button();
            btn_Apply = new Button();
            label2 = new Label();
            lbl_Paragraph = new Label();
            pnl_Title.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Title
            // 
            pnl_Title.BackColor = Color.FromArgb(255, 60, 47);
            pnl_Title.Controls.Add(label1);
            pnl_Title.Controls.Add(lbl_Warning);
            pnl_Title.Controls.Add(lbl_Title);
            pnl_Title.Dock = DockStyle.Top;
            pnl_Title.Location = new Point(0, 0);
            pnl_Title.Name = "pnl_Title";
            pnl_Title.Size = new Size(373, 27);
            pnl_Title.TabIndex = 4;
            // 
            // lbl_Warning
            // 
            lbl_Warning.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Warning.AutoSize = true;
            lbl_Warning.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Warning.ForeColor = Color.FromArgb(14, 14, 14);
            lbl_Warning.Location = new Point(446, 1);
            lbl_Warning.Name = "lbl_Warning";
            lbl_Warning.Size = new Size(105, 25);
            lbl_Warning.TabIndex = 13;
            lbl_Warning.Text = "WARNING";
            // 
            // lbl_Title
            // 
            lbl_Title.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.FromArgb(14, 14, 14);
            lbl_Title.Location = new Point(1159, 1);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(346, 25);
            lbl_Title.TabIndex = 12;
            lbl_Title.Text = "WISSEN BURGER COMS - CUSTOMERS";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(14, 14, 14);
            label1.Location = new Point(268, 1);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 14;
            label1.Text = "WARNING";
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Discard);
            panel1.Controls.Add(btn_Apply);
            panel1.Location = new Point(21, 154);
            panel1.Name = "panel1";
            panel1.Size = new Size(323, 104);
            panel1.TabIndex = 33;
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
            btn_Discard.Location = new Point(3, 12);
            btn_Discard.Name = "btn_Discard";
            btn_Discard.Size = new Size(150, 80);
            btn_Discard.TabIndex = 28;
            btn_Discard.UseVisualStyleBackColor = false;
            // 
            // btn_Apply
            // 
            btn_Apply.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Apply.BackColor = Color.FromArgb(255, 60, 47);
            btn_Apply.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Apply.Cursor = Cursors.Hand;
            btn_Apply.FlatAppearance.BorderSize = 0;
            btn_Apply.FlatStyle = FlatStyle.Flat;
            btn_Apply.ForeColor = Color.Coral;
            btn_Apply.Image = Properties.Resources.Done;
            btn_Apply.Location = new Point(170, 12);
            btn_Apply.Name = "btn_Apply";
            btn_Apply.Size = new Size(150, 80);
            btn_Apply.TabIndex = 27;
            btn_Apply.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 60, 47);
            label2.Location = new Point(37, 126);
            label2.Name = "label2";
            label2.Size = new Size(307, 25);
            label2.TabIndex = 32;
            label2.Text = "THIS ACTION IS NOT REVERTIBLE";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Paragraph
            // 
            lbl_Paragraph.AutoSize = true;
            lbl_Paragraph.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Paragraph.ForeColor = Color.White;
            lbl_Paragraph.Location = new Point(12, 39);
            lbl_Paragraph.Name = "lbl_Paragraph";
            lbl_Paragraph.Size = new Size(356, 75);
            lbl_Paragraph.TabIndex = 31;
            lbl_Paragraph.Text = "ARE YOU SURE YOU WANT TO DELETE \r\nTHE SELECTED CUSTOMER AND ALL\r\nFIELDS RELATED TO IT?\r\n";
            lbl_Paragraph.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BurgerAppRemoveOrderWarning
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(373, 275);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(lbl_Paragraph);
            Controls.Add(pnl_Title);
            FormBorderStyle = FormBorderStyle.None;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "BurgerAppRemoveOrderWarning";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BurgerAppRemoveOrderWarning";
            pnl_Title.ResumeLayout(false);
            pnl_Title.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnl_Title;
        private Label lbl_Warning;
        private Label lbl_Title;
        private Label label1;
        private Panel panel1;
        private Button btn_Discard;
        private Button btn_Apply;
        private Label label2;
        private Label lbl_Paragraph;
    }
}