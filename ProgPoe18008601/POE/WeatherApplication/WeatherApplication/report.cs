using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace WeatherApplication
{
    public partial class report : Form
    {
        
        string[] vals = new string[100];
        string[] cityNames = new string[100];
        public report()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.WaKon);
            SqlCommand cmd;
            string output = "" ;
            SqlDataAdapter daView;
            

            if ((datecmb.SelectedItem == null) || (datecmbx.SelectedItem == null))
            {
                con.Open();
                output = "select city.city_name, weather.dates, weather.mintemp, weather.maxtemp, weather.prec, weather.hum, weather.winds from weather inner join city on city.city_id = weather.city_id where city_name like @cityname";
                cmd = new  SqlCommand(output,con);
                cmd.Parameters.AddWithValue("@cityname",citycmbx.Items[citycmbx.SelectedIndex] );

                daView = new SqlDataAdapter(cmd);
                DataTable dtNew = new DataTable();
                daView.Fill(dtNew);
                dgview.DataSource = dtNew; 
                                             
                con.Close();
                                                                                         
            }
            else {
                con.Open();
                output = "select city.city_name, weather.dates, weather.mintemp, weather.maxtemp, weather.prec, weather.hum, weather.winds from weather inner join city on city.city_id = weather.city_id where  city_name like @cityName and dates >= @from and dates <=@to";
                cmd = new SqlCommand(output, con);
                cmd.Parameters.AddWithValue("@cityname", citycmbx.Items[citycmbx.SelectedIndex]);
                cmd.Parameters.AddWithValue("@From" ,datecmb.Items[datecmb.SelectedIndex] );
                cmd.Parameters.AddWithValue("@to", datecmbx.Items[datecmbx.SelectedIndex]);

                DataTable dtNew = new DataTable();
                daView = new SqlDataAdapter(cmd);


                daView.Fill(dtNew);
                dgview.DataSource = dtNew;

                con.Close();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            datecmb.Items.Clear();
            datecmbx.Items.Clear();


            SqlConnection con = new SqlConnection(Properties.Settings.Default.WaKon);
            SqlCommand cmd;
            SqlDataReader dataReader; 
            con.Open();


            cmd = new SqlCommand("select dates from weather inner join city on city.city_id  = weather.city_id where city_name like @cityName", con);
            cmd.Parameters.AddWithValue("@cityname" , citycmbx.Items[citycmbx.SelectedIndex]);

            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {

                datecmb.Items.Insert(0, dataReader["dates"].ToString());
                datecmbx.Items.Insert(0, dataReader["dates"].ToString());

            }
            con.Close();

        }

        private void Report_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.WaKon);
            SqlCommand cmd;
            SqlDataReader dataReader;
            con.Open();

            cmd = new SqlCommand("select city_name from city", con);

            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {

                citycmbx.Items.Insert(0, dataReader["city_name"].ToString());

            }

            con.Close();
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportType1 newRep = new ReportType1();
            newRep.Show();
            this.Hide();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printbtn_Click(object sender, EventArgs e)
        {

            SaveFileDialog s = new SaveFileDialog();
            s.FileName = "Report.txt";
            Boolean valid = true;
            if (s.ShowDialog() == DialogResult.OK)
            {
                valid = true;
            }
            else
            {
                valid = true;
            }

            if (valid)
            {
                StreamWriter stream = new StreamWriter(s.FileName);

                String output = "";

                SqlConnection con2 = new SqlConnection(Properties.Settings.Default.WaKon);
                con2.Open();
                SqlCommand cmd = new SqlCommand("select * from weather inner join city on city.city_id = weather.city_id", con2);

                SqlDataReader dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    stream.WriteLine("City Name               Date    min-Temp    max-Temp    Humididty   Precipitation   Wind Speed");
                    output = dr["City_Name"] + "    " + dr["dates"] + "     " + dr["mintemp"] + "             " + dr["maxtemp"] + "           " + dr["hum"] + "           " + dr["prec"] + "        " + dr["winds"];
                    stream.WriteLine(output);


                }
                stream.Close();
                con2.Close();

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DashBoard das = new DashBoard();
            das.Show();
            this.Hide();
        }
    }
}
