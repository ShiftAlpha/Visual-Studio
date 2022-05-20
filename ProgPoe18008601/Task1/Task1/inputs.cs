using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class inputs
    {
        private string city;
        private DateTime date;
        private string minTemp;
        private string maxTemp;
        private string precipitation;
        private string humidity;
        private string windSpeed;

        public inputs(string city, DateTime date, string minTemp, string maxTemp, string precipitation, string humidity, string windSpeed)
        {
            this.city = city;
            this.date = date;
            this.minTemp = minTemp;
            this.maxTemp = maxTemp;
            this.precipitation = precipitation;
            this.humidity = humidity;
            this.windSpeed = windSpeed;
        }
        public inputs() {



        }
        public inputs(string line) {

            string val = line;
            this.city = val.Substring(0, val.IndexOf(","));
            val = val.Remove(0, val.IndexOf(",") + 1);
            this.date = Convert.ToDateTime(val.Substring(0, val.IndexOf(",")));
            val = val.Remove(0, val.IndexOf(",") + 1);
            this.minTemp = val.Substring(0, val.IndexOf(","));
            val = val.Remove(0, val.IndexOf(",") + 1);
            this.maxTemp = val.Substring(0, val.IndexOf(","));
            val = val.Remove(0, val.IndexOf(",") + 1);
            this.precipitation = val.Substring(0, val.IndexOf(","));
            val = val.Remove(0, val.IndexOf(",") + 1);
            this.humidity = val.Substring(0, val.IndexOf(","));
            val = val.Remove(0, val.IndexOf(",") + 1);
            this.windSpeed = val;


        }

        public string City { get => city; set => city = value; }
        public DateTime Date { get => date; set => date = value; }
        public string MinTemp { get => minTemp; set => minTemp = value; }
        public string MaxTemp { get => maxTemp; set => maxTemp = value; }
        public string Precipitation { get => precipitation; set => precipitation = value; }
        public string Humidity { get => humidity; set => humidity = value; }
        public string WindSpeed { get => windSpeed; set => windSpeed = value; }

        public string getInputs()
        {
            string val;
            val = this.City + "," + this.Date + "," + this.MinTemp + "," + this.MaxTemp + "," + this.Precipitation + "," + this.Humidity + "," + this.WindSpeed;

            return val;
        }
    }

    
}
