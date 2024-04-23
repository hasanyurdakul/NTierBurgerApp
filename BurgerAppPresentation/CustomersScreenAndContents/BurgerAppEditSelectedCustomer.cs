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

namespace BurgerAppPresentation
{
    public partial class BurgerAppEditSelectedCustomer : Form
    {
        AppDbContext _context = new AppDbContext();
        public int _customerId;
        public Customer _customer;

        public BurgerAppEditSelectedCustomer(int customerId)
        {
            InitializeComponent();
            _customerId = customerId;
        }
        public Customer GetCustomer(int customerId)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.CustomerId == _customerId);
            return customer;
        }
        private void BurgerAppEditSelectedCustomer_Load(object sender, EventArgs e)
        {
            _customer = GetCustomer(_customerId);
            tbox_FirstName.Text = _customer.FirstName;
            tbox_LastName.Text = _customer.LastName;
            tbox_Email.Text = _customer.Email;
            tbox_PhoneNumber.Text = _customer.PhoneNumber;
            tbox_Adress.Text = _customer.Address;

        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            CustomerApplyChanges();
            SuccessPopUp();
            this.Hide();
            BurgerAppCustomers burgerAppCustomers = new BurgerAppCustomers();
            burgerAppCustomers.Show();
        }

        private void btn_Discard_Click(object sender, EventArgs e)
        {
            DiscardPopUp();
            this.Hide();
            BurgerAppCustomers burgerAppCustomers = new BurgerAppCustomers();
            burgerAppCustomers.Show();
        }

     

        public void CustomerApplyChanges()
        {
            _customer.FirstName = tbox_FirstName.Text.ToString();
            _customer.LastName = tbox_LastName.Text.ToString();
            _customer.Email = tbox_Email.Text.ToString();
            _customer.PhoneNumber = tbox_PhoneNumber.Text.ToString();
            _customer.Address = tbox_Adress.Text.ToString();
            //MessageBox.Show(_context.Entry(_customer).State.ToString());
            _context.SaveChanges();
        }

        private void SuccessPopUp()
        {
            MessageBox.Show("Changes Applied!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DiscardPopUp()
        {
            MessageBox.Show("Changes Discarded!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
