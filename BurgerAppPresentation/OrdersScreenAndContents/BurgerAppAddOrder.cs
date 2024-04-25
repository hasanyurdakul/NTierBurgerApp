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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BurgerAppPresentation
{
    public partial class BurgerAppAddOrder : Form
    {
        AppDbContext _context = new AppDbContext();
        Order order;
        public BurgerAppAddOrder()
        {
            InitializeComponent();
        }

        public void BurgerAppAddOrder_Load(object sender, EventArgs e)
        {
            populateComboBox();
            populateImageList();
            var _order = GenerateNewOrder();
            order = _order;
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
            var productName = cmbox_Products.SelectedItem.ToString();
            var productId = _context.Products.Where(x => x.Name == productName).Select(x => x.ProductId).SingleOrDefault();
            
            OrderDetail od = new OrderDetail();
            od.OrderId = order.OrderId;
            od.ProductId = productId;
            od.SizeId = selectedSizeGetter();
            od.Sauces = (ICollection<Sauce>)selectedSaucesGetter();
            try
            {
                _context.OrderDetails.Add(od);
                _context.SaveChanges();


            }
            catch (Exception)
            {

                MessageBox.Show("Test");
            }

            lboxOrderInserter(od.OrderId, od.ProductId, od.SizeId, od.Sauces);

        }


        private void btn_RemoveBasket_Click(object sender, EventArgs e)
        {
            lboxOrderRemover();
            string productName = cmbox_Products.SelectedItem.ToString();
            int orderId = Convert.ToInt32(lbl_OrderId.Text);
            var product = _context.Products.Where(x => x.Name == productName).FirstOrDefault();
            var productId = product.ProductId;
            var deletedOrderDetail = _context.OrderDetails.Where(x => x.OrderId == orderId && x.ProductId==productId).FirstOrDefault();
            _context.OrderDetails.Remove(deletedOrderDetail);
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
        private void lboxOrderInserter(int OrderId, int ProductId, string SizeId, ICollection<Sauce> Sauces)
        {
            string selectedSauces = string.Empty;
            if (chbox_Ketchup.Checked == false && chbox_Mayonnaise.Checked == false && chbox_Mustard.Checked == false)
            {
                selectedSauces = "NONE";
            }
            else
            {
                foreach (var sauce in Sauces)
                {
                    selectedSauces += $"{sauce.SauceName},";
                }
            }
            var product = _context.Products.FirstOrDefault(x => x.ProductId == ProductId);
            var size = _context.Sizes.FirstOrDefault(x => x.SizeId == SizeId);

            string listItem = $"Product: {product.Name}\tSize: {SizeId}\tSelected Sauces: {selectedSauces}";
            lbox_OrderList.Items.Add(listItem);
            //string selectedProductName = cmbox_Products.SelectedItem.ToString();
            //            string receiptString = string.Empty;
            //if (cmbox_Products.SelectedItem != null)
            //{
            //    receiptString += selectedProductName;
            //                }
            //else
            //{
            //    MessageBox.Show("Please select a product from the list!");
            //}
            //if (rb_Small.Checked == true)
            //{
            //    receiptString += " - Small Size ";
            //}
            //else if (rb_Medium.Checked == true)
            //{
            //    receiptString += " - Medium Size ";
            //}
            //else if (rb_Large.Checked == true)
            //{
            //    receiptString += " - Large Size ";
            //}
            //if (chbox_Ketchup.Checked == true)
            //{
            //    receiptString += " - Ketchup ";
            //}
            //if (chbox_Mayonnaise.Checked == true)
            //{
            //    receiptString += " - Mayonnaise ";
            //}
            //if (chbox_Mustard.Checked == true)
            //{
            //    receiptString += " - Mustard ";
            //}
            //lbox_OrderList.Items.Add(receiptString);
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
                MessageBox.Show("You didn't select any order to remove!");
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
        private string selectedSizeGetter()
        {
            string selectedSize;
            switch (true)
            {
                case bool _ when rb_Small.Checked:
                    selectedSize = "S";
                    return selectedSize;

                case bool _ when rb_Medium.Checked:
                    selectedSize = "M";
                    return selectedSize;
                case bool _ when rb_Large.Checked:
                    selectedSize = "L";
                    return selectedSize;
                default:
                    return null;
            }

        }
        private ICollection selectedSaucesGetter()
        {
            List<Sauce> sauceList = new List<Sauce>();
            if (chbox_Ketchup.Checked == true)
            {
                var ketchup = _context.Sauces.FirstOrDefault(x => x.SauceName == chbox_Ketchup.Text);
                sauceList.Add(ketchup);
            }
            if (chbox_Mayonnaise.Checked == true)
            {
                var mayonnaise = _context.Sauces.FirstOrDefault(x => x.SauceName == chbox_Mayonnaise.Text);
                sauceList.Add(mayonnaise);

            }
            if (chbox_Mustard.Checked == true)
            {
                var mustard = _context.Sauces.FirstOrDefault(x => x.SauceName == chbox_Mustard.Text); sauceList.Add(mustard);


            }
            return sauceList;
        }

    }
}
