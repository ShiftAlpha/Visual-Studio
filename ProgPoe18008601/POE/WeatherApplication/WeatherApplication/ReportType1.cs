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
using System.IO;

namespace WeatherApplication
{
    public partial class ReportType1 : Form
    {

        public ReportType1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReportType1_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Properties.Settings.Default.WaKon);
            SqlCommand cmd;
            SqlDataReader dataReader;
            con.Open();

            cmd = new SqlCommand("select city_name from city", con);

            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {

                comboBox1.Items.Insert(0, dataReader["city_name"].ToString());
                comboBox2.Items.Insert(0, dataReader["city_name"].ToString());

            }

            con.Close();

            con.Open();

            cmd = new SqlCommand("select dates from weather", con);
            dataReader = cmd.ExecuteReader();

            while (dataReader.Read())
            {
                comboBox3.Items.Insert(0, dataReader["dates"].ToString());
                comboBox4.Items.Insert(0, dataReader["dates"].ToString());

            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean useDate = true;
            string date1, date2 = "";


            if ((comboBox3.SelectedItem == null) && (comboBox4.SelectedItem == null))
            {
                useDate = false;
                date1 = "";
                date2 = "";

                MessageBox.Show("You forgot to specify the date Range ");

            }
            else {
                date1 = comboBox3.Items[comboBox3.SelectedIndex].ToString();
                date2 = comboBox4.Items[comboBox4.SelectedIndex].ToString();



                dataGridView1.DataSource = getTableDate(comboBox1.Items[comboBox1.SelectedIndex].ToString(), date1, date2, useDate);
                dgView2.DataSource = getTableDate(comboBox2.Items[comboBox2.SelectedIndex].ToString(), date1, date2, useDate);
            }
            


        }
        public DataTable getTableDate(string CityName, string fromDate, string toDate, Boolean useDate  )
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.WaKon);
            SqlCommand cmd;
            SqlDataAdapter daView;
            
            string output;



            if (useDate == true) {

                con.Open();
                output = "select city.city_name, weather.dates, weather.mintemp, weather.maxtemp, weather.prec, weather.hum, weather.winds from weather inner join city on city.city_id = weather.city_id where city_name like @cityname";
                cmd = new SqlCommand(output, con);
                cmd.Parameters.AddWithValue("@cityname", CityName);

                daView = new SqlDataAdapter(cmd);
                DataTable dtNew = new DataTable();
                daView.Fill(dtNew);

                return dtNew; 

                con.Close();




            }
            else {
                con.Open();
                output = "select city.city_name, weather.dates, weather.mintemp, weather.maxtemp, weather.prec, weather.hum, weather.winds from weather inner join city on city.city_id = weather.city_id where  city_name like @cityName and dates >= @from and dates <= @to";
                cmd = new SqlCommand(output, con);
                cmd.Parameters.AddWithValue("@cityname", CityName);
                cmd.Parameters.AddWithValue("@From", fromDate);
                cmd.Parameters.AddWithValue("@to", toDate);

                DataTable dtNew = new DataTable();
                daView = new SqlDataAdapter(cmd);


                daView.Fill(dtNew);
                return dtNew; 

                con.Close();


            }








            return new DataTable();

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DashBoard das = new DashBoard();
            das.Show();
            this.Hide();
        }
    }
          
}
