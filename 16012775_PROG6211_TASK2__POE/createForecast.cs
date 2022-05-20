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

        //variables declared
        private string cityName = "";
        private DateTime date;
        private int minTemp = 0;
        private int maxTemp = 0;
        private int precipitation = 0;
        private int humidity = 0;
        private int windSpeed = 0;

        //list of city, creates list variable citiesReports
        private List<City> citiesReports = new List<City>();

        //temp path variable
        private static string tPath = Environment.CurrentDirectory;
        private static string path = Directory.GetParent(tPath).Parent.FullName + @"\Database\";

        //cretes sql connection
        private SqlConnection connection = new SqlConnection(new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "16012775_ProgDB.mdf;Integrated Security=True").ConnectionString);

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

        private void button1_Click(object sender, EventArgs e)
        {            
            try
            {
                using (StreamWriter writeToFile = new StreamWriter("Textfile.txt", false))
                {
                    writeToFile.WriteLine("Forecast Report:\n\n\n");
                    
                    writeToFile.WriteLine("\n\n\nRecords Report:\n\n\n");

                }

                MessageBox.Show("'Forecast Report' and 'Records Report' have been successfully printed to file."); 
            }
            catch (Exception)
            {
                MessageBox.Show("Error writing city reports to file.");
            }
        }
    }
    }
}
