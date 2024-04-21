namespace BurgerAppPresentation
{
    partial class BurgerAppSplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer_Splash = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // timer_Splash
            // 
            timer_Splash.Interval = 25;
            timer_Splash.Tick += timer_Splash_Tick;
            // 
            // BurgerAppSplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SplashScreenImage;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(600, 600);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "BurgerAppSplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BurgerAppSplashScreen";
            Load += BurgerAppSplashScreen_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer_Splash;
    }
}