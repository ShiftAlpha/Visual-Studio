using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace WeatherApp
{
    public partial class DataCapture : Form
    {
        
        public DataCapture()
        {
            InitializeComponent();
        }

        // Form Event Methods

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Return to the Menu.
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            // Variables used to capture data from input fields.
            string cityName = cmbCity.Text.ToString().Trim().ToUpper();
            DateTime date = dtpDate.Value;
            double minTemp = Convert.ToDouble(nupMinTemp.Value);
            double maxTemp = Convert.ToDouble(nupMaxTemp.Value);
            double precipitation = Convert.ToDouble(nupPrecipitation.Value);
            double humidity = Convert.ToDouble(nupHumidity.Value);
            double windSpeed = Convert.ToDouble(nupWindSpeed.Value);


            // Data validation controls.
            if (cmbCity.Text.Equals(""))
            {
                MessageBox.Show("Please select a city.", "ERROR");
            }

            else if (minTemp > maxTemp)
            {
                MessageBox.Show("Minimum Temperature cannot exceed Maximum Temperature.", "ERROR");
            }

            else
            {
                IsNewCity(); // Method to determine if the city choice of the user exists in the programs forecast data already.
                Forecast capturedForecast = new Forecast(cityName, date, minTemp, maxTemp, precipitation, humidity, windSpeed);
                List<Forecast> originalForecasts = new List<Forecast>();

                try
                {
                    using (StreamReader populateForecasts = new StreamReader("Forecasts.txt"))
                    {
                        string line;
                        while ((line = populateForecasts.ReadLine()) != null)
                        {
                            var details = line.Split(',');
                            DateTime d = DateTime.ParseExact(details[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                            Forecast f = new Forecast(details[0], d, Convert.ToDouble(details[2]),
                                Convert.ToDouble(details[3]), Convert.ToDouble(details[4]), Convert.ToDouble(details[5]), Convert.ToDouble(details[6]));
                            originalForecasts.Add(f);
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Error populating city forecasts.", "ERROR");
                }

                int exists = CheckIfForecastExists(originalForecasts, capturedForecast); // Determines if the forecast wanting to be captured already exists.

                // If statement will run if a forecast exists for the specified city on the specified date.
                if (exists != -1)
                {
                    OverwriteForecast(originalForecasts, capturedForecast, cityName, exists); // Method to overwrite the forecast.
                }
                else
                {
                    // try block to add a new forecast to the file if it does not overwrite another forecast.
                    try
                    {
                        using (StreamWriter writeForecasts = File.AppendText("Forecasts.txt"))
                        {
                            writeForecasts.WriteLine(capturedForecast.ToString());
                        }

                        MessageBox.Show("Forecast overwritten successfully.", "SUCCESS"); // User validation.
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show("Error writing updated forecasts to file.", "ERROR");
                    }
                }
            }
            ClearAll();
        }

        private void DataCapture_Load(object sender, EventArgs e)
        {
            // try block to populate city names to choose from.
            try
            {
                using (StreamReader cityReader = new StreamReader("Cities.txt"))
                {
                    string line;
                    while ((line = cityReader.ReadLine()) != null)
                    {
                        cmbCity.Items.Add(line); // Adds city to city combobox.
                    }
                }
            }
            catch (FileNotFoundException) 
            {
                MessageBox.Show("Error populating city names.","ERROR");
            }
        }

        // Personal Defined Methods.

        // Method to clear the text boxes
        private void ClearAll()
        {
            // Resetting input fields.
            cmbCity.SelectedIndex = -1;
            nupMinTemp.Value = 0;
            nupMaxTemp.Value = 0;
            nupPrecipitation.Value = 0;
            nupHumidity.Value = 0;
            nupWindSpeed.Value = 0;
            dtpDate.Value = DateTime.Now;
        }

        // Method to check if a forecast exists for the city and date the user is attempting to capture a forecast for.
        private int CheckIfForecastExists(List<Forecast> inForecastsList, Forecast forecastToCheck)
        {
            int exists = -1;
            bool exit = false;

            foreach (Forecast item in inForecastsList)
            {
                // It is necessary to convert both dates to strings because the 'forecastToCheck' will have a time component attatched
                // while the 'item' will not. .Net framework does not contain a function to remove the time part of a date directly.
                if (item.Date.ToString("dd/MM/yyyy").Equals(forecastToCheck.Date.ToString("dd/MM/yyyy")) && item.City.Equals(forecastToCheck.City))
                {
                    exists = inForecastsList.IndexOf(item);
                    exit = true;
                }
                else if (exit == false)
                {
                    exists = -1;
                }
            }
            return exists;
        }

        // Method to check if the city in the combobox already exists.
        private void IsNewCity()
        {
            bool isNew = true;
            string cityName = cmbCity.Text.ToString().ToUpper().Trim();

            // try block to determine if the user entered city already exists.
            try
            {
                using (StreamReader cityReader = new StreamReader("Cities.txt"))
                {
                    string line;

                    // Iterates through each line in the file.
                    while ((line = cityReader.ReadLine()) != null && isNew == true)
                    {
                        // If statement checks if the selected cityname exists in the file with all city names.
                        if (cityName.Equals(line))
                        {
                            isNew = false;
                        }
                    }
                }

                // If statement to run if the user typed city is a new city.
                if (isNew == true)
                {
                    // Writing the new city to the cities file.
                    using (StreamWriter addNewCity = File.AppendText("Cities.txt"))
                    {
                        addNewCity.WriteLine(cityName);
                        cmbCity.Items.Add(cityName);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error updating city information.","ERROR");
            }
        }

        // Method to overwrite the forecast.
        private void OverwriteForecast(List<Forecast> inForecast, Forecast capturedForecast, string cityName, int removeAtIndex)
        {
            DateTime date = dtpDate.Value;
            string dateString = date.ToString("dd/MM/yyyy");
            //__________________________________CODE ATTRIBUTION__________________________________\\

            // The following code is adapted from
            //https://stackoverflow.com/questions/3036829/how-do-i-create-a-message-box-with-yes-no-choices-and-a-dialogresult
            // The part of the code that was attributed was the DialogResult and the YesNo buttons on the message box.

            DialogResult dialogResult = MessageBox.Show($"A forecast already exists for {cityName} on {dateString}," +
                $" Would you like to overwrite it", "ALERT", MessageBoxButtons.YesNo); // Adding yes no buttons to the message box.

            // Runs if the user selects yes on the message box.
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show($"You have chosen to overwrite the forecast for {cityName} on {dateString}","ALERT"); // User action validation.

                inForecast.RemoveAt(removeAtIndex); // Removes the forecast to be overwritten.
                inForecast.Add(capturedForecast); // Adds the new forecast.

                using (StreamWriter writeForecast = new StreamWriter("Forecasts.txt", false))
                {
                    // Iterates through each forecast in the inForecast list.
                    foreach (Forecast fo in inForecast)
                    {
                        writeForecast.WriteLine(fo.ToString()); // Writes the forecast to file.
                    }
                }

                MessageBox.Show("Forecast overwritten successfully.","SUCCESS"); // User validation.
            }
            // Runs of the user selects no on the message box.
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show($"You have chosen not to overwrite the forecast for {cityName} on {dateString}","ALERT");
            }
        }
    }
}
