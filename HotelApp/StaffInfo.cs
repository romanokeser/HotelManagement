using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelApp
{
    public partial class StaffInfo : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Romano\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");

        private Font _boldFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
        private Font _regularFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular);

        public StaffInfo()
        {
            InitializeComponent();
            Populate();

            editBtn.Enabled = false;
            deleteBtn.Enabled = false;
            searchBtn.Enabled = false;

            StaffGridView.CellClick += StaffGridView_CellClick;
            staffSearch.MouseClick += StaffSearch_MouseClick;
        }

        private void StaffGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            staffIdTextbox.Text = StaffGridView.SelectedRows[0].Cells[0].Value.ToString();
            staffNameTextbox.Text = StaffGridView.SelectedRows[0].Cells[1].Value.ToString();
            staffNumberTextbox.Text = StaffGridView.SelectedRows[0].Cells[2].Value.ToString();
            staffGender.Text = StaffGridView.SelectedRows[0].Cells[3].Value.ToString();
            staffPassTextbox.Text = StaffGridView.SelectedRows[0].Cells[4].Value.ToString();

            editBtn.Enabled = true;
            deleteBtn.Enabled = true;
        }

        #region Functions
        public void Populate()
        {
            conn.Open();
            string query = "SELECT * FROM Staff_tbl";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StaffGridView.DataSource = ds.Tables[0];

            conn.Close();
        }

        private void RefreshContent()
        {
            Populate();
            staffSearch.Text = "";
        }

        private void ImportToDb()
        {
            conn.Open();

            label2.Font = _regularFont;
            label4.Font = _regularFont;
            label5.Font = _regularFont;

            if (string.IsNullOrEmpty(staffNameTextbox.Text))
            {
                label2.Font = _boldFont;
                conn.Close();
            }

            if (string.IsNullOrEmpty(staffNumberTextbox.Text))
            {
                label4.Font = _boldFont;
                conn.Close();
            }
            if (string.IsNullOrEmpty(staffPassTextbox.Text))
            {
                label5.Font = _boldFont;
                conn.Close();
            }

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Staff_tbl VALUES('"
                    //+ staffIdTextbox.Text + "','"
                    + staffNameTextbox.Text + "','"
                    + staffNumberTextbox.Text + "','"
                    + staffGender.SelectedItem.ToString() + "','"
                    + staffPassTextbox.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Staff added succesfully");
                conn.Close();
                Populate();
            }
            catch (Exception)
            {
                MessageBox.Show("Fill all required fields!");
                ShowComboboxCRT();
                conn.Close();
                staffGender.DroppedDown = true;
            }
        }

        private void ShowComboboxCRT()
        {
            Task.Delay(200).Wait();
            staffGender.DroppedDown = true;
        }

        private void EditDb()
        {
            conn.Open();

            string query = "UPDATE Staff_tbl SET StaffName = '" + staffNameTextbox.Text
                + "', StaffPhone = '" + staffNumberTextbox.Text
                + "', Gender = '" + staffGender.SelectedItem.ToString()
                + "', StaffPassword = '" + staffPassTextbox.Text
                + "' WHERE StaffId = " + staffIdTextbox.Text + ";";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff succesfully edited");
            conn.Close();
            Populate();

        }

        private void DeleteFromDb()
        {
            conn.Open();

            string query = "DELETE FROM Staff_tbl WHERE StaffId = " + staffIdTextbox.Text + "";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff succesfully deleted");
            conn.Close();
            Populate();

        }
        private void SearchDb()
        {
            conn.Open();
            string query = "SELECT * FROM Staff_tbl WHERE StaffName = '" + staffSearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StaffGridView.DataSource = ds.Tables[0];

            conn.Close();
        }

        private void GoBack()
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        #endregion

        #region Components

        private void refreshImageBtn_Click(object sender, EventArgs e)
        {
            RefreshContent();
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            ImportToDb();
        }

        private void editBtn_Click_1(object sender, EventArgs e)
        {
            EditDb();
        }

        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            DeleteFromDb();
        }

        private void searchBtn_Click_1(object sender, EventArgs e)
        {
            SearchDb();
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void StaffSearch_MouseClick(object sender, MouseEventArgs e)
        {
            searchBtn.Enabled = true;
        }

        #endregion

        private void StaffInfo_Load(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();
        }
    }
}
