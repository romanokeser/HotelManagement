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
        DateTime today;

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Romano\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");

        private Font boldFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
        private Font regularFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular);

        private bool _isTableSelected;

        public RoomInfo()
        {
            InitializeComponent();
            Populate();

            RoomsDropbox.Text = "Rooms";
            RoomsDropbox.SelectedIndex = 1;

            RoomGridView.CellClick += RoomGridView_CellClick;
            editBtn.Enabled = false;
        }

        private void RoomInfo_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();
        }

        /// Show content from grid view to textfields
        private void RoomGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            roomNumber.Text = RoomGridView.SelectedRows[0].Cells[0].Value.ToString();
            roomPhone.Text = RoomGridView.SelectedRows[0].Cells[1].Value.ToString();
            roomsState.Text = RoomGridView.SelectedRows[0].Cells[2].Value.ToString();
            _isTableSelected = true;
            editBtn.Enabled = true;
        }

        /// Subscribe to room search event
        private void RoomsDropbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoomsDropbox.TextChanged += roomSearchBtn_Click;
            RoomsDropbox.SelectedIndexChanged += roomSearchBtn_Click;
        }

        /// <summary>
        /// Refresh the grid view
        /// Called after each action add/edit/delete/on show view
        /// </summary>
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

        private void roomSearchBtn_Click(object sender, EventArgs e)
        {
            RoomsDropbox.Font = regularFont;
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
                RoomsDropbox.Font = boldFont;
            }
        }

        private void refreshImageBtn_Click(object sender, EventArgs e)
        {
            RoomsDropbox.Text = "Rooms";
            Populate();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (roomPhone.Text.Length == 0)
            {
                roomsNumberLabel.Font = boldFont;
            }
            else
            {
                conn.Open();
                roomsNumberLabel.Font = regularFont;
                string isFree;
                if (yesRadio.Checked == true)
                    isFree = "busy";
                else
                    isFree = "free";

                SqlCommand cmd = new SqlCommand("INSERT INTO Room_tbl VALUES('"
                    + roomPhone.Text + "','"
                    + isFree + "')", conn);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Client added succesfully");
                conn.Close();
                Populate();
            }
        }

        //todo: check if table is selected => then enable the button
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (!_isTableSelected)
            {
                roomsNumberLabel.Font = boldFont;
            }
            else
            {
                roomsNumberLabel.Font = regularFont;
                string isFree;
                if (yesRadio.Checked == true)
                    isFree = "busy";
                else
                    isFree = "free";

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
        }

        //todo: check if table is selected => then enable the button
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = "DELETE FROM Room_tbl WHERE RoomId = " + roomNumber.Text + "";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff succesfully deleted");
            conn.Close();
            Populate();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }


    }
}
