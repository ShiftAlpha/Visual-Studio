using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace WeatherApplication
{
    public partial class WeatherCrud : Form
    {
        ArrayList forecast = new ArrayList();
 
        public WeatherCrud()
        {
            InitializeComponent();
        }

        private void WeatherCrud_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Error - values missing");
            }
            else
            {
                Weather forecast = new Weather(0,textBox1.Text, dateTimePicker1.MaxDate, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                try
                {
                    using (SqlConnection con1 = new SqlConnection(Properties.Settings.Default.WaKon))
                    {
                        string Query = "insert into weather(city_id,dates ,mintemp,maxtemp ,prec , hum,winds)values((select city_id from city where city_name like @cName ),@dates,@mintemp,@maxtemp,@prec,@hum,@winds)";
                        using (SqlCommand cmd = new SqlCommand(Query, con1))
                        {
                            cmd.Parameters.AddWithValue("@City", forecast.City1);
                            cmd.Parameters.AddWithValue("@dates", dateTimePicker1.Value.ToString());
                            cmd.Parameters.AddWithValue("@MinTemp", forecast.MinT1);
                            cmd.Parameters.AddWithValue("@MaxTemp", forecast.Maxt1);
                            cmd.Parameters.AddWithValue("@Prec", forecast.Prec1);
                            cmd.Parameters.AddWithValue("@Hum", forecast.Hum1);
                            cmd.Parameters.AddWithValue("@WindS", forecast.Wind1);
                            con1.Open();

                            int id = Convert.ToInt32(cmd.ExecuteScalar());

                            forecast.Weatherid1 = id;
                            //Weather.Add(forecast);

                            if (con1.State == System.Data.ConnectionState.Open)
                                con1.Close();
                            MessageBox.Show("Contact added successfully");
                        }
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();

                listBox1.Items.Clear();
                foreach (Weather weather in forecast)
                {
                    listBox1.Items.Add(forecast.City1);
                }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnedit.Enabled = false;
            btnsave.Enabled = true;
            textBox7.Clear();

            string City = listBox1.SelectedItem.ToString();
            Weather selectedContact = new Weather();

            foreach (Weather weather in forecast)
            {
                if ((weather.City1 ).Equals(City))
                {
                    textBox1.Text = weather.City1;
                    dateTimePicker1.MaxDate = weather.Date1 ;
                    textBox2.Text = Convert.ToString(weather.MinT1);
                    textBox3.Text = Convert.ToString(weather.Maxt1);
                    textBox4.Text = Convert.ToString(weather.Prec1);
                    textBox5.Text = Convert.ToString(weather.Hum1);
                    textBox6.Text = Convert.ToString(weather.Wind1);
                    break;
                }
            }
            btnedit.Enabled = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Error - Values missing!");
            }
            else
            {
                Weather newContact = new Weather(0, textBox1.Text, dateTimePicker1.MaxDate, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                try
                {
                    SqlConnection con2 = new SqlConnection(Properties.Settings.Default.WaKon);
                    con2.Open();

                    string sqlQuery = "update weather(city_id,dates ,mintemp,maxtemp ,prec , hum,winds)values((select city_id from city where city_name like @cName ),@dates,@mintemp,@maxtemp,@prec,@hum,@winds)";
                    SqlCommand command = new SqlCommand(sqlQuery, con2);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Updated successfully");

                    forecast.Remove(forecast);
                    forecast.Add(forecast);
                    forecast.Sort();

                    con2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                forecast.Sort();
                listBox1.Items.Clear();
                foreach (Weather weatherid in forecast)
                {
                    listBox1.Items.Add(weatherid.City1);
                }
            }
        }

        private void btnComp_Click(object sender, EventArgs e)
        {
            ReportType1 rep = new ReportType1();
            rep.Show();
            this.Hide();
        }

        private void btndash_Click(object sender, EventArgs e)
        {
            DashBoard dash = new DashBoard(this.a);
            dash.Show();
            this.Hide();
        }

        private void btncity_Click(object sender, EventArgs e)
        {
            report rep = new report();
            rep.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
