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
    public partial class ClientInfo : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Romano\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");

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

        public ClientInfo()
        {
            InitializeComponent();
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Client_tbl VALUES('"
                + clientIdTextbox.Text + "','"
                + clientNameTextbox.Text + "','"
                + clientPhoneTextbox.Text + "','"
                + clientCtry.SelectedItem.ToString() + "')", conn);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Client added succesfully");
            conn.Close();
            Populate();
        }

        private void ClientGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clientIdTextbox.Text = ClientGridView.SelectedRows[0].Cells[0].Value.ToString();
            clientNameTextbox.Text = ClientGridView.SelectedRows[0].Cells[1].Value.ToString();
            clientPhoneTextbox.Text = ClientGridView.SelectedRows[0].Cells[2].Value.ToString();
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

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = "DELETE FROM Client_tbl WHERE ClientId = " + clientIdTextbox.Text + "";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Client succesfully deleted");
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
    }
}
