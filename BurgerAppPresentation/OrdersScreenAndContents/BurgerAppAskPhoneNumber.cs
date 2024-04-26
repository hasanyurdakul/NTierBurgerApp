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
    public partial class BurgerAppAskPhoneNumber : Form
    {
        AppDbContext _context = new AppDbContext();
        public BurgerAppAskPhoneNumber()
        {
            InitializeComponent();
        }

        private void btn_Discard_Click(object sender, EventArgs e)
        {
            this.Hide();
            BurgerAppOrders burgerAppOrders = new BurgerAppOrders();
            burgerAppOrders.Show();
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            var phoneNumber = tbox_PhoneNumber.Text;
            if (_context.Customers.FirstOrDefault(x => x.PhoneNumber == phoneNumber) != null)
            {
                Customer customer = _context.Customers.FirstOrDefault(x => x.PhoneNumber == phoneNumber);
                BurgerAppAddOrder burgerAppAddOrder = new BurgerAppAddOrder(customer);
                this.Hide();
                burgerAppAddOrder.Show();
            }
            else
            {
                MessageBox.Show("Customer not found. Please create one.");
                MessageBox.Show("Redirecting...");
                BurgerAppAddCustomer burgerAppAddCustomer = new BurgerAppAddCustomer();
                this.Hide();
                burgerAppAddCustomer.Show();
            }
        }
    }
}
