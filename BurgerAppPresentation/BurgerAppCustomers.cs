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
        public BurgerAppCustomers()
        {
            InitializeComponent();
        }



        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            BurgerAppDashboard burgerAppDashboard = new BurgerAppDashboard();
            burgerAppDashboard.Show();
            

        }

        private void BurgerAppCustomers_Load(object sender, EventArgs e)
        {
            AppDbContext dbContext = new AppDbContext();
            var customers = dbContext.Customers.ToList();
            dgv_Customers.AutoGenerateColumns = false;
            dgv_Customers.DataSource = customers;


        }

        public void btn_EditCustomer_Click(object sender, EventArgs e)
        {
            BurgerAppEditSelectedCustomer burgerAppEditSelectedCustomer = new BurgerAppEditSelectedCustomer();
            burgerAppEditSelectedCustomer.Show();
            this.Hide();
            // var selectedRow = dgv_Customers.SelectedRows[0];

        }
    }
}
