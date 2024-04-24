using BurgerAppDataAccess;
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

        private void BurgerAppAddOrder_Load(object sender, EventArgs e)
        {
            populateComboBox();
            populateImageList();
        }

        private void cmbox_Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            pboxImageChanger();
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
