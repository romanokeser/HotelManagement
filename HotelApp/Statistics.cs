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
using System.Windows.Forms.DataVisualization.Charting;

namespace HotelApp
{
    public partial class Statistics : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Romano\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30");


        public Statistics()
        {
            InitializeComponent();
            CountClients();
        }

        private void FillPieChart()
        {
            conn.Open();
            string freeRoomQuery = "SELECT COUNT(*) FROM Room_tbl WHERE RoomFree = 'free'";
            string takenRoomQuery = "SELECT COUNT(*) FROM Room_tbl WHERE RoomFree = 'busy'";

            SqlCommand sqlCommand = new SqlCommand(freeRoomQuery);
            SqlCommand sqlCmdForTakenRoom = new SqlCommand(takenRoomQuery);
            sqlCommand.Connection = conn;
            sqlCmdForTakenRoom.Connection = conn;

            int freeRoomsCount = Convert.ToInt32(sqlCommand.ExecuteScalar());
            int busyRoomsCount = Convert.ToInt32(sqlCmdForTakenRoom.ExecuteScalar());

            conn.Close();

            Console.WriteLine(freeRoomsCount);

            roomsFreeChart.Legends.Add("Free rooms");
            roomsFreeChart.Legends[0].BorderColor = Color.Black;

            //Add a new chart-series
            string seriesname = "MySeriesName";
            roomsFreeChart.Series.Add(seriesname);
            //set the chart-type to "Pie"
            roomsFreeChart.Series[seriesname].ChartType = SeriesChartType.Pie;
            roomsFreeChart.Series[seriesname].Points.AddXY("Free rooms", freeRoomsCount);
            roomsFreeChart.Series[seriesname].Points.AddXY("Taken rooms", busyRoomsCount);
        }

        private void CountClients()
        {
            conn.Open();

            string query = "SELECT COUNT(*) ClientId FROM Client_tbl";
            SqlCommand sqlCommand = new SqlCommand(query);
            sqlCommand.Connection = conn;
            int clientsCount = Convert.ToInt32(sqlCommand.ExecuteScalar());
            conn.Close();

            clientCount.Text = clientsCount.ToString();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            FillPieChart();
        }

        private static DataTable GetData(string query)
        {
            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Romano\Documents\Hoteldb.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            GoBack();
        }

        private void GoBack()
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
