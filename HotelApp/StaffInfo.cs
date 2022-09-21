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
    public partial class StaffInfo : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Romano\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");

        public StaffInfo()
        {
            InitializeComponent();
            Populate();
        }
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Staff_tbl VALUES('"
                + staffIdTextbox.Text + "','"
                + staffNameTextbox.Text + "','"
                + staffNumberTextbox.Text + "','"
                + staffGender.SelectedItem.ToString()  + "','"
                + staffPassTextbox.Text + "')", conn);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff added succesfully");
            conn.Close();
            Populate();
        }

        private void editBtn_Click(object sender, EventArgs e)
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

        private void StaffGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            staffIdTextbox.Text = StaffGridView.SelectedRows[0].Cells[0].Value.ToString();
            staffNameTextbox.Text = StaffGridView.SelectedRows[0].Cells[1].Value.ToString();
            staffNumberTextbox.Text = StaffGridView.SelectedRows[0].Cells[2].Value.ToString();
            staffGender.Text = StaffGridView.SelectedRows[0].Cells[3].Value.ToString();
            staffPassTextbox.Text = StaffGridView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            conn.Open();

            string query = "DELETE FROM Staff_tbl WHERE StaffId = " + staffIdTextbox.Text + "";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Staff succesfully deleted");
            conn.Close();
            Populate();
        }

        private void searchBtn_Click(object sender, EventArgs e)
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

        private void refreshImageBtn_Click(object sender, EventArgs e)
        {
            Populate();
        }
    }
}
