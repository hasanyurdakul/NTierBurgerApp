namespace BurgerAppPresentation.OrdersScreenAndContents
{
    partial class BurgerAppViewOrderDetails
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pnl_Title = new Panel();
            lbl_OrderDetailsTitle = new Label();
            lbl_OrdersTitle = new Label();
            lbl_Title = new Label();
            btn_Back = new Button();
            dgv_OrderDetails = new DataGridView();
            orderDetailIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sizeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderDetailBindingSource = new BindingSource(components);
            pnl_DataGridView = new Panel();
            pnl_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_OrderDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailBindingSource).BeginInit();
            pnl_DataGridView.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Title
            // 
            pnl_Title.BackColor = Color.FromArgb(255, 60, 47);
            pnl_Title.Controls.Add(lbl_OrderDetailsTitle);
            pnl_Title.Controls.Add(lbl_OrdersTitle);
            pnl_Title.Controls.Add(lbl_Title);
            pnl_Title.Dock = DockStyle.Top;
            pnl_Title.Location = new Point(0, 0);
            pnl_Title.Name = "pnl_Title";
            pnl_Title.Size = new Size(629, 27);
            pnl_Title.TabIndex = 4;
            // 
            // lbl_OrderDetailsTitle
            // 
            lbl_OrderDetailsTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_OrderDetailsTitle.AutoSize = true;
            lbl_OrderDetailsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_OrderDetailsTitle.ForeColor = Color.FromArgb(14, 14, 14);
            lbl_OrderDetailsTitle.Location = new Point(252, 1);
            lbl_OrderDetailsTitle.Name = "lbl_OrderDetailsTitle";
            lbl_OrderDetailsTitle.Size = new Size(377, 25);
            lbl_OrderDetailsTitle.TabIndex = 14;
            lbl_OrderDetailsTitle.Text = "WISSEN BURGER COMS - ORDER DETAILS";
            // 
            // lbl_OrdersTitle
            // 
            lbl_OrdersTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_OrdersTitle.AutoSize = true;
            lbl_OrdersTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_OrdersTitle.ForeColor = Color.FromArgb(14, 14, 14);
            lbl_OrdersTitle.Location = new Point(1039, 1);
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
            lbl_Title.Location = new Point(1955, 1);
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
            btn_Back.Location = new Point(553, 631);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(64, 64);
            btn_Back.TabIndex = 10;
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // dgv_OrderDetails
            // 
            dgv_OrderDetails.AllowUserToAddRows = false;
            dgv_OrderDetails.AllowUserToDeleteRows = false;
            dgv_OrderDetails.AutoGenerateColumns = false;
            dgv_OrderDetails.BackgroundColor = Color.FromArgb(14, 14, 14);
            dgv_OrderDetails.BorderStyle = BorderStyle.None;
            dgv_OrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_OrderDetails.Columns.AddRange(new DataGridViewColumn[] { orderDetailIdDataGridViewTextBoxColumn, orderIdDataGridViewTextBoxColumn, productIdDataGridViewTextBoxColumn, sizeIdDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn });
            dgv_OrderDetails.DataSource = orderDetailBindingSource;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgv_OrderDetails.DefaultCellStyle = dataGridViewCellStyle6;
            dgv_OrderDetails.Dock = DockStyle.Fill;
            dgv_OrderDetails.Location = new Point(0, 0);
            dgv_OrderDetails.Name = "dgv_OrderDetails";
            dgv_OrderDetails.ReadOnly = true;
            dgv_OrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_OrderDetails.Size = new Size(541, 680);
            dgv_OrderDetails.TabIndex = 11;
            // 
            // orderDetailIdDataGridViewTextBoxColumn
            // 
            orderDetailIdDataGridViewTextBoxColumn.DataPropertyName = "OrderDetailId";
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            orderDetailIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            orderDetailIdDataGridViewTextBoxColumn.HeaderText = "OrderDetailId";
            orderDetailIdDataGridViewTextBoxColumn.Name = "orderDetailIdDataGridViewTextBoxColumn";
            orderDetailIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            orderIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            productIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeIdDataGridViewTextBoxColumn
            // 
            sizeIdDataGridViewTextBoxColumn.DataPropertyName = "SizeId";
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            sizeIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            sizeIdDataGridViewTextBoxColumn.HeaderText = "SizeId";
            sizeIdDataGridViewTextBoxColumn.Name = "sizeIdDataGridViewTextBoxColumn";
            sizeIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDetailBindingSource
            // 
            orderDetailBindingSource.DataSource = typeof(BurgerAppDomain.OrderDetail);
            // 
            // pnl_DataGridView
            // 
            pnl_DataGridView.Controls.Add(dgv_OrderDetails);
            pnl_DataGridView.Dock = DockStyle.Left;
            pnl_DataGridView.Location = new Point(0, 27);
            pnl_DataGridView.Name = "pnl_DataGridView";
            pnl_DataGridView.Size = new Size(541, 680);
            pnl_DataGridView.TabIndex = 12;
            // 
            // BurgerAppViewOrderDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(629, 707);
            Controls.Add(pnl_DataGridView);
            Controls.Add(btn_Back);
            Controls.Add(pnl_Title);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "BurgerAppViewOrderDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BurgerAppViewOrderDetails";
            Load += BurgerAppViewOrderDetails_Load;
            pnl_Title.ResumeLayout(false);
            pnl_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_OrderDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderDetailBindingSource).EndInit();
            pnl_DataGridView.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Title;
        private Label lbl_OrdersTitle;
        private Label lbl_Title;
        private Label lbl_OrderDetailsTitle;
        private Button btn_Back;
        private DataGridView dgv_OrderDetails;
        private Panel pnl_DataGridView;
        private BindingSource orderDetailBindingSource;
        private DataGridViewTextBoxColumn orderDetailIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    }
}