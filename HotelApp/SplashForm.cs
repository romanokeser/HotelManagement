using System;
using System.Windows.Forms;

namespace HotelApp
{
    public partial class SplashForm : Form
    {
        private float startPoint = 0;

        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 4.5f;
            splashPB.Value = (int)startPoint;

            if (splashPB.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }
    }
}
