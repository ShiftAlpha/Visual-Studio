using _16012775_PROG6211_TASK1__POE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace _16012775_PROG6211_TASK1__POE
{
    public partial class createForecast : Form
    {
        public createForecast()
        {
            InitializeComponent();
        }


        private string cityName = "";
        private DateTime date;
        private int minTemp = 0;
        private int maxTemp = 0;
        private int precipitation = 0;
        private int humidity = 0;
        private int windSpeed = 0;

        private Tool tools = new Tool();

        private List<City> citiesReports = new List<City>();

        private static string tempPath = Environment.CurrentDirectory;
        private static string path = Directory.GetParent(tempPath).Parent.FullName + @"\Database\";

        private SqlConnection connection = new SqlConnection(new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "WeatherAppDB.mdf;Integrated Security=True").ConnectionString);

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }


        private void createForecast_Load(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            switch (cbCity.SelectedIndex)
            {
                case 0:
                    cityName = "Durban";
                    break;

                case 1:
                    cityName = "Johannesburg";
                    break;

                case 2:
                    cityName = "Cape Town";
                    break;

                case 3:
                    cityName = "Bloemfontein";
                    break;

                default:
                    cityName = "Durban";
                    break;

            }

            date = dateTimePick.Value;

            minTemp = (int)minTempInc.Value;
            maxTemp = (int)mTempInc.Value;
            precipitation = (int)precipInc.Value;
            humidity = (int)humdityInc.Value;
            windSpeed = (int)speedInc.Value;

            City cityReport = new City(cityName, date, minTemp, maxTemp, precipitation, humidity, windSpeed);

            cityReport.SaveToDatabase();
        }
    }
}
