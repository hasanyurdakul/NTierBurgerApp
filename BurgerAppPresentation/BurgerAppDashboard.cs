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
    public partial class BurgerAppDashboard : Form
    {
        public BurgerAppDashboard()
        {
            InitializeComponent();
            timer_Date.Start();
            updateDateTime();
        }

        private void updateDateTime()
        {
            DateTime dateTime = DateTime.Now;
            lbl_Date.Text = dateTime.ToString("dd/MM/yyyy HH:mm:ss").Trim();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void timer_Date_Tick(object sender, EventArgs e)
        {
            updateDateTime();
        }

        private void btn_Customers_Click(object sender, EventArgs e)
        {
            BurgerAppCustomers burgerAppCustomers = new BurgerAppCustomers();
            this.Hide();
            burgerAppCustomers.Show();
        }

        private void btn_Orders_Click(object sender, EventArgs e)
        {
            this.Hide();
            BurgerAppOrders burgerAppOrders = new BurgerAppOrders();
            burgerAppOrders.Show();

        }
    }
}
