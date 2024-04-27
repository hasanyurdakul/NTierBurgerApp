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

namespace BurgerAppPresentation.ProductScreenAndContents
{
    public partial class BurgerAppEditSelectedProduct : Form
    {
        AppDbContext _context = new AppDbContext();
        int _productId;
        Product _product;
        public BurgerAppEditSelectedProduct(int productId)
        {
            InitializeComponent();
            _productId = productId;
        }
        public Product GetProduct(int productId)
        {
            var product = _context.Products.FirstOrDefault(c => c.ProductId == _productId);
            return product;
        }
        public BurgerAppEditSelectedProduct()
        {
            InitializeComponent();
        }

        private void BurgerAppEditSelectedProduct_Load(object sender, EventArgs e)
        {
            _product = GetProduct(_productId);
            tbox_Description.Text = _product.Description;
            tbox_ProductName.Text = _product.Name;
            tbox_UnitPrice.Text = _product.UnitPrice.ToString();
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            ProductApplyChanges();
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

        public void ProductApplyChanges()
        {

            _product.Description = tbox_Description.Text;
            _product.Name = tbox_ProductName.Text;
            _product.UnitPrice = Convert.ToInt32(tbox_UnitPrice.Text);
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
