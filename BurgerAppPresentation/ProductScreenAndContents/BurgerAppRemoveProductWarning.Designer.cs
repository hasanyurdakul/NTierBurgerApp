namespace BurgerAppPresentation.ProductScreenAndContents
{
    partial class BurgerAppRemoveProductWarning
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
            lbl_Warning = new Label();
            pnl_Title = new Panel();
            label1 = new Label();
            label2 = new Label();
            lbl_Paragraph = new Label();
            btn_Discard = new Button();
            btn_Apply = new Button();
            pnl_Title.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Warning
            // 
            lbl_Warning.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Warning.AutoSize = true;
            lbl_Warning.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Warning.ForeColor = Color.FromArgb(14, 14, 14);
            lbl_Warning.Location = new Point(-383, 1);
            lbl_Warning.Name = "lbl_Warning";
            lbl_Warning.Size = new Size(105, 25);
            lbl_Warning.TabIndex = 13;
            lbl_Warning.Text = "WARNING";
            // 
            // pnl_Title
            // 
            pnl_Title.BackColor = Color.FromArgb(255, 60, 47);
            pnl_Title.Controls.Add(label1);
            pnl_Title.Controls.Add(lbl_Warning);
            pnl_Title.Dock = DockStyle.Top;
            pnl_Title.Location = new Point(0, 0);
            pnl_Title.Name = "pnl_Title";
            pnl_Title.Size = new Size(357, 27);
            pnl_Title.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(14, 14, 14);
            label1.Location = new Point(252, 1);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 14;
            label1.Text = "WARNING";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 60, 47);
            label2.Location = new Point(29, 97);
            label2.Name = "label2";
            label2.Size = new Size(307, 25);
            label2.TabIndex = 31;
            label2.Text = "THIS ACTION IS NOT REVERTIBLE";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Paragraph
            // 
            lbl_Paragraph.AutoSize = true;
            lbl_Paragraph.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Paragraph.ForeColor = Color.White;
            lbl_Paragraph.Location = new Point(4, 47);
            lbl_Paragraph.Name = "lbl_Paragraph";
            lbl_Paragraph.Size = new Size(356, 50);
            lbl_Paragraph.TabIndex = 30;
            lbl_Paragraph.Text = "ARE YOU SURE YOU WANT TO DELETE \r\nTHE SELECTED PRODUCT?";
            lbl_Paragraph.TextAlign = ContentAlignment.MiddleCenter;
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
            btn_Discard.Location = new Point(19, 144);
            btn_Discard.Name = "btn_Discard";
            btn_Discard.Size = new Size(150, 80);
            btn_Discard.TabIndex = 33;
            btn_Discard.UseVisualStyleBackColor = false;
            btn_Discard.Click += btn_Discard_Click;
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
            btn_Apply.Location = new Point(186, 144);
            btn_Apply.Name = "btn_Apply";
            btn_Apply.Size = new Size(150, 80);
            btn_Apply.TabIndex = 32;
            btn_Apply.UseVisualStyleBackColor = false;
            btn_Apply.Click += btn_Apply_Click;
            // 
            // BurgerAppRemoveProductWarning
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(357, 236);
            Controls.Add(btn_Discard);
            Controls.Add(btn_Apply);
            Controls.Add(label2);
            Controls.Add(lbl_Paragraph);
            Controls.Add(pnl_Title);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "BurgerAppRemoveProductWarning";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BurgerAppRemoveProductWarning";
            pnl_Title.ResumeLayout(false);
            pnl_Title.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Warning;
        private Panel pnl_Title;
        private Label label1;
        private Label label2;
        private Label lbl_Paragraph;
        private Button btn_Discard;
        private Button btn_Apply;
    }
}