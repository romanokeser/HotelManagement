using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelApp
{
    public partial class RoomInfo : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Romano\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");


        public RoomInfo()
        {
            InitializeComponent();
            Populate();
        }

        private void addRoomBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string isFree;
            if (yesRadio.Checked == true)
                isFree = "free";
            else
                isFree = "busy";

            //if (noRadio.Checked == true)
            //    isFree = "free";
            //else
            //    isFree = "busy";

            SqlCommand cmd = new SqlCommand("INSERT INTO Room_tbl VALUES('"
                //+ roomNumber.Text + "','"
                + roomPhone.Text + "','"
                + isFree + "')", conn);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Client added succesfully");
            conn.Close();
            Populate();
        }

        public void Populate()
        {
            conn.Open();

            string query = "SELECT * FROM Room_tbl";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            RoomGridView.DataSource = ds.Tables[0];

            conn.Close();
        }

        private void RoomGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            roomNumber.Text = RoomGridView.SelectedRows[0].Cells[0].Value.ToString();
            roomPhone.Text = RoomGridView.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void deleteRoomBtn_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = "DELETE FROM Room_tbl WHERE RoomId = " + roomNumber.Text + "";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff succesfully deleted");
            conn.Close();
            Populate();
        }

        private void editRoomBtn_Click(object sender, EventArgs e)
        {
            string isFree;
            if (yesRadio.Checked == true)
                isFree = "free";
            else
                isFree = "busy";

            conn.Open();

            string query = "UPDATE Room_tbl SET RoomPhone = '" + roomPhone.Text
                + "', RoomFree = '" + isFree
                + "' WHERE RoomId = " + roomNumber.Text + ";";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff succesfully edited");
            conn.Close();
            Populate();
        }

        private void roomSearchBtn_Click(object sender, EventArgs e)
        {
            RoomsDropbox.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular);
            if (RoomsDropbox.SelectedItem != null)
            {
                conn.Open();
                string query = "SELECT * FROM Room_tbl WHERE RoomFree = '" + RoomsDropbox.SelectedItem.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                RoomGridView.DataSource = ds.Tables[0];
                conn.Close();
            }
            else
            {
                RoomsDropbox.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
            }
            

        }

        private void refreshImageBtn_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
