using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18011883_prog6112_task_1_poe
{
    class FactoryClass
    {
        private String cName;
        private int cID;
        private int minTemp;
        private int maxTemp;
        private double precipitation;
        private double humidity;
        private double windSpeed;
        private DateTime date;


        public FactoryClass(string cName, int cID, int minTemp, int maxTemp, double precipitation, double humidity, double windSpeed, DateTime date)
        {
            this.cName = cName;
            this.cID = cID;
            this.minTemp = minTemp;
            this.maxTemp = maxTemp;
            this.precipitation = precipitation;
            this.humidity = humidity;
            this.windSpeed = windSpeed;
            this.date = date;
        }

        public string getCName() { return cName; }
        public DateTime getDate() { return date; }
        public int getMinTemp() { return minTemp; }
        public int getMaxTemp() { return maxTemp; }
        public double getPrecipitation() { return precipitation; }
        public double getHumidity() { return humidity; }
        public double getWindSpeed() { return windSpeed; }
        public int getCID() { return cID; }
    }
}
    

