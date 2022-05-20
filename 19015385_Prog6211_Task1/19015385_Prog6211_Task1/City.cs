using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19015385_Prog6211_Task1
{
    class City
    {
        private string cityName ;
        private DateTime date;
        private int minTemp;
        private int maxTemp;
        private int precipitation;
        private int humidity;
        private int windSpeed;


        public City(string pCityName , DateTime pDate , int pMinTemp , int pMaxTemp , int pPrecipitation , int pHumidity , int pWindSpeed)
        {
            cityName = pCityName;
            date = pDate;
            minTemp = pMinTemp;
            maxTemp = pMaxTemp;
            precipitation = pPrecipitation;
            humidity = pHumidity;
            windSpeed = pWindSpeed;


        }

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

        public int getmaxTemp ()
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
        public string Display()
        {
            string sDisplay = "";
            sDisplay = cityName + "\t" + Convert.ToString(date.ToShortDateString()) + "\t" + Convert.ToString(minTemp) + "\t" + Convert.ToString(maxTemp)
                + "\t" + Convert.ToString(precipitation) + "\t" + Convert.ToString(humidity) + "\t" + Convert.ToString(windSpeed);

            return sDisplay;
        }
    }
}
