using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void clientBtn_Click(object sender, EventArgs e)
        {
            ClientInfo clientInfo = new ClientInfo();
            clientInfo.Show();
            this.Hide();
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            StaffInfo  staffInfo = new StaffInfo();
            staffInfo.Show();
            this.Hide();
        }

        private void roomsBtn_Click(object sender, EventArgs e)
        {
            RoomInfo roomInfo = new RoomInfo();
            roomInfo.Show();
            this.Hide();
        }

        private void reservationBtn_Click(object sender, EventArgs e)
        {
            ReservationInfo resInfo = new ReservationInfo();
            resInfo.Show();
            this.Hide();
        }
    }
}
