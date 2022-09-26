using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelApp
{
    public partial class ClientInfo : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Romano\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");

        private Font _boldFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
        private Font _regularFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular);

        public ClientInfo()
        {
            InitializeComponent();

            editBtn.Enabled = false;
            delBtn.Enabled = false;
            searchBtn.Enabled = false;

            ClientGridView.CellClick += ClientGridView_CellContentClick;
            clientSearch.MouseClick += ClientSearch_MouseClick;
        }


        #region Functions

        private void Populate()
        {
            conn.Open();
            string query = "SELECT * FROM Client_tbl";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClientGridView.DataSource = ds.Tables[0];

            conn.Close();
        }

        private void InsertToDb()
        {
            conn.Open();

            label3.Font = _regularFont;
            label4.Font = _regularFont;
            clientCtry.Font = _regularFont;

            if (string.IsNullOrEmpty(clientNameTextbox.Text))
            {
                label3.Font = _boldFont;
                conn.Close();
            }
            if (string.IsNullOrEmpty(clientPhoneTextbox.Text))
            {
                label4.Font = _boldFont;
                conn.Close();
            }
            if (clientCtry.SelectedIndex <= 0)
            {
                conn.Close();
            }

            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Client_tbl VALUES('"
                    //+ clientIdTextbox.Text + "','"
                    + clientNameTextbox.Text + "','"
                    + clientPhoneTextbox.Text + "','"
                    + clientCtry.SelectedItem.ToString() + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Client added succesfully");
                conn.Close();
                Populate();
            }
            catch (Exception)
            {
                MessageBox.Show("Fill all required fields!");
                ShowComboboxCRT();
                conn.Close();
                clientCtry.DroppedDown = true;
            }
        }

        private void RefreshContent()
        {
            Populate();
            clientSearch.Text = "";
        }

        private void EditDb()
        {
            conn.Open();
            string query = "UPDATE Client_tbl SET ClientName = '" + clientNameTextbox.Text
                + "', ClientPhone = '" + clientPhoneTextbox.Text
                + "', ClientCountry= '" + clientCtry.SelectedItem.ToString()
                + "' WHERE ClientId = " + clientIdTextbox.Text + ";";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client succesfully edited");
            conn.Close();
            Populate();
        }

        private void ShowComboboxCRT()
        {
            Task.Delay(200).Wait();
            clientCtry.DroppedDown = true;
        }

        private void DeleteFromDb()
        {
            conn.Open();
            string query = "DELETE FROM Client_tbl WHERE ClientId = " + clientIdTextbox.Text + "";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client succesfully deleted");
            conn.Close();
            Populate();
        }

        private void GoBack()
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void SearchDb()
        {
            conn.Open();
            string query = "SELECT * FROM Client_tbl WHERE ClientName = '" + clientSearch.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cbuilder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            ClientGridView.DataSource = ds.Tables[0];

            conn.Close();
        }

        #endregion

        #region Components 

        private void ClientSearch_MouseClick(object sender, MouseEventArgs e)
        {
            searchBtn.Enabled = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            InsertToDb();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString();
            Populate();
        }

        private void ClientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clientIdTextbox.Text = ClientGridView.SelectedRows[0].Cells[0].Value.ToString();
            clientNameTextbox.Text = ClientGridView.SelectedRows[0].Cells[1].Value.ToString();
            clientPhoneTextbox.Text = ClientGridView.SelectedRows[0].Cells[2].Value.ToString();
            clientCtry.Text = ClientGridView.SelectedRows[0].Cells[3].Value.ToString();

            editBtn.Enabled = true;
            delBtn.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RefreshContent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            EditDb();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DeleteFromDb();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void searchBtn_Click_1(object sender, EventArgs e)
        {
            SearchDb();
        }

        #endregion
    }
}
