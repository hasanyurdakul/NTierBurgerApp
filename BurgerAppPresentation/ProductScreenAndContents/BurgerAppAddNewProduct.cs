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
    public partial class BurgerAppAddNewProduct : Form
    {
        AppDbContext _context = new AppDbContext();
        public BurgerAppAddNewProduct()
        {
            InitializeComponent();
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            AddProduct();
            SuccessPopUp();
            this.Hide();
            BurgerAppProducts burgerAppProducts = new BurgerAppProducts();
            burgerAppProducts.Show();
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
            MessageBox.Show("New Product Added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DiscardPopUp()
        {
            MessageBox.Show("Insertion Discarded!", "Cancelled!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void AddProduct()
        {
            Product newProduct = new Product();
            newProduct.UnitPrice = int.Parse(tbox_UnitPrice.Text.Trim(trimChars: '_'));
            newProduct.Name = tbox_ProductName.Text;
            newProduct.Description = tbox_Description.Text;
            _context.Products.Add(newProduct);
            _context.SaveChanges();
        }
    }
}
