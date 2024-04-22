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
        public BurgerAppEditSelectedCustomer()
        {
            InitializeComponent();
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes Applied!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            BurgerAppCustomers burgerAppCustomers = new BurgerAppCustomers();
            burgerAppCustomers.Show();
        }

        private void btn_Discard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes Discarded!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Hide();
            BurgerAppCustomers burgerAppCustomers = new BurgerAppCustomers();
            burgerAppCustomers.Show();
        }
    }
}
