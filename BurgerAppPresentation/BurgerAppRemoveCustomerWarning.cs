using BurgerAppDataAccess;
using BurgerAppDomain;
using Microsoft.EntityFrameworkCore;
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
    public partial class BurgerAppRemoveCustomerWarning : Form
    {
        AppDbContext _context = new AppDbContext();
        public int _customerId;
        public Customer _customer;
        public BurgerAppRemoveCustomerWarning(int customerId)
        {
            InitializeComponent();
            _customerId = customerId;
        }

        public Customer GetCustomer(int customerId)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.CustomerId == _customerId);
            return customer;
        }

        private void BurgerAppRemoveCustomerWarning_Load(object sender, EventArgs e)
        {
            _customer = GetCustomer(_customerId);
        }
        private void btn_Discard_Click(object sender, EventArgs e)
        {
            DiscardPopUp();
            this.Hide();
            BurgerAppCustomers burgerAppCustomers = new BurgerAppCustomers();
            burgerAppCustomers.Show();
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            RemoveCustomer();
            SuccessPopUp();
            this.Hide();
            BurgerAppCustomers burgerAppCustomers = new BurgerAppCustomers();
            burgerAppCustomers.Show();
            
        }


        private void SuccessPopUp()
        {
            MessageBox.Show("Deletion Succeeded!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DiscardPopUp()
        {
            MessageBox.Show("Deletion Canceled!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void RemoveCustomer()
        {
            _context.Customers.Remove(_customer);

            //MessageBox.Show(_context.Entry(_customer).State.ToString());
            _context.SaveChanges();
        }

        
    }
}
