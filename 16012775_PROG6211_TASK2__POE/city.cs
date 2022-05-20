using _16012775_PROG6211_TASK1__POE;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace _16012775_PROG6211_TASK1__POE
{
    class City
    {
        //variables declared
        private string cityName;
        private DateTime date;
        private int minTemp;
        private int maxTemp;
        private int precipitation;
        private int humidity;
        private int windSpeed;


        public static string tempPath = Environment.CurrentDirectory;
        public static string path = Directory.GetParent(tempPath).Parent.FullName + @"\Database\";


        public void SaveToDatabase()
        {
            //creates and establishes connection
            SqlConnection connection = new SqlConnection(new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "16012775_ProgDB.mdf;Integrated Security=True").ConnectionString);

            //query to execute an Insert of data(table forecasts values into the database)
            SqlCommand query = new SqlCommand("Insert into tblForecasts values (@CityName, @Date, @MinTemp , @MaxTemp , @Precipitation , @Humidity , @WindSpeed)", connection);

            //set query variables
            connection.Open();
            query.Parameters.AddWithValue("@CityName", cityName);
            query.Parameters.AddWithValue("@Date", date.ToShortDateString());
            query.Parameters.AddWithValue("@MinTemp", minTemp);
            query.Parameters.AddWithValue("@MaxTemp", maxTemp);
            query.Parameters.AddWithValue("@Precipitation", precipitation);
            query.Parameters.AddWithValue("@Humidity", humidity);
            query.Parameters.AddWithValue("@WindSpeed", windSpeed);

            //executes query
            query.ExecuteNonQuery();
            connection.Close();
        }


        //constructor to receive parameters from form class
        public City(string pCName, DateTime pDate, int pMnTemp, int pMxTemp, int pPrecip, int pHumidity, int pWindSpeed)
        {

            //checks if city name is null
            if (pCName == "")
            {
                MessageBox.Show("City is not Selected");
            }
            else
            {
                cityName = pCName;
                date = pDate;
                minTemp = pMnTemp;
                maxTemp = pMxTemp;
                precipitation = pPrecip;
                humidity = pHumidity;
                windSpeed = pWindSpeed;
            }

        }

        //GET methods
        public string getCity()
        {
            return cityName;
        }

        public DateTime getDate()
        {
            return date;
        }

        public int getminTemp()
        {
            return minTemp;
        }

        public int getmaxTemp()
        {
            return maxTemp;

        }

        public int getPrecipitation()
        {
            return precipitation;
        }

        public int getHumidity()
        {
            return humidity;
        }

        public int getWindSpd()
        {
            return windSpeed;
        }

       
        //display method 
        public string Display()
        {
            string sDisplay = "";
            sDisplay = cityName + "\t" + Convert.ToString(date.ToShortDateString()) + "\t" + Convert.ToString(minTemp) + "\t" + Convert.ToString(maxTemp)
                + "\t" + Convert.ToString(precipitation) + "\t" + Convert.ToString(humidity) + "\t" + Convert.ToString(windSpeed);

            return sDisplay;
        }





    }
}
