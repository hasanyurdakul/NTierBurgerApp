using BurgerAppDataAccess;
using BurgerAppPresentation.OrdersScreenAndContents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerAppPresentation
{
    public partial class BurgerAppOrders : Form
    {
        AppDbContext _context = new AppDbContext();
        public BurgerAppOrders()
        {
            InitializeComponent();
        }

        private void BurgerAppOrders_Load(object sender, EventArgs e)
        {
            var orders = _context.Orders.OrderByDescending(x=>x.OrderId).ToList();
            dgv_Orders.DataSource = orders;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            BurgerAppDashboard burgerAppDashboard = new BurgerAppDashboard();
            burgerAppDashboard.Show();
        }

        private void btn_AddOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            BurgerAppAskPhoneNumber burgerAppAskPhoneNumber = new BurgerAppAskPhoneNumber();
            burgerAppAskPhoneNumber.Show(); 
        }

        private void btn_RemoveOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            BurgerAppRemoveOrderWarning burgerAppRemoveOrderWarning = new BurgerAppRemoveOrderWarning(GetOrderId());
            burgerAppRemoveOrderWarning.Show();
        }

        private void btn_ViewOrderDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            BurgerAppViewOrderDetails burgerAppViewOrderDetails = new BurgerAppViewOrderDetails();
            burgerAppViewOrderDetails.Show();
        }

        private void btn_EditOrderStatus_Click(object sender, EventArgs e)
        {
            this.Hide();
            int orderId = int.Parse(dgv_Orders.SelectedCells[0].Value.ToString());
            BurgerAppEditOrderStatus burgerAppEditOrderStatus = new BurgerAppEditOrderStatus(orderId);
            burgerAppEditOrderStatus.Show();
        }
        public int GetOrderId()
        {
            var selectedRow = dgv_Orders.SelectedRows[0];
            var orderId = (int)selectedRow.Cells[0].Value;
            return orderId;
        }
    }
}
