using BurgerAppDataAccess;
using BurgerAppDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerAppPresentation.OrdersScreenAndContents
{
    public partial class BurgerAppEditOrderStatus : Form
    {
        AppDbContext _context = new AppDbContext();
        int _orderId;
        Order _order;
        public BurgerAppEditOrderStatus(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
            _order = _context.Orders.FirstOrDefault(x => x.OrderId == _orderId);


        }

        private void BurgerAppEditOrderStatus_Load(object sender, EventArgs e)
        {
            var order = _context.Orders.FirstOrDefault(x => x.OrderId == _orderId);

            lbl_OrderId.Text = _orderId.ToString();
            cmbox_Status.Text = _order.Status;
        }



        private void btn_Discard_Click(object sender, EventArgs e)
        {
            this.Hide();
            BurgerAppOrders burgerAppOrders = new BurgerAppOrders();
            burgerAppOrders.Show();
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            _order.Status = cmbox_Status.Text;
            _context.SaveChanges();
            this.Hide();
            BurgerAppOrders burgerAppOrders = new BurgerAppOrders();
            burgerAppOrders.Show();
        }
    }
}
