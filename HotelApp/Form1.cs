using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelApp
{
    public partial class LoginForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Romano\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");
        public LoginForm()
        {
            InitializeComponent();
        }

        #region Functions

        //Checks user and pass
        private void LoginToDb()
        {
            string loginSqlString = "SELECT COUNT(*) FROM Staff_tbl WHERE StaffName='" + userTextbox.Text + "' AND StaffPassword='" + passTexbox.Text + "'";
            conn.Open();

            SqlDataAdapter sda = new SqlDataAdapter(loginSqlString, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                MainForm mf = new MainForm();
                mf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password");
            }
            conn.Close();
        }

        #endregion

        private void loginBtnNew_Click(object sender, EventArgs e)
        {
            LoginToDb();
        }

        

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
