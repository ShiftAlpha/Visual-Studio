using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace WeatherApp
{
    public partial class EditForecasts : Form
    {
        DateTime selectedIndexDate;
        List<Forecast> cityForecasts;
        public EditForecasts()
        {
            InitializeComponent();
        }

        // Form Event Methods
        private void EditForecasts_Load(object sender, EventArgs e)
        {
            string cityName;
            ClearAll();
            
            // try block to populate cities into the city combobox. 
            try
            {
                using (StreamReader getCityNames = new StreamReader("Cities.txt"))
                {
                    while ((cityName = getCityNames.ReadLine()) != null)
                    {
                        cmbCity.Items.Add(cityName);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error populating city names", "ERROR");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Returns to Menu.
        }

        private void cmbChoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If...Else statement to take action depending on user's choice of view.
            if (cmbChoices.SelectedIndex == 0)  // view all forecast data
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

        private void btnConfirmChoices_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStart.Value;
            DateTime endDate = dtpEnd.Value;

            // User input checks.
            if (cmbCity.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a city.", "ERROR");
            }
            else if (startDate > endDate)
            {
                MessageBox.Show("Please ensure your start date is before your end date.","ERROR");
            }
            else if (cmbChoices.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a viewing option.","ERROR");
            }
            else
            {
                ClearControl();
                // try block to populate rich text boxes.
                try
                {
                    // If...Else statement to populate output fields based on the user's viewing option.
                    if (cmbChoices.SelectedIndex == 0)
                    {
                        PopulateView(); // Method used when all forecasts want to be viewed.
                    }
                    else
                    {
                        PopulateView(startDate, endDate); // Method used when a date range is specified.
                    }

                    if (cityForecasts.Count == 0)
                    {
                        MessageBox.Show("No forecast data found, please broaden your search parameters.","ERROR");
                    }
                    else
                    {
                        // Button control functionality.
                        dtpStart.Enabled = false;
                        dtpEnd.Enabled = false;
                        cmbChoices.Enabled = false;
                        cmbCity.Enabled = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error getting forecasts.","ERROR");
                }
            }
        }

        private void lstbForecasts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int forecastIndex = lstbForecasts.SelectedIndex;

            // If statements to validate the users actions and input.
            if (forecastIndex < 0)
            {
                MessageBox.Show("Please select item","ERROR");
            }
            else if (lstbForecasts.Items.Count == 1)
            {
                MessageBox.Show("Please press the confirm button to view data","ERROR");
            }
            else if (forecastIndex == 0)
            {
                lstbForecasts.SelectedIndex = 1; // Prevents the user from selecting the headings.
            }
            else if (forecastIndex + 1 == (lstbForecasts.Items.Count))
            {
                forecastIndex = lstbForecasts.Items.Count - 1; // Required if the user selects the last item in the list.
            }

            // If statement to run if the forecast index is acceptable.
            if (forecastIndex > 0)
            {
                // Enabling controls.
                forecastIndex = forecastIndex - 1; // Required to get the correct index of the forecast due to the headings being the first item in the list box.
                btnConfirmChanges.Enabled = true;
                btnDeleteForecast.Enabled = true;
                nupMinTemp.Enabled = true;
                nupMaxTemp.Enabled = true;
                nupHumidity.Enabled = true;
                nupPrecipitation.Enabled = true;
                nupWindSpeed.Enabled = true;

                // Creating a new forecast object of the selected item from lstForecasts.
                Forecast f = new Forecast(
                    cityForecasts.ElementAt(forecastIndex).City,
                    cityForecasts.ElementAt(forecastIndex).Date,
                    cityForecasts.ElementAt(forecastIndex).MinTemp,
                    cityForecasts.ElementAt(forecastIndex).MaxTemp,
                    cityForecasts.ElementAt(forecastIndex).Precipitation,
                    cityForecasts.ElementAt(forecastIndex).Humidity,
                    cityForecasts.ElementAt(forecastIndex).WindSpeed);

                // Updating the numeric up-downs to contain the values of the forecast selected.
                nupMinTemp.Value = (decimal)f.MinTemp;
                nupMaxTemp.Value = (decimal)f.MaxTemp;
                nupHumidity.Value = (decimal)f.Humidity;
                nupPrecipitation.Value = (decimal)f.Precipitation;
                nupWindSpeed.Value = (decimal)f.WindSpeed;
                selectedIndexDate = f.Date;
            }
        }

        private void btnConfirmChanges_Click(object sender, EventArgs e)
        {
            double minTemp = Convert.ToDouble(nupMinTemp.Value);
            double maxTemp = Convert.ToDouble(nupMaxTemp.Value);

            // If...Else statement to validate user input.
            if (minTemp > maxTemp)
            {
                MessageBox.Show("Minimum Temperature cannot exceed Maximum Temperature!");
            }
            else
            {
                DateTime start = dtpStart.Value;
                DateTime end = dtpEnd.Value;
                List<Forecast> editCity = new List<Forecast>();
                int indexToBeRemoved = lstbForecasts.SelectedIndex - 1; // Index of the forecast in the List is 1 less due to the headings being in the list box.
                string city = cmbCity.SelectedItem.ToString().Trim(); // Gets the name of the selected city.

                // Creates a new Forecast object using the data edited by the user.
                Forecast capturedForecast = new Forecast(city, selectedIndexDate, Convert.ToDouble(nupMinTemp.Value), Convert.ToDouble(nupMaxTemp.Value),
                    Convert.ToDouble(nupPrecipitation.Value), Convert.ToDouble(nupHumidity.Value), Convert.ToDouble(nupWindSpeed.Value));

                editCity = OverwriteForecast(cityForecasts, capturedForecast, indexToBeRemoved); // Method to overwrite the forecast.

                List<Forecast> allForecasts = new List<Forecast>(); // List of all forecasts.
                allForecasts = AllForecasts(); // Adding all forecasts to list of all forecasts.

                allForecasts.RemoveAll(r => r.City == city); // Removes all forecasts for the city being edited.

                // try block to add back the altered city's forecasts.
                try
                {
                    foreach (Forecast selectedCityForecasts in editCity)
                    {
                        allForecasts.Add(selectedCityForecasts);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show($"Error updating city forecasts for {city}", "ERROR");
                }

                // try block to rewrite the forecast file with the updated data.
                try
                {
                    using (StreamWriter updateForecasts = new StreamWriter("Forecasts.txt", false))
                    {
                        foreach (Forecast item in allForecasts)
                        {
                            updateForecasts.WriteLine(item.ToString());
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Error writing forecasts to file.", "ERROR");
                }

                ClearControl(); // Clear output fields. 

                // Updating the output to show the user the result of their actions.
                // If...Else statement controlled by user's choice of viewing option.
                if (cmbChoices.SelectedIndex == 0) // User wants to see all forecast data for the specific city.
                {
                    PopulateView(); // All forecasts are being shown.
                }
                else
                {
                    PopulateView(start, end); // Forecasts for specific dates are being shown.
                }
            }
        }

        private void btnDeleteForecast_Click(object sender, EventArgs e)
        {
            // Variable declarations.
            List<Forecast> deleteCityForecast = new List<Forecast>();
            int indexToBeRemoved = lstbForecasts.SelectedIndex - 1;
            List<Forecast> allForecasts = new List<Forecast>();
            DateTime start = dtpStart.Value;
            DateTime end = dtpEnd.Value;
            string city = cmbCity.SelectedItem.ToString();

            deleteCityForecast = DeleteForecast(cityForecasts, indexToBeRemoved); // Method to delete the selected forecast & return the u[pdated list of city forecasts for that city.
            allForecasts = AllForecasts(); // Method to get list of all forecasts.

            allForecasts.RemoveAll(r => r.City == city); // Removes all records of the selected city from allForecasts list.

            // try block to add updated list of city forecasts back to allForecasts.
            try
            {
                foreach (Forecast selectedCityForecasts in deleteCityForecast)
                {
                    allForecasts.Add(selectedCityForecasts);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error updating forecast data.", "ERROR");
            }

            // try block to write the forecast data to file.
            try
            {
                using (StreamWriter updateForecasts = new StreamWriter("Forecasts.txt", false))
                {
                    foreach (Forecast item in allForecasts)
                    {
                        updateForecasts.WriteLine(item.ToString());
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error writing forecast data to file.", "ERROR");
            }

            ClearControl(); // Clear output fields.

            // Updating the output to show the user the result of their actions.
            // If...Else statement controlled by user's choice of viewing option.
            if (cmbChoices.SelectedIndex == 0) // User wants to see all forecast data for the specific city.
            {
                PopulateView(); // All forecasts are being shown.
            }
            else
            {
                PopulateView(start, end); // Forecasts for specific dates are being shown.
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }


        // Personal Defined Methods

        // Method to populate view with specific date parameters.
        private void PopulateView(DateTime start, DateTime end)
        {
            // try block to get city forecasts.
            try
            {
                cityForecasts = new List<Forecast>();

                using (StreamReader getCityForecasts = new StreamReader("Forecasts.txt"))
                {
                    while (!getCityForecasts.EndOfStream)
                    {
                        var words = getCityForecasts.ReadLine().Split(',');
                        DateTime d = DateTime.ParseExact(words[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                        if (words[0].Equals(cmbCity.SelectedItem.ToString())) //&& d.DayOfYear >= start.DayOfYear && d.DayOfYear <= end.DayOfYear)
                        {
                            Forecast f = new Forecast(words[0], d, Convert.ToDouble(words[2]), Convert.ToDouble(words[3]),
                                Convert.ToDouble(words[4]), Convert.ToDouble(words[5]), Convert.ToDouble(words[6]));

                            cityForecasts.Add(f); // Adds requested forecasts to list of forecasts.
                        }
                    }

                    cityForecasts = cityForecasts.OrderBy(c => c.Date).ToList(); // Orders cityForecasts by date.

                    // Foreach loop to display forcast data.
                    foreach (Forecast fc in cityForecasts)
                    {
                        if (fc.Date.DayOfYear >= start.DayOfYear && fc.Date.DayOfYear <= end.DayOfYear)
                        {
                            lstbForecasts.Items.Add(fc.DisplayForEdit()); // Displays the forecast in the list box.
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error getting and displaying forecasts.", "ERROR");
            }
        }

        // Method to populate view with all forecasts.
        private void PopulateView()
        {
            // try block to get and display city forecasts.
            try
            {
                cityForecasts = new List<Forecast>();
                using (StreamReader getCityForecasts = new StreamReader("Forecasts.txt"))
                {
                    while (!getCityForecasts.EndOfStream)
                    {
                        var words = getCityForecasts.ReadLine().Split(',');

                        if (words[0].Equals(cmbCity.Text))
                        {
                            Forecast f = new Forecast(words[0], DateTime.ParseExact(words[1], "dd/MM/yyyy", CultureInfo.InvariantCulture), Convert.ToDouble(words[2]), Convert.ToDouble(words[3]),
                            Convert.ToDouble(words[4]), Convert.ToDouble(words[5]), Convert.ToDouble(words[6]));

                            cityForecasts.Add(f); // Adds requested forecasts to list of forecasts.
                        }
                    }

                    cityForecasts = cityForecasts.OrderBy(c => c.Date).ToList(); // Orders cityForecasts by date.

                    // Foreach loop to display city forecasts.
                    foreach (Forecast fc in cityForecasts)
                    {
                        lstbForecasts.Items.Add(fc.DisplayForEdit()); // Displays the forecast in the list box.
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error getting and displaying forecasts.", "ERROR");
            }
        }

        // Method to clear all.
        private void ClearAll()
        {
            // Variable resets.
            dtpStart.Value = DateTime.Now.AddDays(-1);
            dtpEnd.Value = DateTime.Now;
            lstbForecasts.Items.Clear();
            nupMinTemp.Value = 0;
            nupMaxTemp.Value = 0;
            nupHumidity.Value = 0;
            nupPrecipitation.Value = 0;
            nupWindSpeed.Value = 0;

            lstbForecasts.Items.Clear();
            lstbForecasts.Items.Add($"{"Date",-20}{"Minimum Temperature (°C)",-30}{"Temperature (°C)",-30}{"Precipitation (%)",-30}{"Humidity (%)",-30}{"Windspeed (Km/h)",-30}");
            cmbChoices.SelectedIndex = -1;
            cmbCity.SelectedIndex = -1;

            // Control resets.
            dtpStart.Enabled = false;
            dtpEnd.Enabled = false;

            nupMinTemp.Enabled = false;
            nupMaxTemp.Enabled = false;
            nupHumidity.Enabled = false;
            nupPrecipitation.Enabled = false;
            nupWindSpeed.Enabled = false;

            btnConfirmChanges.Enabled = false;
            btnDeleteForecast.Enabled = false;

            cmbChoices.Enabled = true;
            cmbCity.Enabled = true;
        }

        // Method to get a list of all forecasts.
        private List<Forecast> AllForecasts()
        {
            List<Forecast> all = new List<Forecast>();

            // try block to get all forecast data and populate into a list.
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
                        all.Add(f);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error getting forecast information.","ERROR");
            }

            return all; // Returning the list with all forecast information.
        }

        // Method to overwrite a forecast.
        private List<Forecast> OverwriteForecast(List<Forecast> inForecast, Forecast capturedForecast, int removeAtIndex)
        {
            // try block to overwrite the selected forecast.
            try
            {
                string deletedForecastDate = inForecast.ElementAt(removeAtIndex).Date.ToString("dd/MM/yyyy");
                string deletedForecastCity = inForecast.ElementAt(removeAtIndex).City;
                inForecast.RemoveAt(removeAtIndex);
                inForecast.Add(capturedForecast);
                inForecast = inForecast.OrderBy(c => c.Date).ToList(); // Orders list by date.

                
                MessageBox.Show($"Forecast for {deletedForecastCity} on {deletedForecastDate} successfully overwritten.","SUCCESS"); // User validation.
            }
            catch (Exception)
            {
                MessageBox.Show("Error overwriting forecast data.","ERROR");
            }
            return inForecast;
        }

        // Method to delete a forecast.
        private List<Forecast> DeleteForecast(List<Forecast> inForecast, int removeAtIndex)
        {
            //try block to delete a forecast.
            try
            {
                string deletedForecastDate = inForecast.ElementAt(removeAtIndex).Date.ToString("dd/MM/yyyy"); // Gets the date of the forecast being removed.
                string deletedForecastCity = inForecast.ElementAt(removeAtIndex).City; // Gets the city name of the forecast being removed.
                inForecast.RemoveAt(removeAtIndex); // Removes the correct forecast from the list.
                inForecast = inForecast.OrderBy(c => c.Date).ToList(); // Orders by date.

                MessageBox.Show($"Forecast for {deletedForecastCity} on {deletedForecastDate} successfully deleted.","SUCCESS"); // User validation
            }
            catch (Exception)
            {
                MessageBox.Show("Error deleting forecast data.","ERROR");
            }
            return inForecast;
        }
        
        // Method to control the clearing of controls.
        private void ClearControl()
        {
            int viewingOption = cmbChoices.SelectedIndex;
            int cityChoice = cmbCity.SelectedIndex;
            DateTime startDate = dtpStart.Value;
            DateTime endDate = dtpEnd.Value;
            ClearAll();
            cmbCity.Enabled = false;
            cmbChoices.Enabled = false;
            cmbChoices.SelectedIndex = viewingOption;
            cmbCity.SelectedIndex = cityChoice;
            dtpStart.Value = startDate;
            dtpEnd.Value = endDate;
        }
    }
}

