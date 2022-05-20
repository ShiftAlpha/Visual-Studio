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

namespace WeatherApplication
{
    public partial class Form1 : Form
    {

        Boolean bval  ;
        string a;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string usertype) {
            this.a = usertype;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand cmd; 
            cityNameUsed(textBox1.Text);
            if (bval == true)
            {

                SqlConnection con = new SqlConnection(Properties.Settings.Default.WaKon);
                con.Open();
                cmd = new SqlCommand("insert into weather(city_id,dates ,mintemp,maxtemp ,prec , hum,winds)values((select city_id from city where city_name like @cName ),@dates,@mintemp,@maxtemp,@prec,@hum,@winds)", con);
                cmd.Parameters.AddWithValue("@cName", textBox1.Text);
                
                cmd.Parameters.AddWithValue("@dates", dateTimePicker1.Value.ToString());
                cmd.Parameters.AddWithValue("@minTemp", textBox3.Text);
                cmd.Parameters.AddWithValue("@maxTemp", textBox4.Text);
                cmd.Parameters.AddWithValue("@prec", textBox5.Text);
                cmd.Parameters.AddWithValue("@hum", textBox6.Text);
                cmd.Parameters.AddWithValue("@winds", textBox7.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Entry Sucessful");



            }
            else {

                SqlConnection con2 = new SqlConnection(Properties.Settings.Default.WaKon);
                con2.Open();
               
                string query = "";
                query = "insert into city (city_name) values(@cityName) ; ";
                cmd = new SqlCommand(query, con2);
                cmd.Parameters.AddWithValue("@cityname" , textBox1.Text);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("insert into weather(city_id,dates ,mintemp,maxtemp ,prec , hum,winds)values((select city_id from city where city_name like @cName ),@dates,@mintemp,@maxtemp,@prec,@hum,@winds)", con2);
                cmd.Parameters.AddWithValue("@cName", textBox1.Text);
              
                cmd.Parameters.AddWithValue("@dates", dateTimePicker1.Value.ToString());
                cmd.Parameters.AddWithValue("@minTemp", textBox3.Text);
                cmd.Parameters.AddWithValue("@maxTemp", textBox4.Text);
                cmd.Parameters.AddWithValue("@prec", textBox5.Text);
                cmd.Parameters.AddWithValue("@hum", textBox6.Text);
                cmd.Parameters.AddWithValue("@winds", textBox7.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Entry Sucessful");


                con2.Close();



            }
        }

        public void cityNameUsed(string abc) {


            int count = 0; 

            SqlConnection con = new SqlConnection(Properties.Settings.Default.WaKon);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from city where city_name like @val", con);
            cmd.Parameters.AddWithValue("@val",abc);
            SqlDataReader Reader = cmd.ExecuteReader();

            while (Reader.Read()) {

                count++;
            }


            if (count > 0)
            {
                bval =  true;
            }
            else {

                bval = false; 

            }
            con.Close();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string temp = "";
            textBox1.Clear();
            
            textBox3.Clear();
            textBox3.Text = temp; 
            textBox4.Clear();
            textBox4.Text = temp;
            
            textBox5.Clear();
            textBox5.Text = temp; 
            textBox6.Clear();
            textBox6.Text = temp;
           
            textBox7.Clear();
            textBox7.Text = temp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportType1 rep = new ReportType1();
            rep.Show();
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.SelectedText = null; 

        }

        private void button4_Click(object sender, EventArgs e)
        {
            report rep = new report();
            rep.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DashBoard dash = new DashBoard(this.a);
            dash.Show();
            this.Hide();
        }
    }
}
