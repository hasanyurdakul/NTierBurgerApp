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
    public partial class BurgerAppDashboard : Form
    {
        public BurgerAppDashboard()
        {
            InitializeComponent();
            timer_Date.Start();
            updateDateTime();
        }

        private void updateDateTime()
        {
            DateTime dateTime = DateTime.Now;
            lbl_Date.Text = dateTime.ToString("dd/MM/yyyy HH:mm").Trim();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_Date_Tick(object sender, EventArgs e)
        {
            updateDateTime();
        }
    }
}
