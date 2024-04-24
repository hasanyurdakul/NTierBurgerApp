using BurgerAppDataAccess;
using BurgerAppDomain;
using BurgerAppPresentation.Properties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerAppPresentation
{
    public partial class BurgerAppAddOrder : Form
    {
        AppDbContext _context = new AppDbContext();
        public BurgerAppAddOrder()
        {
            InitializeComponent();
        }

        public void BurgerAppAddOrder_Load(object sender, EventArgs e)
        {
            populateComboBox();
            populateImageList();
            var _order = GenerateNewOrder();
            lbl_OrderId.Text = _order.OrderId.ToString();
        }

        private void cmbox_Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            pboxImageChanger();
            rtboxDescChanger();
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            BurgerAppOrders burgerAppOrders = new BurgerAppOrders();
            burgerAppOrders.Show();
        }
        private void populateComboBox()
        {
            var productNames = _context.Products.Select(x => x.Name).ToList();
            foreach (var i in productNames)
            {
                cmbox_Products.Items.Add(i);
            }
        }
        private void populateImageList()
        {
            var resourceSet = ProductImages.ResourceManager.GetResourceSet(CultureInfo.InvariantCulture, true, false);

            if (resourceSet != null)
            {
                foreach (DictionaryEntry entry in resourceSet)
                {
                    var value = entry.Value as Bitmap; //only get images
                    if (value != null)
                    {
                        imgList_Products.Images.Add((string)entry.Key, value);
                    }
                }
            };
        }
        private void pboxImageChanger()
        {
            string selectedProductName = cmbox_Products.SelectedItem.ToString();
            if (imgList_Products.Images.ContainsKey(selectedProductName))
            {
                pbox_ProductImage.Image = imgList_Products.Images[selectedProductName!];

            }
            else
            {
                pbox_ProductImage.Image = pbox_ProductImage.ErrorImage;
            }
        }
        private void rtboxDescChanger()
        {
            if (cmbox_Products.SelectedItem == null)
            {
                string placeholderText = "Select an item to view description";
                rtbox_Desc.Text = placeholderText;

            }
            else
            {
                string selectedProductName = cmbox_Products.SelectedItem.ToString();
                var product = _context.Products.Single(x => x.Name == selectedProductName);
                string productDesc = product.Description;
                rtbox_Desc.Text = productDesc;

            }
        }
        public Order GenerateNewOrder()
        {
            Order _order = new Order()
            {
                CustomerId = 1,
            };
            _context.Orders.Add(_order);
            _context.SaveChanges();
            return _order;
        }
    }
}
