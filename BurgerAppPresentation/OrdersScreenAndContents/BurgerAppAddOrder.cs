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
            removeButtonStateSetter();
        }

        private void cmbox_Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            pboxImageChanger();
            rtboxDescChanger();
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            BurgerAppOrders burgerAppOrders = new BurgerAppOrders();
            burgerAppOrders.Show();
        }


        private void btn_AddBasket_Click(object sender, EventArgs e)
        {
            lvOrderInserter();
            removeButtonStateSetter();

        }



        private void btn_RemoveBasket_Click(object sender, EventArgs e)
        {
            lvOrderRemover();
            removeButtonStateSetter();


        }

        private void btn_ConfirmOrder_Click(object sender, EventArgs e)
        {

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
        private int orderCountGetter()
        {
            int orderListCount = 0;
            orderListCount = lv_OrderList.Items.Count;
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
    }
}
