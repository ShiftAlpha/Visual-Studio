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
using System.Runtime.DesignerServices;

namespace WeatherApp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            
            lblDate.Text = DateTime.Today.ToString("dd/MM/yyyy"); // Display of the current date.

            // If statement to alter the menu if the user is a non-admin user.
            if (Login.isAdmin == false)
            {
                btnEnterData.Hide();
                btnEditData.Hide();
                btnMultipleCities.Hide();
                btnOneCity.Text = "View Forecasts";
            }

        }
        
        // Form Event Methods
        private void btnEnterData_Click(object sender, EventArgs e)
        {
            this.Hide();

            DataCapture dataCapture = new DataCapture();
            dataCapture.ShowDialog();
            this.Show();
        }

        private void btnOneCity_Click(object sender, EventArgs e)
        {
            this.Hide();

            CityViewer cityViewer = new CityViewer();
            cityViewer.ShowDialog();
            this.Show();
        }

        private void btnMultipleCities_Click(object sender, EventArgs e)
        {
            this.Hide();

            MultipleCityViewer multipleCityViewer = new MultipleCityViewer();
            multipleCityViewer.ShowDialog();
            this.Show();
        }

        private void btnEditData_Click(object sender, EventArgs e)
        {
            this.Hide();

            EditForecasts editForecasts = new EditForecasts();
            editForecasts.ShowDialog();
            this.Show();
        }

        private void btnUpdateCities_Click(object sender, EventArgs e)
        {
            this.Hide();

            UpdateUserCities updateCities = new UpdateUserCities();
            updateCities.ShowDialog();
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            btnUpdateCities.Hide();

            // If statement to make neccessary changes to the menu for a non-admin user.
            if (Login.isAdmin == false)
            {
                btnEditData.Hide();
                btnMultipleCities.Hide();
                btnEnterData.Hide();

                btnUpdateCities.Show();
                btnUpdateCities.Location = new Point(270, 233);
                btnLogout.Location = new Point(270, 449);
            }
        }
    }
}
