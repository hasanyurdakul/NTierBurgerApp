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

namespace BurgerAppPresentation.ProductScreenAndContents
{
    public partial class BurgerAppRemoveProductWarning : Form
    {
        AppDbContext _context = new AppDbContext();
        Product _product;
        public BurgerAppRemoveProductWarning(Product product)
        {
            InitializeComponent();
            _product = product;
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {

            RemoveProduct();
            SuccessPopUp();
            this.Hide();
            BurgerAppProducts burgerAppProducts = new BurgerAppProducts();
            burgerAppProducts.Show();
        }
        public void RemoveProduct()
        {
            _context.Products.Remove(_product);
            _context.SaveChanges();
        }

        private void btn_Discard_Click(object sender, EventArgs e)
        {
            DiscardPopUp();
            this.Hide();
            BurgerAppProducts burgerAppProducts = new BurgerAppProducts();
            burgerAppProducts.Show();
        }

        private void SuccessPopUp()
        {
            MessageBox.Show("Deletion Succeeded!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DiscardPopUp()
        {
            MessageBox.Show("Deletion Canceled!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
