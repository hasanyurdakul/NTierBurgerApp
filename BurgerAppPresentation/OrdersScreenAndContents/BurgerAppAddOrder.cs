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
            cmbox_Products.SelectedItem = cmbox_Products.Items[0];
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
        

        private void btn_AddBasket_Click(object sender, EventArgs e)
        {
            lboxOrderInserter();
        }


        private void btn_RemoveBasket_Click(object sender, EventArgs e)
        {
            lboxOrderRemover();
        }



        private void btn_ConfirmOrder_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(lbl_OrderId.Text);
            var _order = _context.Orders.Single(x => x.OrderId == orderId);
            var _orderDetails = _context.OrderDetails.Single(x => x.OrderId == orderId);
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
        private void lboxOrderInserter()
        {
            string selectedProductName = cmbox_Products.SelectedItem.ToString();

            string receiptString = string.Empty;
            if (cmbox_Products.SelectedItem != null)
            {
                receiptString += selectedProductName;

            }
            else
            {
                MessageBox.Show("Please select a product from the list!");
            }
            if (rb_Small.Checked == true)
            {
                receiptString += " - Small Size ";
            }
            else if (rb_Medium.Checked == true)
            {
                receiptString += " - Medium Size ";
            }
            else if (rb_Large.Checked == true)
            {
                receiptString += " - Large Size ";
            }
            if (chbox_Ketchup.Checked == true)
            {
                receiptString += " - Ketchup ";
            }
            if (chbox_Mayonnaise.Checked == true)
            {
                receiptString += " - Mayonnaise ";
            }
            if (chbox_Mustard.Checked == true)
            {
                receiptString += " - Mustard ";
            }
            lbox_OrderList.Items.Add(receiptString);
        }
        private void lboxOrderRemover()
        {
            if (lbox_OrderList.SelectedItem != null)
            {
                var lboxSelectedItem = lbox_OrderList.SelectedItem;
                lbox_OrderList.Items.Remove(lboxSelectedItem);
            }
            else
            {
                MessageBox.Show("You don't have any orders to remove!");
            }
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

    }
}
