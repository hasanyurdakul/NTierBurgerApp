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
    public partial class BurgerAppSplashScreen : Form
    {
        int timerCounter = 0;
        public BurgerAppSplashScreen()
        {
            InitializeComponent();
        }

        private void BurgerAppSplashScreen_Load(object sender, EventArgs e)
        {
            timer_Splash.Start();
        }

        private void timer_Splash_Tick(object sender, EventArgs e)
        {
            if (timerCounter != 100)
            {
                timerCounter++;
            }
            else if(timerCounter==100)
            {
                timer_Splash.Stop();
                BurgerAppDashboard burgerAppDashboard = new BurgerAppDashboard();
                this.Hide();
                burgerAppDashboard.Show();
            }
        }
    }
}
