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

namespace WeatherApp
{
    public partial class UpdateUserCities : Form
    {
        public UpdateUserCities()
        {
            InitializeComponent();
        }

        // Form Event Methods.
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Returns to Menu.
        }

        private void UpdateUserCities_Load(object sender, EventArgs e)
        {
            // try block to populate all existing cities into lstAllCities.
            try
            {
                string cityName = "";
                using (StreamReader getCityNames = new StreamReader("Cities.txt"))
                {
                    while ((cityName = getCityNames.ReadLine()) != null)
                    {
                        lstAllCities.Items.Add(cityName);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error adding cities to all cities in update user cities", "ERROR");
            }

            // try block to populate the user's favourited cities into lstUserFavourites.
            try
            {
                using (StreamReader getUserCities = new StreamReader("UserInfo.txt"))
                {
                    while (!getUserCities.EndOfStream)
                    {
                        var words = getUserCities.ReadLine().Split(',');

                        if (words[0].Equals(Login.getUsername))
                        {
                            for (int i = 1; i < words.Length; i++) // i = 1 so the username is not added to the list box.
                            {
                                lstUserFavourites.Items.Add(words[i]);
                            }
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error adding user favourite cities.","ERROR");
            }
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            // If statement to check if the user is trying to add an already favourited city.
            if (lstUserFavourites.Items.Contains(lstAllCities.SelectedItem))
            {
                MessageBox.Show($"{lstAllCities.SelectedItem} is already one of your favourite cities!");
            }
            else
            {
                lstUserFavourites.Items.Add(lstAllCities.SelectedItem);
                lstAllCities.ClearSelected();
                btnAddCity.Enabled = false;
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstUserFavourites.Items.Remove(lstUserFavourites.SelectedItem); // Removes the selected item from the user's list of favourite cities.
            lstUserFavourites.ClearSelected();
            btnRemove.Enabled = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // If statement to check if the user has at least one favourite city.
            if (lstUserFavourites.Items.Count == 0)
            {
                MessageBox.Show("You need to select at least one city as a favourite!");
            }
            else
            {
                UpdateUserInfo(); // Method to update the user's favourite cities.
                MessageBox.Show("User Favourite Cities successfully updated!");
            }
            
        }

        private void lstAllCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstUserFavourites.ClearSelected();
            btnAddCity.Enabled = true;
            btnRemove.Enabled = false;
        }

        private void lstUserFavourites_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAllCities.ClearSelected();
            btnAddCity.Enabled = false;
            btnRemove.Enabled = true;
        }

        // Personal Defined Methods.
        private void UpdateUserInfo()
        {
            List<String> userFavourites = new List<string>();
            string updatedUser = Login.getUsername;

            // try block to update user information.
            try
            {
                using (StreamReader readFavourites = new StreamReader("UserInfo.txt"))
                {
                    while (!readFavourites.EndOfStream)
                    {
                        string line = readFavourites.ReadLine();
                        if (!line.Contains(Login.getUsername))
                        {
                            userFavourites.Add(line);
                        }
                    }
                }

                foreach (var selected in lstUserFavourites.Items)
                {
                    updatedUser += $",{selected}"; // The comma is a delimeter in the file where the data is stored.
                }

                userFavourites.Add(updatedUser);

                using (StreamWriter writeUpdated = new StreamWriter("UserInfo.txt",false))
                {
                    foreach (var item in userFavourites)
                    {
                        writeUpdated.WriteLine(item);
                    }
                }
                
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error updating user's favourite cities.", "ERROR");
            }
        }
    }
}
