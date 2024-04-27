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

namespace BurgerAppPresentation.ProductScreenAndContents
{
    public partial class BurgerAppProducts : Form
    {
        AppDbContext _context = new AppDbContext();
        public BurgerAppProducts()
        {
            InitializeComponent();
        }

        private void BurgerAppProducts_Load(object sender, EventArgs e)
        {
            var products = _context.Products.ToList();
            dgv_Products.DataSource = products;
        }




        private void btn_RemoveProduct_Click(object sender, EventArgs e)
        {
            var productId = GetProductId();
            var product = _context.Products.FirstOrDefault(x => x.ProductId == productId);
            this.Hide();
            BurgerAppRemoveProductWarning burgerAppRemoveProductWarning = new BurgerAppRemoveProductWarning(product);
            burgerAppRemoveProductWarning.Show();
        }

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            BurgerAppAddNewProduct burgerAppAddNewProduct = new BurgerAppAddNewProduct();
            burgerAppAddNewProduct.Show();
        }

        private void btn_EditProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            int productId = GetProductId();

            BurgerAppEditSelectedProduct burgerAppEditSelectedProduct = new BurgerAppEditSelectedProduct(productId);
            burgerAppEditSelectedProduct.Show();
        }

        public int GetProductId()
        {
            var selectedRow = dgv_Products.SelectedRows[0];
            var productId = (int)selectedRow.Cells[0].Value;
            return productId;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            BurgerAppDashboard burgerAppDashboard = new BurgerAppDashboard();
            burgerAppDashboard.Show();
        }
    }
}
