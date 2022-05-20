using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class CityViewer : Form
    {
        public CityViewer()
        {
            InitializeComponent();

            // If statement to check if the user is an admin and adjust form text accordingly.
            if (Login.isAdmin == false)
            {
                this.Text = "View Forecasts";
            }
        }

        // Form Event methods.

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Returns the user to the Menu.
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Date values needed for validation and date range calculation.
            DateTime startDate = dtpStart.Value;
            DateTime endDate = dtpEnd.Value;

            // If statements to validate user input.
            if (cmbCity.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a city.","ERROR");
            }
            else if (startDate > endDate)
            {
                MessageBox.Show("Please ensure your start date is before your end date.","ERROR");
            }
            else
            {
                ClearAllOutput(); // Clears the output fields.

                // try block to display all outputs to the user.
                try
                {
                    List<Forecast> requests = new List<Forecast>(); // List of forecasts requested by the user.

                    // If...Else statement to determine which method to use to get the user's requested forecasts.
                    if (cmbViewingOption.SelectedIndex == 0)
                    {
                        requests = GetForecasts(requests); // View all forecasts.
                    }
                    else
                    {
                        requests = GetForecasts(requests, startDate, endDate); // View forecasts between selected dates.
                    }

                    // If...Else statement to control if no forecasts are found.
                    if (requests.Count == 0)
                    {
                        MessageBox.Show("No forecasts could be found, try expanding your search parameters or selecting a different city.","ERROR");
                    }
                    else
                    {
                        Maximums(requests); // Determines the maximum values from the user's requested forecasts.

                        // Foreach loop to iterate through and display the users requested forecasts.
                        foreach (Forecast acceptedForecast in requests)
                        {
                            rtbForecasts.Text += acceptedForecast.DisplayListSingleCity();
                            rtbForecasts.Text += "\n_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _" +
                                " _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _" +
                                " _ _ _ _ _ _ _ _ _ _ _ _\n\n";
                        }

                        // If statement to show the print to file functionality if the user is an admin.
                        if (Login.isAdmin == true)
                        {
                            btnConfirm.Hide(); // Hiding the confirm button.
                            btnPrintToFile.Show(); // Showing the print to file button.
                            btnPrintToFile.Location = new Point(369, 81); // Setting the print to file button to the location of the confirm button.
                            btnPrintToFile.Enabled = true;
                        }

                        // Control functionality for all users.
                        cmbCity.Enabled = false;
                        cmbViewingOption.Enabled = false;
                        dtpEnd.Enabled = false;
                        dtpStart.Enabled = false;
                        btnClear.Enabled = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error fetching and displaying the user's requested forecasts.", "ERROR");
                }
            }
        }

        private void CityViewer_Load(object sender, EventArgs e)
        {
            btnPrintToFile.Hide(); // Hides the print to file button.
            ClearAllOutput();
            string cityName;
            dtpStart.Value = dtpStart.Value.AddDays(-1); // This is to ensure the start date is before the end date.

            // try block to populate cities depending on if the user is an admin or not.
            try
            {
                // Admins will see all cities here.
                if (Login.isAdmin == true)
                {
                    using (StreamReader getCityNames = new StreamReader("Cities.txt"))
                    {
                        while ((cityName = getCityNames.ReadLine()) != null)
                        {
                            cmbCity.Items.Add(cityName);
                        }
                    }
                }
                // User will see only their favourite cities.
                else
                {
                    using (StreamReader getUserCities = new StreamReader("UserInfo.txt"))
                    {
                        while ((!getUserCities.EndOfStream))
                        {
                            var words = getUserCities.ReadLine().Split(',');

                            //If statement to get the favourite cities using the user's username.
                            if (words[0].Equals(Login.getUsername))
                            {
                                for (int i = 1; i < words.Length; i++)
                                {
                                    cmbCity.Items.Add(words[i]); // Adding the user's favourite cities to the city choices.
                                }
                            }

                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error populating city names in single city viewer!", "ERROR");
            }
        }

        private void btnPrintToFile_Click(object sender, EventArgs e)
        {
            // try block to write the report data to file.
            try
            {
                using (StreamWriter writeToFile = new StreamWriter("SingleCityReport.txt", false))
                {
                    writeToFile.WriteLine("Forecast Report:\n\n\n");
                    writeToFile.WriteLine(rtbForecasts.Text);
                    writeToFile.WriteLine("\n\n\nRecords Report:\n\n\n");
                    writeToFile.WriteLine(rtbMaximums.Text);
                }

                MessageBox.Show("'Forecast Report' and 'Records Report' have been successfully printed to file.", "Success!"); // User validation message.
            }
            catch (Exception)
            {
                MessageBox.Show("Error writing single city reports to file.", "ERROR");
            }
        }

        private void btnCLear_Click(object sender, EventArgs e)
        {
            ClearAllOutput(); // Method to clear all the output fields.
            btnPrintToFile.Hide();
            btnConfirm.Show();
            btnConfirm.Enabled = true;
            dtpStart.Value = DateTime.Now.AddDays(-1);
            dtpEnd.Value = DateTime.Now;

            // Resetting of combo boxes.
            cmbCity.SelectedIndex = -1;
            cmbViewingOption.SelectedIndex = -1; // This needs to be before the .Enable methods of the dates. 
                                                 // Changing selected index has an effect on if it is enabled or not.

            cmbCity.Enabled = true;
            cmbViewingOption.Enabled = true;
            dtpEnd.Enabled = false;
            dtpStart.Enabled = false;
            btnClear.Enabled = false;
        }

        private void cmbViewingOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            // IF...Else statement to check the user's viewing option choice.
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

        // Method to determine the Maximum values from the forecast data.
        private void Maximums(List<Forecast> inForecasts)
        {
            // Variable declarations
            string minTempRecordDate = "";
            bool minTeFirst = true;
            double minTempRecord = inForecasts.Min(minT => minT.MinTemp);

            string maxTempRecordDate = "";
            bool maxTeFirst = true;
            double maxTempRecord = inForecasts.Max(maxT => maxT.MaxTemp);

            string precipRecordDate = "";
            bool precipFirst = true;
            double precipitationRecord = inForecasts.Max(precip => precip.Precipitation);

            string humidRecordDate = "";
            bool humidFirst = true;
            double humidityRecord = inForecasts.Max(maxHumid => maxHumid.Humidity);

            string windRecordDate = "";
            bool windFirst = true;
            double windspeedRecord = inForecasts.Max(maxWind => maxWind.WindSpeed);

            // Foreach loop to iterate through all accepted forecasts to determine records.
            foreach (Forecast detRecords in inForecasts)
            {
                // Determining minimum temperature record.
                if (detRecords.MinTemp == minTempRecord)
                {
                    if (minTeFirst == true)
                    {
                        minTempRecordDate = detRecords.Date.ToString("dd/MM/yyyy");
                        minTeFirst = false;
                    }
                    else if (minTeFirst == false)
                    {
                        minTempRecordDate += $", {detRecords.Date.ToString("dd/MM/yyyy")}";
                    }
                }

                // Determining maximum temperature record.
                if (detRecords.MaxTemp == maxTempRecord)
                {
                    if (maxTeFirst == true)
                    {
                        maxTempRecordDate = detRecords.Date.ToString("dd/MM/yyyy");
                        maxTeFirst = false;
                    }
                    else if (maxTeFirst == false)
                    {
                        maxTempRecordDate += $", {detRecords.Date.ToString("dd/MM/yyyy")}";
                    }
                }

                // Determining precipitation record.
                if (detRecords.Precipitation == precipitationRecord)
                {
                    if (precipFirst == true)
                    {
                        precipRecordDate = detRecords.Date.ToString("dd/MM/yyyy");
                        precipFirst = false;
                    }
                    else if (precipFirst == false)
                    {
                        precipRecordDate += $", {detRecords.Date.ToString("dd/MM/yyyy")}";
                    }
                }

                // Determining humdidity record.
                if (detRecords.Humidity == humidityRecord)
                {
                    if (humidFirst == true)
                    {
                        humidRecordDate = detRecords.Date.ToString("dd/MM/yyyy");
                        humidFirst = false;
                    }
                    else if (precipFirst == false)
                    {
                        precipRecordDate += $", {detRecords.Date.ToString("dd/MM/yyyy")}";
                    }
                }

                // Determining windspeed record.
                if (detRecords.WindSpeed == windspeedRecord)
                {
                    if (windFirst == true)
                    {
                        windRecordDate = detRecords.Date.ToString("dd/MM/yyyy");
                        windFirst = false;
                    }
                    else if (windFirst == false)
                    {
                        windRecordDate += $", {detRecords.Date.ToString("dd/MM/yyyy")}";
                    }
                }
            }

            // Output for records.
            rtbMaximums.AppendText($"\n_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _\n\n" +
                       $"{"Record Minimum Temperature(°C):",-35}{minTempRecord,-15}{minTempRecordDate}\n" +
                       $"{"Record Maximum Temperature(°C):",-35}{maxTempRecord,-15}{maxTempRecordDate}\n" +
                       $"{"Record Precipitation(%):",-35}{precipitationRecord,-15}{precipRecordDate}\n" +
                       $"{"Record Humidity(%):",-35}{humidityRecord,-15}{humidRecordDate}\n" +
                       $"{"Record Windspeed(Km/h):",-35}{windspeedRecord,-15}{windRecordDate}\n" +
                       $"_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ \n");
        }

        // Method to get city forecasts when a date range is specified.
        private List<Forecast> GetForecasts(List<Forecast> inForecasts, DateTime start, DateTime end)
        {
            // try block to get city forecasts.
            try
            {
                using (StreamReader getCityForecasts = new StreamReader("Forecasts.txt"))
                {
                    while (!getCityForecasts.EndOfStream)
                    {
                        var words = getCityForecasts.ReadLine().Split(',');
                        DateTime d = DateTime.ParseExact(words[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                        if (words[0].Equals(cmbCity.SelectedItem.ToString()) && d.DayOfYear >= start.DayOfYear && d.DayOfYear <= end.DayOfYear) // d.AddDays(-1) is required becuase of the time component of the date.
                        {
                            Forecast f = new Forecast(words[0], d, Convert.ToDouble(words[2]), Convert.ToDouble(words[3]),
                                Convert.ToDouble(words[4]), Convert.ToDouble(words[5]), Convert.ToDouble(words[6]));

                            inForecasts.Add(f); // Adds requested forecasts to list of forecasts.
                        }
                    }

                    inForecasts = inForecasts.OrderBy(c => c.Date).ToList(); // Orders the forecasts by date.
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error adding requested forecasts", "ERROR");
            }
            
            return inForecasts;
        }

        // Method to get city forecasts when all forecasts are wanted.
        private List<Forecast> GetForecasts(List<Forecast> inForecasts)
        {
            // try block to get city forecasts.
            try
            {
                using (StreamReader getCityForecasts = new StreamReader("Forecasts.txt"))
                {
                    while (!getCityForecasts.EndOfStream)
                    {
                        var words = getCityForecasts.ReadLine().Split(',');
                        DateTime d = DateTime.ParseExact(words[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                        if (words[0].Equals(cmbCity.SelectedItem.ToString()))
                        {
                            Forecast f = new Forecast(words[0], d, Convert.ToDouble(words[2]), Convert.ToDouble(words[3]),
                                Convert.ToDouble(words[4]), Convert.ToDouble(words[5]), Convert.ToDouble(words[6]));

                            inForecasts.Add(f); // Adds requested forecasts to list of forecasts.
                        }
                    }

                    inForecasts = inForecasts.OrderBy(c => c.Date).ToList(); // Orders forecasts by date.
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error adding requested forecasts", "ERROR");
            }
            return inForecasts;
        }

        // method to clear all text boxes and checked items.
        private void ClearAllOutput()
        {
            // Functionality to populate rich text boxes with headings.
            string headings = $"{"Date",-20}{"Minimum Temperature (°C)",-30}" +
                $"{"Maximum Temperature (°C)",-30}{"Preciptation (%)",-30}" +
                $"{"Humidity (%)",-30}{"Windspeed (Km/h)",-30}" +
                $"\n_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _" +
                $" _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ " +
                $"_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ \n\n";

            rtbForecasts.Text = headings;
            rtbMaximums.Text = $"{"Record",-35}{"Value",-15}{"Date/Dates",-20}\n\n";
        }
    }
    
}