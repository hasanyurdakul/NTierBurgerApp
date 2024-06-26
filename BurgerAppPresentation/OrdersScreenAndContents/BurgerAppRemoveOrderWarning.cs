﻿using BurgerAppDataAccess;
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

namespace BurgerAppPresentation
{
    public partial class BurgerAppRemoveOrderWarning : Form
    {
        AppDbContext _context = new AppDbContext();
        int _orderId;
        Order _order;
        public BurgerAppRemoveOrderWarning(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
        }

        private void BurgerAppRemoveOrderWarning_Load(object sender, EventArgs e)
        {
            _order = GetOrder(_orderId);    
        }
        public Order GetOrder(int customerId)
        {
            var order = _context.Orders.FirstOrDefault(x => x.OrderId == _orderId);
            return order;
        }
        private void btn_Apply_Click(object sender, EventArgs e)
        {
            SuccessPopUp();

            this.Hide();
            BurgerAppOrders burgerAppOrders = new BurgerAppOrders();
            burgerAppOrders.Show();
        }

        private void btn_Discard_Click(object sender, EventArgs e)
        {
            DiscardPopUp();

            this.Hide();
            BurgerAppOrders burgerAppOrders = new BurgerAppOrders();
            burgerAppOrders.Show();
        }

        private void SuccessPopUp()
        {
            MessageBox.Show("Deletion Succeeded!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DiscardPopUp()
        {
            MessageBox.Show("Deletion Canceled!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void RemoveOrder()
        {
            _context.Remove(_order);
            _context.SaveChanges();
        }

    }
}
