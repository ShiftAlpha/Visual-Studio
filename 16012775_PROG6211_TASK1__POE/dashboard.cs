using _16012775_PROG6211_TASK1__POE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace _16012775_PROG6211_TASK1__POE
{
    public partial class dashboard : Form
    {
        public dashboard()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void readDB() //extracts data from db into list 
        {
            connection.Open();
            SqlCommand query = new SqlCommand("Select * from tblForecasts", connection);
            SqlDataReader dbReader = query.ExecuteReader();

            if (dbReader.HasRows)
            {
                while (dbReader.Read())
                {
                    cityName = dbReader[0].ToString();
                    date = DateTime.Parse(dbReader[1].ToString());
                    minTemp = int.Parse(dbReader[2].ToString());
                    maxTemp = int.Parse(dbReader[3].ToString());
                    precipitation = int.Parse(dbReader[4].ToString());
                    humidity = int.Parse(dbReader[5].ToString());
                    windSpeed = int.Parse(dbReader[6].ToString());

                    citiesReports.Add(new City(cityName, date, minTemp, maxTemp, precipitation, humidity, windSpeed));
                }

            }
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rtbViewRecords.Clear();

            List<string> sCityNames = new List<string>();

            foreach (string s in cbCities.CheckedItems)
            {
                sCityNames.Add(s);
            }

            DateTime startDate = startDPick.Value;
            DateTime endDate = endDPick.Value;

            List<string> SecondReport = new List<string>();

            readDB();

            foreach (string sCityName in sCityNames)
            {
                foreach (var city in citiesReports)
                {


                    if ((sCityName == city.getCity()) && (city.getDate() >= startDate) && (city.getDate() <= endDate))

                        SecondReport.Add(city.Display());
                }
                string[] arrSecondReport = new string[SecondReport.Count];
                SecondReport.CopyTo(arrSecondReport);

                rtbViewRecords.Lines = arrSecondReport;
            }
        }

        
        private void createBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void viewCityBtn_Click(object sender, EventArgs e)
        {
            string scityName = "";

            switch (cbCity.SelectedIndex)
            {
                case 0:
                    scityName = "Durban";
                    break;

                case 1:
                    scityName = "Johannesburg";
                    break;

                case 2:
                    scityName = "Cape Town";
                    break;

                case 3:
                    scityName = "Bloemfontein";
                    break;

                default:
                    scityName = "Durban";
                    break;
            }

            DateTime startDate = (startDPick.Value);
            DateTime endDate = (endDPick.Value);

            viewCityForecast(scityName, startDate, endDate);
        }
        public void viewCityForecast(string scityname, DateTime startDate, DateTime endDate) //first report to display records for 1 city in specified date range
        {

            List<string> FirstReport = new List<string>();
            readDB();

            foreach (City city in citiesReports)
            {
                if ((city.getCity() == scityname) && (city.getDate() >= startDate) && (city.getDate() <= endDate))
                {
                    FirstReport.Add(city.Display());
                }

                string[] arrFReport = new string[FirstReport.Count];
                FirstReport.CopyTo(arrFReport);

                rtbViewRecords = arrFReport;
            }

        }
    }



}

