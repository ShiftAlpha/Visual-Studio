using _19015385_Prog6211_Task2;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace _19015385_Prog6211_Task1
{
    public partial class WeatherApp : Form
    {
        public WeatherApp()
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

        private Tools tools = new Tools();

        private List<City> citiesReports = new List<City>();

        private static string tempPath = Environment.CurrentDirectory;
        private static string path = Directory.GetParent(tempPath).Parent.FullName + @"\Database\";

        private SqlConnection connection = new SqlConnection(new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "WeatherAppDB.mdf;Integrated Security=True").ConnectionString);

        private void btnCaptureData_Click(object sender, EventArgs e)
        {
            switch (cmbCity.SelectedIndex)
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

            date = dateTimePicker1.Value;

            minTemp = (int)spnMinTemp.Value;
            maxTemp = (int)spnMaxTemp.Value;
            precipitation = (int)spnPrecip.Value;
            humidity = (int)spnHumidity.Value;
            windSpeed = (int)spnWindSpd.Value;

            City cityReport = new City(cityName, date, minTemp, maxTemp, precipitation, humidity, windSpeed);

            cityReport.SaveToDatabase();
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

        public void generateReport1(string scityname, DateTime startDate, DateTime endDate) //first report to display records for 1 city in specified date range
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

                redoutput.Lines = arrFReport;
            }

        }

        private void btnGenReport1_Click(object sender, EventArgs e)
        {
            string scityName = "";

            switch (cmbSelectedCity.SelectedIndex)
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

            DateTime startDate = (dpStartDate.Value);
            DateTime endDate = (dpEndDate.Value);

            generateReport1(scityName, startDate, endDate);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            redoutput.Clear();

            List<string> sCityNames = new List<string>();

            foreach (string s in chklstbxCities.CheckedItems)
            {
                sCityNames.Add(s);
            }

            DateTime startDate = dpStartDate1.Value;
            DateTime endDate = dpEndDate1.Value;

            List<string> SecondReport = new List<string>();

            readDB();

            foreach (string sCityName in sCityNames)
            {
                foreach (var city in citiesReports)
                {


                    if ((sCityName == city.getCity()) && (city.getDate() >= startDate) && (city.getDate() <= endDate))
                    {
                        SecondReport.Add(city.Display());
                    }
                }
            }

            string[] arrSecondReport = new string[SecondReport.Count];
            SecondReport.CopyTo(arrSecondReport);

            redoutput.Lines = arrSecondReport;
        }

        private void WeatherApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            editforecasts frmeditforecasts = new editforecasts();
            frmeditforecasts.Show();
        }

        private void WeatherApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            tools.showMainForm();
        }
    }
}
