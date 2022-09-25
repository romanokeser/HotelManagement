using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp
{
    public partial class ReservationInfo : Form
    {
        DateTime today;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Romano\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");

        public ReservationInfo()
        {
            InitializeComponent();
            Populate();
        }

        private void ReservationInfo_Load(object sender, EventArgs e)
        {
            today = dateIn.Value;
            FillRoomCombo();
            FillClientCombo();
            Populate();
            dateLabel.Text = DateTime.Today.Day.ToString()+ "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();
        }

        private void dateIn_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(dateIn.Value, today);
            if (res < 0)
                MessageBox.Show("Wrong date for reservation");
        }

        private void dateOut_ValueChanged(object sender, EventArgs e)
        {
            int res = DateTime.Compare(dateOut.Value, today);
            if (res < 0)
                MessageBox.Show("Wrong dateout. Check once more");
        }

        private void UpdateRoomState()
        {
            conn.Open();

            string newState = "busy";
            string query = "UPDATE Room_tbl SET RoomFree = '" + newState
                + "' WHERE RoomId = " + Convert.ToInt32(roomIdCombobox.SelectedValue.ToString()) + ";";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Populate();
            FillRoomCombo();
        }

        private void UpdateRoomDelete()
        {
            conn.Open();

            string newState = "free";
            int roomId = Convert.ToInt32(ReservationGridView.SelectedRows[0].Cells[2].Value.ToString());

            string query = "UPDATE Room_tbl SET RoomFree = '" + newState
                + "' WHERE RoomId = " + roomId + ";";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Populate();
            FillRoomCombo();
        }

        private void addRoomBtn_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Reservation_tbl VALUES('"
                + reservationId.Text + "','"
                + clientNameCombobox.SelectedValue.ToString() + "','"
                + roomIdCombobox.SelectedValue.ToString() + "','"
                + dateIn.Value + "','"
                + dateOut.Value + "')", conn);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Reservation added succesfully");
            conn.Close();
            UpdateRoomState();
            Populate();
        }

        private void FillRoomCombo()
        {
            conn.Open();

            string roomState = "free";

            SqlCommand cmd = new SqlCommand("SELECT RoomId FROM Room_tbl WHERE RoomFree = '" + roomState + "'", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RoomId", typeof(int));
            dt.Load(rdr);

            roomIdCombobox.ValueMember = "RoomId";
            roomIdCombobox.DataSource = dt;
            conn.Close();
        }

        private void FillClientCombo()
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT ClientName FROM Client_tbl", conn);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("ClientName", typeof(string));
            dt.Load(rdr);

            clientNameCombobox.ValueMember = "ClientName";
            clientNameCombobox.DataSource = dt;
            conn.Close();
        }

        public void Populate()
        {
            conn.Open();

            string query = "SELECT * FROM Reservation_tbl";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReservationGridView.DataSource = ds.Tables[0];

            conn.Close();
        }

        private void ReservationGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            reservationId.Text = ReservationGridView.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void deleteRoomBtn_Click(object sender, EventArgs e)
        {
            if (reservationId.Text == "")
            {
                MessageBox.Show("Enter reservation to be deleted");
            }
            else
            {
                conn.Open();

                string query = "DELETE FROM Reservation_tbl WHERE ResId = " + reservationId.Text + "";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation succesfully deleted");
                conn.Close();
                UpdateRoomDelete();
                Populate();
            }

        }

        private void editRoomBtn_Click(object sender, EventArgs e)
        {
            if (reservationId.Text == "")
            {
                MessageBox.Show("Empty ResId, Enter the reservation ID");
            }
            else
            {
                conn.Open();

                string query = "UPDATE Reservation_tbl SET Client = '" + clientNameCombobox.SelectedValue.ToString()
                    + "', ResId = '" + roomIdCombobox.SelectedValue.ToString()
                    + "', DateIn= '" + dateIn.Value.ToString()
                    + "', DateOut= '" + dateOut.Value.ToString()
                    + "' WHERE ResId = " + reservationId.Text + ";";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation succesfully edited");
                conn.Close();
                Populate();
            }
        }

        private void roomSearchBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM Reservation_tbl WHERE ResId = '" + reservationId.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReservationGridView.DataSource = ds.Tables[0];

            conn.Close();
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
