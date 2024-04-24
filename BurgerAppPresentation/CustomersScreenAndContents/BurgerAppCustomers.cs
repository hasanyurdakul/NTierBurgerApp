using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



using BurgerAppDataAccess;
using BurgerAppDomain;
using Microsoft.EntityFrameworkCore;



namespace BurgerAppPresentation
{
    public partial class BurgerAppCustomers : Form
    {
        AppDbContext _context = new AppDbContext();

        public BurgerAppCustomers()
        {
            InitializeComponent();

        }

        private void BurgerAppCustomers_Load(object sender, EventArgs e)
        {
            var customers = _context.Customers.ToList();
            dgv_Customers.AutoGenerateColumns = true;
            dgv_Customers.DataSource = customers;
            

        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            BurgerAppDashboard burgerAppDashboard = new BurgerAppDashboard();
            burgerAppDashboard.Show();


        }



        public void btn_EditCustomer_Click(object sender, EventArgs e)
        {
            BurgerAppEditSelectedCustomer burgerAppEditSelectedCustomer = new BurgerAppEditSelectedCustomer(GetCustomerId());
            burgerAppEditSelectedCustomer.Show();
            this.Hide();

        }

        public int GetCustomerId()
        {
            var selectedRow = dgv_Customers.SelectedRows[0];
            var customerId = (int)selectedRow.Cells[0].Value;
            return customerId;
        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            BurgerAppAddCustomer burgerAppAddCustomer = new BurgerAppAddCustomer();
            burgerAppAddCustomer.Show();
        }

        private void btn_RemoveCustomer_Click(object sender, EventArgs e)
        {
            BurgerAppRemoveCustomerWarning burgerAppRemoveCustomerWarning = new BurgerAppRemoveCustomerWarning(GetCustomerId());
            burgerAppRemoveCustomerWarning.Show();
            this.Hide();
        }

        private void btn_ViewCustomerDetails_Click(object sender, EventArgs e)
        {

        }


         













    }
}
