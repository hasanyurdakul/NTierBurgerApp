namespace BurgerAppPresentation
{
    partial class BurgerAppCustomers
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btn_Back = new Button();
            pnl_Title = new Panel();
            lbl_Title = new Label();
            dgv_Customers = new DataGridView();
            customerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerBindingSource = new BindingSource(components);
            pnl_DataGridView = new Panel();
            btn_AddCustomer = new Button();
            btn_RemoveCustomer = new Button();
            btn_EditCustomer = new Button();
            pnl_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Customers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            pnl_DataGridView.SuspendLayout();
            SuspendLayout();
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
            btn_Back.Location = new Point(1066, 466);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(64, 64);
            btn_Back.TabIndex = 1;
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // pnl_Title
            // 
            pnl_Title.BackColor = Color.FromArgb(255, 60, 47);
            pnl_Title.Controls.Add(lbl_Title);
            pnl_Title.Dock = DockStyle.Top;
            pnl_Title.Location = new Point(0, 0);
            pnl_Title.Name = "pnl_Title";
            pnl_Title.Size = new Size(1142, 27);
            pnl_Title.TabIndex = 2;
            // 
            // lbl_Title
            // 
            lbl_Title.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_Title.ForeColor = Color.FromArgb(14, 14, 14);
            lbl_Title.Location = new Point(796, 1);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(346, 25);
            lbl_Title.TabIndex = 12;
            lbl_Title.Text = "WISSEN BURGER COMS - CUSTOMERS";
            // 
            // dgv_Customers
            // 
            dgv_Customers.AllowUserToAddRows = false;
            dgv_Customers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(14, 14, 14);
            dgv_Customers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Customers.AutoGenerateColumns = false;
            dgv_Customers.BorderStyle = BorderStyle.None;
            dgv_Customers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Customers.Columns.AddRange(new DataGridViewColumn[] { customerIdDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn });
            dgv_Customers.DataSource = customerBindingSource;
            dgv_Customers.Dock = DockStyle.Fill;
            dgv_Customers.Location = new Point(0, 0);
            dgv_Customers.Name = "dgv_Customers";
            dgv_Customers.ReadOnly = true;
            dgv_Customers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Customers.Size = new Size(658, 515);
            dgv_Customers.TabIndex = 3;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(BurgerAppDomain.Customer);
            // 
            // pnl_DataGridView
            // 
            pnl_DataGridView.BackColor = Color.FromArgb(192, 255, 192);
            pnl_DataGridView.Controls.Add(dgv_Customers);
            pnl_DataGridView.Location = new Point(0, 27);
            pnl_DataGridView.Name = "pnl_DataGridView";
            pnl_DataGridView.Size = new Size(658, 515);
            pnl_DataGridView.TabIndex = 4;
            // 
            // btn_AddCustomer
            // 
            btn_AddCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_AddCustomer.BackColor = Color.FromArgb(255, 60, 47);
            btn_AddCustomer.BackgroundImageLayout = ImageLayout.None;
            btn_AddCustomer.Cursor = Cursors.Hand;
            btn_AddCustomer.FlatAppearance.BorderSize = 0;
            btn_AddCustomer.FlatStyle = FlatStyle.Flat;
            btn_AddCustomer.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddCustomer.ForeColor = Color.FromArgb(14, 14, 14);
            btn_AddCustomer.Image = Properties.Resources.Plus;
            btn_AddCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_AddCustomer.Location = new Point(673, 54);
            btn_AddCustomer.Name = "btn_AddCustomer";
            btn_AddCustomer.Size = new Size(457, 115);
            btn_AddCustomer.TabIndex = 5;
            btn_AddCustomer.Text = "Add New Customer";
            btn_AddCustomer.TextAlign = ContentAlignment.MiddleRight;
            btn_AddCustomer.UseVisualStyleBackColor = false;
            btn_AddCustomer.Click += btn_AddCustomer_Click;
            // 
            // btn_RemoveCustomer
            // 
            btn_RemoveCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_RemoveCustomer.BackColor = Color.FromArgb(255, 60, 47);
            btn_RemoveCustomer.BackgroundImageLayout = ImageLayout.None;
            btn_RemoveCustomer.Cursor = Cursors.Hand;
            btn_RemoveCustomer.FlatAppearance.BorderSize = 0;
            btn_RemoveCustomer.FlatStyle = FlatStyle.Flat;
            btn_RemoveCustomer.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_RemoveCustomer.ForeColor = Color.FromArgb(14, 14, 14);
            btn_RemoveCustomer.Image = Properties.Resources.Remove;
            btn_RemoveCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_RemoveCustomer.Location = new Point(673, 334);
            btn_RemoveCustomer.Name = "btn_RemoveCustomer";
            btn_RemoveCustomer.Size = new Size(457, 115);
            btn_RemoveCustomer.TabIndex = 6;
            btn_RemoveCustomer.Text = "Remove Customer";
            btn_RemoveCustomer.TextAlign = ContentAlignment.MiddleRight;
            btn_RemoveCustomer.UseVisualStyleBackColor = false;
            btn_RemoveCustomer.Click += btn_RemoveCustomer_Click;
            // 
            // btn_EditCustomer
            // 
            btn_EditCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_EditCustomer.BackColor = Color.FromArgb(255, 60, 47);
            btn_EditCustomer.BackgroundImageLayout = ImageLayout.None;
            btn_EditCustomer.Cursor = Cursors.Hand;
            btn_EditCustomer.FlatAppearance.BorderSize = 0;
            btn_EditCustomer.FlatStyle = FlatStyle.Flat;
            btn_EditCustomer.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EditCustomer.ForeColor = Color.FromArgb(14, 14, 14);
            btn_EditCustomer.Image = Properties.Resources.Edit;
            btn_EditCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btn_EditCustomer.Location = new Point(673, 194);
            btn_EditCustomer.Name = "btn_EditCustomer";
            btn_EditCustomer.Size = new Size(457, 115);
            btn_EditCustomer.TabIndex = 8;
            btn_EditCustomer.Text = "Edit Selected\r\nCustomer";
            btn_EditCustomer.TextAlign = ContentAlignment.MiddleRight;
            btn_EditCustomer.UseVisualStyleBackColor = false;
            btn_EditCustomer.Click += btn_EditCustomer_Click;
            // 
            // BurgerAppCustomers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(1142, 542);
            Controls.Add(btn_EditCustomer);
            Controls.Add(btn_RemoveCustomer);
            Controls.Add(btn_AddCustomer);
            Controls.Add(pnl_DataGridView);
            Controls.Add(pnl_Title);
            Controls.Add(btn_Back);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BurgerAppCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += BurgerAppCustomers_Load;
            pnl_Title.ResumeLayout(false);
            pnl_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Customers).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            pnl_DataGridView.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Back;
        private Panel pnl_Title;
        private Label lbl_Title;
        private DataGridView dgv_Customers;
        private DataGridViewTextBoxColumn ordersDataGridViewTextBoxColumn;
        private Panel pnl_DataGridView;
        private Button btn_AddCustomer;
        private Button btn_RemoveCustomer;
        private Button btn_EditCustomer;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private BindingSource customerBindingSource;
    }
}