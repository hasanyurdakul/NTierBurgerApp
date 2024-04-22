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

namespace BurgerAppPresentation
{
    public partial class BurgerAppOrders : Form
    {
        AppDbContext _context = new AppDbContext();
        public BurgerAppOrders()
        {
            InitializeComponent();
        }

        private void BurgerAppOrders_Load(object sender, EventArgs e)
        {
            var orders = _context.Orders.ToList();
            dgv_Orders.DataSource = orders; 
        }
    }
}
