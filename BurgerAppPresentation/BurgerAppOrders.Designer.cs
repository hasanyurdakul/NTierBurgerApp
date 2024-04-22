namespace BurgerAppPresentation
{
    partial class BurgerAppOrders
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
            pnl_Title = new Panel();
            lbl_OrdersTitle = new Label();
            lbl_Title = new Label();
            pnl_DataGridView = new Panel();
            dgv_Orders = new DataGridView();
            orderIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderBindingSource = new BindingSource(components);
            btn_AddOrder = new Button();
            btn_RemoveOrder = new Button();
            btn_ViewOrderDetails = new Button();
            btn_Back = new Button();
            pnl_Title.SuspendLayout();
            pnl_DataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Orders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pnl_Title
            // 
            pnl_Title.BackColor = Color.FromArgb(255, 60, 47);
            pnl_Title.Controls.Add(lbl_OrdersTitle);
            pnl_Title.Controls.Add(lbl_Title);
            pnl_Title.Dock = DockStyle.Top;
            pnl_Title.Location = new Point(0, 0);
            pnl_Title.Name = "pnl_Title";
            pnl_Title.Size = new Size(922, 27);
            pnl_Title.TabIndex = 3;
            // 
            // lbl_OrdersTitle
            // 
            lbl_OrdersTitle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_OrdersTitle.AutoSize = true;
            lbl_OrdersTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_OrdersTitle.ForeColor = Color.FromArgb(14, 14, 14);
            lbl_OrdersTitle.Location = new Point(614, 1);
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
            lbl_Title.Location = new Point(1530, 1);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(346, 25);
            lbl_Title.TabIndex = 12;
            lbl_Title.Text = "WISSEN BURGER COMS - CUSTOMERS";
            // 
            // pnl_DataGridView
            // 
            pnl_DataGridView.BackColor = Color.Lime;
            pnl_DataGridView.Controls.Add(dgv_Orders);
            pnl_DataGridView.Dock = DockStyle.Left;
            pnl_DataGridView.Location = new Point(0, 27);
            pnl_DataGridView.Name = "pnl_DataGridView";
            pnl_DataGridView.Size = new Size(441, 745);
            pnl_DataGridView.TabIndex = 4;
            // 
            // dgv_Orders
            // 
            dgv_Orders.AllowUserToAddRows = false;
            dgv_Orders.AllowUserToDeleteRows = false;
            dgv_Orders.AutoGenerateColumns = false;
            dgv_Orders.BorderStyle = BorderStyle.None;
            dgv_Orders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Orders.Columns.AddRange(new DataGridViewColumn[] { orderIdDataGridViewTextBoxColumn, orderDateDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, customerIdDataGridViewTextBoxColumn });
            dgv_Orders.DataSource = orderBindingSource;
            dgv_Orders.Dock = DockStyle.Fill;
            dgv_Orders.Location = new Point(0, 0);
            dgv_Orders.Name = "dgv_Orders";
            dgv_Orders.ReadOnly = true;
            dgv_Orders.Size = new Size(441, 745);
            dgv_Orders.TabIndex = 0;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(BurgerAppDomain.Order);
            // 
            // btn_AddOrder
            // 
            btn_AddOrder.Anchor = AnchorStyles.Right;
            btn_AddOrder.BackColor = Color.FromArgb(255, 60, 47);
            btn_AddOrder.BackgroundImageLayout = ImageLayout.None;
            btn_AddOrder.Cursor = Cursors.Hand;
            btn_AddOrder.FlatAppearance.BorderSize = 0;
            btn_AddOrder.FlatStyle = FlatStyle.Flat;
            btn_AddOrder.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddOrder.ForeColor = Color.FromArgb(14, 14, 14);
            btn_AddOrder.Image = Properties.Resources.Plus;
            btn_AddOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btn_AddOrder.Location = new Point(453, 51);
            btn_AddOrder.Name = "btn_AddOrder";
            btn_AddOrder.Size = new Size(457, 115);
            btn_AddOrder.TabIndex = 6;
            btn_AddOrder.Text = "Add New Order";
            btn_AddOrder.TextAlign = ContentAlignment.MiddleRight;
            btn_AddOrder.UseVisualStyleBackColor = false;
            // 
            // btn_RemoveOrder
            // 
            btn_RemoveOrder.Anchor = AnchorStyles.Right;
            btn_RemoveOrder.BackColor = Color.FromArgb(255, 60, 47);
            btn_RemoveOrder.BackgroundImageLayout = ImageLayout.None;
            btn_RemoveOrder.Cursor = Cursors.Hand;
            btn_RemoveOrder.FlatAppearance.BorderSize = 0;
            btn_RemoveOrder.FlatStyle = FlatStyle.Flat;
            btn_RemoveOrder.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_RemoveOrder.ForeColor = Color.FromArgb(14, 14, 14);
            btn_RemoveOrder.Image = Properties.Resources.Remove;
            btn_RemoveOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btn_RemoveOrder.Location = new Point(453, 187);
            btn_RemoveOrder.Name = "btn_RemoveOrder";
            btn_RemoveOrder.Size = new Size(457, 115);
            btn_RemoveOrder.TabIndex = 7;
            btn_RemoveOrder.Text = "Remove Order";
            btn_RemoveOrder.TextAlign = ContentAlignment.MiddleRight;
            btn_RemoveOrder.UseVisualStyleBackColor = false;
            // 
            // btn_ViewOrderDetails
            // 
            btn_ViewOrderDetails.Anchor = AnchorStyles.Right;
            btn_ViewOrderDetails.BackColor = Color.FromArgb(255, 60, 47);
            btn_ViewOrderDetails.BackgroundImageLayout = ImageLayout.None;
            btn_ViewOrderDetails.Cursor = Cursors.Hand;
            btn_ViewOrderDetails.FlatAppearance.BorderSize = 0;
            btn_ViewOrderDetails.FlatStyle = FlatStyle.Flat;
            btn_ViewOrderDetails.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ViewOrderDetails.ForeColor = Color.FromArgb(14, 14, 14);
            btn_ViewOrderDetails.Image = Properties.Resources.View;
            btn_ViewOrderDetails.ImageAlign = ContentAlignment.MiddleLeft;
            btn_ViewOrderDetails.Location = new Point(453, 322);
            btn_ViewOrderDetails.Name = "btn_ViewOrderDetails";
            btn_ViewOrderDetails.Size = new Size(457, 115);
            btn_ViewOrderDetails.TabIndex = 8;
            btn_ViewOrderDetails.Text = "View Order\r\nDetails\r\n";
            btn_ViewOrderDetails.TextAlign = ContentAlignment.MiddleRight;
            btn_ViewOrderDetails.UseVisualStyleBackColor = false;
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
            btn_Back.Location = new Point(846, 696);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(64, 64);
            btn_Back.TabIndex = 9;
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // BurgerAppOrders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(14, 14, 14);
            ClientSize = new Size(922, 772);
            Controls.Add(btn_Back);
            Controls.Add(btn_ViewOrderDetails);
            Controls.Add(btn_RemoveOrder);
            Controls.Add(btn_AddOrder);
            Controls.Add(pnl_DataGridView);
            Controls.Add(pnl_Title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BurgerAppOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BurgerAppOrders";
            Load += BurgerAppOrders_Load;
            pnl_Title.ResumeLayout(false);
            pnl_Title.PerformLayout();
            pnl_DataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Orders).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Title;
        private Label lbl_Title;
        private Label lbl_OrdersTitle;
        private Panel pnl_DataGridView;
        private DataGridView dgv_Orders;
        private BindingSource orderBindingSource;
        private DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private Button btn_AddOrder;
        private Button btn_RemoveOrder;
        private Button btn_ViewOrderDetails;
        private Button btn_Back;
    }
}