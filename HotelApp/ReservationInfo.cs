using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HotelApp
{
    public partial class ReservationInfo : Form
    {
        DateTime today;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Romano\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");

        private Font boldFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
        private Font regularFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular);

        public ReservationInfo()
        {
            InitializeComponent();
            Populate();

            searchBtn.Enabled = false;
            editBtn.Enabled = false;

            ReservationGridView.CellClick += ReservationGridView_CellContentClick;
            reservationSearchbox.MouseClick += ReservationSearchbox_MouseClick;

            //Defines columns width
            ReservationGridView.Columns[0].Width = 50;
            ReservationGridView.Columns[2].Width = 50;
        }

        #region Functions 
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

        private void RefreshContent()
        {
            Populate();
            reservationSearchbox.Text = "";
        }

        private void InsertToDb()
        {
            clientNameLabel.Font = regularFont;

            if (string.IsNullOrEmpty(clientNameCombobox.Text))
            {
                clientNameLabel.Font = boldFont;
                return;
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Reservation_tbl VALUES('"
                    //+ reservationId.Text + "','"
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
                catch (Exception)
                {
                    conn.Close();
                    clientNameLabel.Font = boldFont;
                }
            }

            //conn.Open();

            //SqlCommand cmd = new SqlCommand("INSERT INTO Reservation_tbl VALUES('"
            //    //+ reservationId.Text + "','"
            //    + clientNameCombobox.SelectedValue.ToString() + "','"
            //    + roomIdCombobox.SelectedValue.ToString() + "','"
            //    + dateIn.Value + "','"
            //    + dateOut.Value + "')", conn);

            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Reservation added succesfully");
            //conn.Close();
            //UpdateRoomState();
            //Populate();
        }

        //Fills fill rooms combo box with db content
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

        //Fills client combo box with db content
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

        private void DeleteFromDb()
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

        private void SearchDb()
        {
            conn.Open();
            string query = "SELECT * FROM Reservation_tbl WHERE Client = '" + reservationSearchbox.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ReservationGridView.DataSource = ds.Tables[0];

            conn.Close();
        }

        private void EditDb()
        {
            if (reservationId.Text == "")
            {
                MessageBox.Show("Empty ResId, Enter the reservation ID");
            }
            else
            {
                conn.Open();
                string query = "UPDATE Reservation_tbl SET Client = '" + clientNameCombobox.SelectedValue.ToString()
                    //+ "', ResId = '" + roomIdCombobox.SelectedValue.ToString()
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

        private void GoBack()
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        #endregion

        #region Components

        private void ReservationGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            reservationId.Text = ReservationGridView.SelectedRows[0].Cells[0].Value.ToString();
            clientNameCombobox.Text = ReservationGridView.SelectedRows[0].Cells[1].Value.ToString();
            roomIdCombobox.Text = ReservationGridView.SelectedRows[0].Cells[2].Value.ToString();

            dateIn.Value = Convert.ToDateTime(ReservationGridView.SelectedRows[0].Cells[3].Value);
            dateOut.Value = Convert.ToDateTime(ReservationGridView.SelectedRows[0].Cells[4].Value);

            editBtn.Enabled = true;
        }

        private void refreshImageBtn_Click(object sender, EventArgs e)
        {
            RefreshContent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            InsertToDb();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            EditDb();
        }

        //Delete btn
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DeleteFromDb();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchDb();
        }

        private void ReservationSearchbox_MouseClick(object sender, MouseEventArgs e)
        {
            searchBtn.Enabled = true;
        }

        private void ReservationInfo_Load(object sender, EventArgs e)
        {
            today = dateIn.Value;
            FillRoomCombo();
            FillClientCombo();
            Populate();
            dateLabel.Text = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();
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

        #endregion
    }
}
