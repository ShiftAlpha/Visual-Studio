using _19015385_Prog6211_Task2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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

            citiesReports.Add(new City(cityName, date, minTemp, maxTemp, precipitation, humidity, windSpeed));



        }

        public void searchList(DateTime startDate, DateTime endDate)
        {

            List<string> FirstReport = new List<string>();

            foreach (City city in citiesReports)

            {


                if (city.getCity().Contains(cityName) && (city.getDate() >= startDate) && (city.getDate() <= endDate))
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


            switch (cmbSelectedCity.SelectedIndex)
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

            DateTime startDate = (dpStartDate.Value);
            DateTime endDate = (dpEndDate.Value);

            searchList(startDate, endDate);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = @"..\..\19015385_Prog6211_Task2\CitiesReports.txt";

                List<string> sCitiesReports = new List<string>();

                foreach (City city in citiesReports)
                {
                    sCitiesReports.Add(city.FileFormat());
                }

                File.AppendAllLines(filePath, sCitiesReports);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
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
