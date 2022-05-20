using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class Forecast
    {
        // Declaration of class variables.
        private string city;
        private DateTime date;
        private double minTemp;
        private double maxTemp;
        private double precipitation;
        private double humidity;
        private double windSpeed;
        
        // Forecast class constructor.
        public Forecast(string city, DateTime date, double minTemp, double maxTemp, double precipitation, double humidity, double windSpeed)
        {
            this.city = city;
            this.date = date;
            this.minTemp = minTemp;
            this.maxTemp = maxTemp;
            this.precipitation = precipitation;
            this.humidity = humidity;
            this.windSpeed = windSpeed;
        }

        // Accessor and Mutator methods.
        public string City { get => city; set => city = value;  }
        public DateTime Date { get => date; set => date = value; }
        public double MinTemp { get => minTemp; set => minTemp = value; }
        public double MaxTemp { get => maxTemp; set => maxTemp = value; }
        public double Precipitation { get => precipitation; set => precipitation = value; }
        public double Humidity { get => humidity; set => humidity = value; }
        public double WindSpeed { get => windSpeed; set => windSpeed = value; }
        
        // Method to display the MultiCity forecast.
        public string DisplayListMultiCity()
        {
            string display;
            display = $"{city,-20}{date.ToString("dd/MM/yyyy"),-20}{minTemp,-30}{maxTemp,-30}{precipitation,-30}{humidity,-30}{windSpeed,-30}\n";

            return display;
        }

        // Method to display the Single City forecast.
        public string DisplayListSingleCity()
        {
            string display;
            display = $"{date.ToString("dd/MM/yyyy"),-20}{minTemp,-30}{maxTemp,-30}{precipitation,-30}{humidity,-30}{windSpeed,-30}\n";

            return display;
        }

        // ToString() overide used to write forecasts to file in a CSV format allowing commas to be used throughout as delimiters.
        public override string ToString()
        {
            return city + "," + date.ToString("dd/MM/yyyy") + "," + minTemp + "," + maxTemp + "," + precipitation + "," + humidity + "," + windSpeed;
        }

        // Method to display forecasts in the edit forecasts form.
        public string DisplayForEdit()
        {
            string display;
            display = $"{date.ToString("dd/MM/yyyy"),-20}{minTemp,-30}{maxTemp,-30}{precipitation,-30}{humidity,-30}{windSpeed,-30}\n";

            return display;
        }
    }
}
