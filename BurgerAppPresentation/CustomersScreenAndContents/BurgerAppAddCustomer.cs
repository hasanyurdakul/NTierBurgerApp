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
    public partial class BurgerAppAddCustomer : Form
    {
        AppDbContext _context = new AppDbContext();
        public BurgerAppAddCustomer()
        {
            InitializeComponent();
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            AddCustomer();
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

        public void AddCustomer()
        {
            Customer newCustomer = new Customer();
            newCustomer.FirstName = tbox_FirstName.Text.ToString();
            newCustomer.LastName = tbox_LastName.Text.ToString();
            newCustomer.Email = tbox_Email.Text.ToString();
            newCustomer.PhoneNumber = tbox_PhoneNumber.Text.ToString();
            newCustomer.Address = tbox_Adress.Text.ToString();
            _context.Customers.Add(newCustomer);
            //MessageBox.Show(_context.Entry(newCustomer).State.ToString());
            _context.SaveChanges();
        }

        private void SuccessPopUp()
        {
            MessageBox.Show("New Customer Added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DiscardPopUp()
        {
            MessageBox.Show("Insertion Discarded!", "Cancelled!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


    }
}
