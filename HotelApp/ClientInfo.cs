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
using System.Collections;

namespace HotelApp
{
    public partial class ClientInfo : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Romano\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");

        private Font _boldFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
        private Font _regularFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular);

        private bool _isTableClicked;

        public ClientInfo()
        {
            InitializeComponent();
            editBtn.Enabled = false;
            delBtn.Enabled = false;


            ClientGridView.CellClick += ClientGridView_CellContentClick;
            ClientGridView.Leave += ClientGridView_Leave;
        }

        private void ClientGridView_Leave(object sender, EventArgs e)
        {
            _isTableClicked = true;
        }

        public void Populate()
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
        }

        private void ClientInfo_Load(object sender, EventArgs e)
        {
            //dateLabel.Text = DateTime.Now.ToLongDateString();
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

            _isTableClicked = true;
        }

        private void editBtn_Click(object sender, EventArgs e)
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

        private void searchBtn_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            label3.Font = _regularFont;
            label4.Font = _regularFont;
            clientCtry.Font = _regularFont;

            if (string.IsNullOrEmpty(clientNameTextbox.Text))
            {
                label3.Font = _boldFont;
                conn.Close();
                //return;
            }

            if (string.IsNullOrEmpty(clientPhoneTextbox.Text))
            {
                label4.Font = _boldFont;
                conn.Close();
                //return;
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
                clientCtry.DroppedDown = true;
            }
        }

        private void ShowComboboxCRT()
        {
            Task.Delay(200).Wait();
            clientCtry.DroppedDown = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
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

        private void delBtn_Click(object sender, EventArgs e)
        {

            conn.Open();
            string query = "DELETE FROM Client_tbl WHERE ClientId = " + clientIdTextbox.Text + "";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client succesfully deleted");
            conn.Close();
            Populate();



        }
    }
}
