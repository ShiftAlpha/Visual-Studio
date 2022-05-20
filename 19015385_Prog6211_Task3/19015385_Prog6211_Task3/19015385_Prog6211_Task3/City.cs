using _19015385_Prog6211_Task2;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace _19015385_Prog6211_Task1
{
    class City
    {
        private string cityName;
        private DateTime date;
        private int minTemp;
        private int maxTemp;
        private int precipitation;
        private int humidity;
        private int windSpeed;


        public static string tempPath = Environment.CurrentDirectory;
        public static string path = Directory.GetParent(tempPath).Parent.FullName + @"\Database\";

       

        private Tools tools = new Tools();

        public City()
        {

        }
    
        public void SaveToDatabase()
        {
            //establish connection
            SqlConnection connection = new SqlConnection(new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "WeatherAppDB.mdf;Integrated Security=True").ConnectionString);

            //write SQL Query
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

            //execute query
            query.ExecuteNonQuery();
            connection.Close();
        }


        //constructor to receive parameters from form class
        public City(string pCityName, DateTime pDate, int pMinTemp, int pMaxTemp, int pPrecipitation, int pHumidity, int pWindSpeed)
        {

            //checks if city name is null
            if (pCityName == "")
            {
                MessageBox.Show("City not Selected");
            }
            else
            {
                cityName = pCityName;
                date = pDate;
                minTemp = pMinTemp;
                maxTemp = pMaxTemp;
                precipitation = pPrecipitation;
                humidity = pHumidity;
                windSpeed = pWindSpeed;
            }

        }

        //GETTERS---------------------------------------------------------------------------------
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

        //END GETTERS---------------------------------------------------------------------------------------------------


        public string Display()
        {
            string sDisplay = "";
            sDisplay = cityName + "\t" + Convert.ToString(date.ToShortDateString()) + "\t" + Convert.ToString(minTemp) + "\t" + Convert.ToString(maxTemp)
                + "\t" + Convert.ToString(precipitation) + "\t" + Convert.ToString(humidity) + "\t" + Convert.ToString(windSpeed);

            return sDisplay;
        }

        
   


    }
}
