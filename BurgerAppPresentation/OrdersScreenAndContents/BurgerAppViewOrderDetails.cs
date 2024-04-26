using BurgerAppDataAccess;
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
    public partial class BurgerAppViewOrderDetails : Form
    {
        AppDbContext _context = new AppDbContext();
        public BurgerAppViewOrderDetails()
        {
            InitializeComponent();
        }

        private void BurgerAppViewOrderDetails_Load(object sender, EventArgs e)
        {
            var orderDetails = _context.OrderDetails.ToList();
            dgv_OrderDetails.DataSource = orderDetails;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            BurgerAppOrders burgerAppOrders = new BurgerAppOrders();    
            burgerAppOrders.Show(); 
        }
    }
}
