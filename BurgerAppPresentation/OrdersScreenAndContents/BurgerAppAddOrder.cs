using BurgerAppDataAccess;
using BurgerAppDataAccess.Configurations;
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
        Customer _customer;
        public BurgerAppAddOrder(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
        }

        public void BurgerAppAddOrder_Load(object sender, EventArgs e)
        {
            populateComboBox();
            populateImageList();
            removeButtonStateSetter();
            orderIdSetter();
            customerIdSetter();
            cmboxDefaultStateSetter();
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

        private void lv_OrderList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            removeButtonStateSetter();
        }

        private void btn_AddBasket_Click(object sender, EventArgs e)
        {
            lvOrderInserter();
            removeButtonStateSetter();
            totalPriceCalculator();
        }

        private void btn_RemoveBasket_Click(object sender, EventArgs e)
        {
            lvOrderRemover();
            removeButtonStateSetter();
            totalPriceCalculator();
        }

        private void btn_ConfirmOrder_Click(object sender, EventArgs e)
        {
            dbOrderInserter();
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
        private List<Sauce> selectedSaucesGetter()
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
        private List<string> selectedSaucesNamesGetter(List<Sauce> sauces)
        {
            List<string> sauceNames = new List<string>();

            foreach (Sauce sauce in sauces)
            {
                sauceNames.Add(sauce.SauceName);
            }
            return sauceNames;
        }
        private void lvOrderInserter()
        {
            var productName = cmbox_Products.SelectedItem.ToString();
            var sizeId = selectedSizeGetter();
            var sauces = selectedSaucesGetter();
            var sauceNames = selectedSaucesNamesGetter(sauces);
            ListViewItem item = new ListViewItem();
            item.Text = productName;
            item.SubItems.Add(sizeId);
            foreach (var sauceName in sauceNames)
            {
                item.SubItems.Add(sauceName);

            }
            lv_OrderList.Items.Add(item);
        }
        private void lvOrderRemover()
        {
            try
            {
                lv_OrderList.SelectedItems[0].Remove();

            }
            catch (Exception)
            {
                MessageBox.Show("You didn't select any order to remove!");
                throw;
            }
        }
        private List<Sauce> lvItemSaucesGetter()
        {
            List<Sauce> sauceList = new List<Sauce>();

            foreach (ListViewItem item in lv_OrderList.Items)
            {
                for (int i = 2; i < 5; i++)
                {


                    try
                    {
                        if (item.SubItems[i].Text.Length != 0)
                        {
                            var sauceName = item.SubItems[i].Text;
                            var sauce = _context.Sauces.Single(x => x.SauceName == sauceName);
                            sauceList.Add(sauce);
                        }
                    }
                    catch (Exception)
                    {

                        break;
                    }

                }
            }

            return sauceList;
        }
        private int orderCountGetter()
        {
            int orderListCount = 0;
            orderListCount = lv_OrderList.SelectedItems.Count;
            return orderListCount;

        }
        private void removeButtonStateSetter()
        {
            int orderCount = orderCountGetter();
            if (orderCount == 0)
            {
                btn_RemoveBasket.Enabled = false;
            }
            else
            {
                btn_RemoveBasket.Enabled = true;
            }
        }
        private void totalPriceCalculator()
        {
            int totalPrice = 0;

            foreach (ListViewItem item in lv_OrderList.Items)
            {
                Product product = _context.Products.FirstOrDefault(x => x.Name == item.Text);
                BurgerAppDomain.Size size = _context.Sizes.FirstOrDefault(x => x.SizeId == selectedSizeGetter());
                int unitPrice = product.UnitPrice;
                int sizePriceDifference = size.PriceDifference;
                int lvItemPrice = unitPrice + sizePriceDifference;
                totalPrice += lvItemPrice;

            }

            lbl_TotalPrice.Text = totalPrice.ToString();

        }
        private void orderIdSetter()
        {
            var latestOrder = _context.Orders.OrderBy(x => x.OrderId).LastOrDefault();
            var latestOrderId = latestOrder.OrderId;
            lbl_OrderId.Text = (latestOrderId += 1).ToString();
        }
        private void customerIdSetter()
        {
            lbl_CustomerId.Text = _customer.CustomerId.ToString();
        }
        private void dbOrderInserter()
        {
            Order order = new Order()
            {
                CustomerId = _customer.CustomerId,
                Status = "Preparing"
            };
            _context.Orders.Add(order);
            _context.SaveChanges();
            foreach (ListViewItem item in lv_OrderList.Items)
            {
                var product = _context.Products.FirstOrDefault(x => x.Name == item.Text);
                var sizeId = item.SubItems[1].Text;

                OrderDetail orderDetail = new OrderDetail();

                orderDetail.OrderId = order.OrderId;
                orderDetail.ProductId = product.ProductId;
                orderDetail.SizeId = sizeId;
                orderDetail.Sauces = lvItemSaucesGetter();
                _context.OrderDetails.Add(orderDetail);
            }
            _context.SaveChanges();
            MessageBox.Show("Order Created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            BurgerAppOrders burgerAppOrders = new BurgerAppOrders();
            burgerAppOrders.Show();
        }
        private void cmboxDefaultStateSetter()
        {
            cmbox_Products.SelectedItem = cmbox_Products.Items[0];
        }

    }
}
