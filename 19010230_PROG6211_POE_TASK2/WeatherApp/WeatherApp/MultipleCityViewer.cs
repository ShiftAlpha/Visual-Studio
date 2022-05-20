using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Drawing;

namespace WeatherApp
{
    public partial class MultipleCityViewer : Form
    {
        public MultipleCityViewer()
        {
            InitializeComponent();
        }

        // Form Event Methods.

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Returns to Menu.
        }

        private void btnConfirm_Click(object sender, System.EventArgs e)
        {
            ClearAllOutputs(); // Removing previous report data, if any.

            DateTime startDate = dtpStart.Value.Date;
            DateTime endDate = dtpEnd.Value.Date;

            // Validation to make sure user selects at least one city.
            if (clbCities.CheckedItems.Count ==0) 
            {
                MessageBox.Show("Please select at least one city.","ERROR");
            }
            else if (cmbViewingOption.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a viewing option","ERROR");
            }
            else if (startDate > endDate)
            {
                MessageBox.Show("Please ensure your start date is before your end date.", "ERROR");
            }
            else 
            {
                // Functionality to hide and show necessary buttons.

                if (Login.isAdmin == true)
                {
                    btnConfirm.Hide();
                    btnPrintToFile.Show();
                    btnPrintToFile.Location = new Point(225, 512);
                    btnPrintToFile.Enabled = true;
                }

                clbCities.Enabled = false;
                dtpStart.Enabled = false;
                dtpEnd.Enabled = false;
                cmbViewingOption.Enabled = false;

                List<Forecast> requests = SelectedForecasts(startDate, endDate); // Gets requested forecasts for the user.

                foreach (Forecast acceptedForecast in requests)
                {
                    rtbForecasts.AppendText(acceptedForecast.DisplayListMultiCity());
                    rtbForecasts.AppendText("\n_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _" +
                        " _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _" +
                        " _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _\n\n");
                }

                List<DateTime> dateRange = GetDateRange(startDate, endDate); // Method to determine date range.

                if (cmbViewingOption.SelectedIndex == 0) // All forecasts to be displayed for selected cities.
                {
                    // Determining the date range of the requested forecasts if the user wants to see all forecasts for the selected cities.
                    requests = requests.OrderBy(d => d.Date).ToList();
                    DateTime start = requests.First().Date;
                    DateTime end = requests.Last().Date;
                    dateRange = GetDateRange(start, end);

                    Maximums(requests, dateRange); // Method to determine Records.
                }
                else
                {
                    Maximums(requests, dateRange); // Method to determine Records.
                }
            }
        }

        private void MultipleCityViewer_Load(object sender, EventArgs e) 
        {
            ClearAllOutputs();
            btnPrintToFile.Hide();
            dtpStart.Value = DateTime.Now.AddDays(-1);

            //Populates the check box with the cities from the database.
            string cityName;
            try
            {
                clbCities.Items.Clear();
                using (StreamReader getCityNames = new StreamReader("Cities.txt"))
                {
                    while ((cityName = getCityNames.ReadLine()) != null)
                    {
                        clbCities.Items.Add(cityName);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error populating city names in multiple city viewer", "ERROR");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllOutputs();

            // Control functionality.
            btnConfirm.Show();
            btnPrintToFile.Hide();
            dtpStart.Value = DateTime.Now.AddDays(-1);
            dtpEnd.Value = DateTime.Now;
            

            // For loop to uncheck all items in the checkbox containing city names.
            for (int i = 0; i < clbCities.Items.Count; i++)
            {
                clbCities.SetItemChecked(i, false);
            }

            cmbViewingOption.SelectedIndex = -1;
            cmbViewingOption.Enabled = true;
            clbCities.Enabled = true;

            // DateTimePicker disables must be after resetting the viewing option index as changing that value re-enables them.
            dtpEnd.Enabled = false;
            dtpStart.Enabled = false;
        }

        private void btnPrintToFile_Click(object sender, EventArgs e)
        {
            // If...Else statement to check if there is valid data to print to file.
            if (rtbMaximums.Text.Equals(""))
            {
                MessageBox.Show("There is no valid data to print to file. Please select 'Confirm' with valid parameters before attempting to print the data to file.", "ERROR");
            }
            else
            {
                DateTime start = dtpStart.Value;
                DateTime end = dtpEnd.Value;
                List<Forecast> f = SelectedForecasts(start, end);

                f = f.OrderBy(d => d.Date).ToList(); // To get the date range.

                start = f.First().Date; // Determining the range of the forecasts.
                end = f.Last().Date;

                f = f.OrderBy(a => a.City).ThenBy(d => d.Date).ToList(); // To order properly for dipslay.

                List<string> citiesList = SelectedCities();
                string cities = "";
                bool first = true; // Neccessary for proper display.

                foreach (string city in citiesList)
                {
                    // To determine if the city is the first occurance of the record.
                    if (first == true)
                    {
                        cities = city;
                        first = false;
                    }
                    else
                    {
                        cities += $", {city}";
                    }
                }

                // try block to print to file.
                try
                {
                    using (StreamWriter writeToFile = new StreamWriter("MultiCityReport.txt", false))
                    {
                        writeToFile.WriteLine("Forecast Report:\n\n\n");
                        writeToFile.WriteLine("City/Cities: " + cities);
                        writeToFile.WriteLine($"{"Start Date:",-15}{start:dd/MM/yyyy}");
                        writeToFile.WriteLine($"{"End Date:",-15}{end:dd/MM/yyyy}");
                        writeToFile.WriteLine(rtbForecasts.Text);
                        writeToFile.WriteLine("\n\n\nRecords Report:\n\n\n");
                        writeToFile.WriteLine(rtbMaximums.Text);
                    }

                    MessageBox.Show("'Forecast Report' and 'Records Report' have been successfully printed to file.", "Success!"); // User validation.
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Unable to write MultiCity report to file.", "ERROR");
                }
            }
        }

        private void cmbViewingOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbViewingOption.SelectedIndex == 0)  // view all forecast data
            {
                dtpStart.Enabled = false;
                dtpEnd.Enabled = false;
            }
            else
            {
                dtpStart.Enabled = true;
                dtpEnd.Enabled = true;
            }
        }

        // Personal Defined Methods.

        // Method to determine date range.
        public List<DateTime> GetDateRange(DateTime startDate, DateTime endDate)
        {
            List<DateTime> dateRange = new List<DateTime>();

            bool dateEnd = false;

            DateTime dateStart = startDate;

            // While loop determining if end date is after start date.
            while (dateEnd != true)
            {

                if (dateStart <= endDate) // Checks if current date is before the end date.
                {
                    dateRange.Add(dateStart);
                }
                else
                {
                    dateEnd = true;
                }

                dateStart = dateStart.AddDays(1);
            }

            return dateRange;
        }

        // Method to clear all output fields.
        public void ClearAllOutputs()
        // method to clear all text boxes and checked items.
        {
            string headings = $"{"City",-20}{"Date",-20}{"Minimum Temperature (°C)",-30}" +
                $"{"Maximum Temperature (°C)",-30}{"Preciptation (%)",-30}" +
                $"{"Humidity (%)",-30}{"Windspeed (Km/h)",-30}" +
                $"\n_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _" +
                $" _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _" +
                $" _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _\n\n";


            rtbMaximums.Clear();
            rtbForecasts.Text = headings;
        }

        // Method to determine selected cities.
        private List<string> SelectedCities()
        {
            List<string> cities = new List<string>();

            foreach (var checkedCity in clbCities.CheckedItems) 
            {
                cities.Add(checkedCity.ToString());
            }

            return cities;

        }

        // Method to determine maximums.
        private void Maximums(List<Forecast> requests, List<DateTime> dateRange)
        {

            foreach (DateTime datePeriod in dateRange) // Iterates through each forecast in the selected date range
            {
                // Variable declarations neccessary for record value calculations and ouput.
                double recordMin = 999;
                string recordMinCity = "";


                double recordMax = -999;
                string recordMaxCity = "";


                double recordHumid = -999;
                string recordHumidCity = "";


                double recordPrecip = -999;
                string recordPrecipCity = "";


                double recordWind = -999;
                string recordWindCity = "";

                foreach (Forecast determineDailyRecords in requests)
                {
                    if (determineDailyRecords.Date.CompareTo(datePeriod) == 0)
                    {
                        // Determine daily minimum temperature
                        if (determineDailyRecords.MinTemp < recordMin)
                        {
                            recordMin = determineDailyRecords.MinTemp;
                            recordMinCity = determineDailyRecords.City;
                        }
                        else if (determineDailyRecords.MinTemp == recordMin)
                        {
                            recordMinCity += $", {determineDailyRecords.City}";
                        }

                        // Determine daily maximum temperature
                        if (determineDailyRecords.MaxTemp > recordMax)
                        {
                            recordMax = determineDailyRecords.MaxTemp;
                            recordMaxCity = determineDailyRecords.City;
                        }
                        else if (determineDailyRecords.MaxTemp == recordMax)
                        {
                            recordMaxCity += $", {determineDailyRecords.City}";
                        }

                        // Determine daily maximum precipitation
                        if (determineDailyRecords.Precipitation > recordPrecip)
                        {
                            recordPrecip = determineDailyRecords.Precipitation;
                            recordPrecipCity = determineDailyRecords.City;
                        }
                        else if (determineDailyRecords.Precipitation == recordPrecip)
                        {
                            recordPrecipCity += $", {determineDailyRecords.City}";
                        }

                        // Determine daily maximum humidity
                        if (determineDailyRecords.Humidity > recordHumid)
                        {
                            recordHumid = determineDailyRecords.Humidity;
                            recordHumidCity = determineDailyRecords.City;
                        }
                        else if (determineDailyRecords.Humidity == recordHumid)
                        {
                            recordHumidCity += $", {determineDailyRecords.City}";
                        }

                        // Determine daily maximum windspeed
                        if (determineDailyRecords.WindSpeed > recordWind)
                        {
                            recordWind = determineDailyRecords.WindSpeed;
                            recordWindCity = determineDailyRecords.City;
                        }
                        else if (determineDailyRecords.WindSpeed == recordWind)
                        {
                            recordWindCity += $", {determineDailyRecords.City}";
                        }
                    }
                }

                if (recordMin != 999) // Days with no forecast info will not be outputted.
                {
                    rtbMaximums.AppendText($"_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ \n\n" +
                    $"{"Date:",-6}{datePeriod.ToString("dd/MM/yyyy")} \n" +
                    $"{"Record Minimum Temperature(°C):",-35}{recordMin,-5} => {recordMinCity}\n" +
                    $"{"Record Maximum Temperature(°C):",-35}{recordMax,-5} => {recordMaxCity}\n" +
                    $"{"Record Precipitation(%):",-35}{recordPrecip,-5} => {recordPrecipCity}\n" +
                    $"{"Record Humidity(%):",-35}{recordHumid,-5} => {recordHumidCity}\n" +
                    $"{"Record Windspeed(Km/h):",-35}{recordWind,-5} => {recordWindCity}\n" +
                    $"_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ \n");
                }
            }
        }

        // Method to determine selected forecasts.
        private List<Forecast> SelectedForecasts(DateTime start, DateTime end)
        {
            List<Forecast> requests = new List<Forecast>();

            // try block to get the user's requested forecasts.
            try
            {
                using (StreamReader getCityForecasts = new StreamReader("Forecasts.txt"))
                {

                    requests = new List<Forecast>();

                    while (!getCityForecasts.EndOfStream)
                    {
                        var words = getCityForecasts.ReadLine().Split(',');
                        DateTime d = DateTime.ParseExact(words[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                        if (cmbViewingOption.SelectedIndex == 0) // Block to run if the user wants to see all forecasts for the specified cities.
                        {
                            if (clbCities.CheckedItems.Contains(words[0]))
                            {
                                Forecast f = new Forecast(words[0], d, Convert.ToDouble(words[2]), Convert.ToDouble(words[3]),
                                    Convert.ToDouble(words[4]), Convert.ToDouble(words[5]), Convert.ToDouble(words[6]));

                                requests.Add(f); // Adds requested forecasts to list of forecasts.
                            }
                        }
                        else // Block to run if the user wants to see forecasts between specified dates.
                        {
                            if (clbCities.CheckedItems.Contains(words[0]) && d.DayOfYear >= start.DayOfYear && d.DayOfYear <= end.DayOfYear)
                            {
                                Forecast f = new Forecast(words[0], d, Convert.ToDouble(words[2]), Convert.ToDouble(words[3]),
                                    Convert.ToDouble(words[4]), Convert.ToDouble(words[5]), Convert.ToDouble(words[6]));

                                requests.Add(f); // Adds requested forecasts to list of forecasts.
                            }
                        }
                    }

                    requests = requests.OrderBy(c => c.City).ThenBy(h => h.Date).ToList(); // Orders the list.
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error getting forecast data.", "ERROR");
            }

            return requests;
        }
    }
}
