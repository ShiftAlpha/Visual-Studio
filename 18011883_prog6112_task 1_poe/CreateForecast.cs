using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18011883_prog6112_task_1_poe
{
    public partial class CreateForecast : Form
    {
        public CreateForecast()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String city = CityTxtBx.Text;
            int cityID = Convert.ToInt32(CityIDTxtBx.Text);
            double precip = Convert.ToDouble(PrecipTxtBx.Text);
            double windSpeed = Convert.ToDouble(WindSpeedTxtBx.Text);
            int maxTemp = Convert.ToInt32(MaxTempTxtBx.Text);
            int minTemp = Convert.ToInt32(MinTempTxtBx.Text);
            double humidity = Convert.ToDouble(HumidityTxtBx.Text);
            DateTime date = DateTimePick.Value;

            FactoryClass obj = new FactoryClass(city, cityID, minTemp, maxTemp, precip, humidity, windSpeed, date);
            ListStore.forecastCities.Add(obj);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
