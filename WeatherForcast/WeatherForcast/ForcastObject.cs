using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForcast
{
    class ForcastObject
    {
        //properties
        public string cityname;
        public int cityID;
        public int minTemp, maxTemp;
        public double humidity, wind, precipitation;
        public DateTime date;

        //constructor
        public ForcastObject(string cityname, int cityID, int minTemp, int maxTemp, double humidity, double wind, double precipitation, DateTime date)
        {
            this.cityname = cityname;
            this.cityID = cityID;
            this.minTemp = minTemp;
            this.maxTemp = maxTemp;
            this.humidity = humidity;
            this.wind = wind;
            this.precipitation = precipitation;
            this.date = date;
        }

        //getters
        public DateTime getDate()
        {
            return this.date;
        }

        public string getCityName()
        {
            return this.cityname;
        }

        public int getMinTemp()
        {
            return this.minTemp;
        }
        public int getMaxTemp()
        {
            return this.maxTemp;
        }
        public double getHumidity()
        {
            return this.humidity;
        }
        public double getPrecipertation()
        {
            return this.precipitation;
        }
        public double getWind()
        {
            return this.wind;
        }
        public int getCityID()
        {
            return this.cityID;
        }

        //ForcastObject af1 = new ForcastObject("Durban", 1, 22, 30, 0.12, 13, 0, (new DateTime(2020, 3, 15)));
        //ForcastObject af2 = new ForcastObject("Durban", 1, 21, 28, 0.10, 9, 4, (new DateTime(2020, 3, 16)));
        //ForcastObject af3 = new ForcastObject("Durban", 1, 18, 29, 0.20, 18, 8, (new DateTime(2020, 3, 17)));
        //ForcastObject af4 = new ForcastObject("Durban", 1, 23, 25, 0.24, 20, 10, (new DateTime(2020, 3, 18)));
        //ForcastObject af5 = new ForcastObject("Durban", 1, 11, 20, 0.14, 14, 13, (new DateTime(2020, 3, 19)));
    }
}
