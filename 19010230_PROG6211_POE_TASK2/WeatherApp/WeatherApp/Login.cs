using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static bool isAdmin; // Returns the admin status of the user (True or False).

        public static string getUsername; // Returns the username of the user.

        // Form Event Methods
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.ToString().Trim(); // Username is kept as case-sensitive for extra security.
            string password = txtPassword.Text.ToString();
            bool flag = false; // Flag to determine if the "No username or password matches..." block will run.


            if (username.Equals("") || password.Equals("")) // Checks against invalid input.
            {
                MessageBox.Show("Please ensure to enter both a valid username and valid password!","VERIFICATION ERROR");
                txtUsername.Clear();
                txtPassword.Clear();
                flag = true;
            }
            else
            {
                // try block to validate username and password.
                try
                {
                    using (StreamReader loginDetails = new StreamReader("LoginInfo.txt"))
                    {
                        string line;
                        while ((line = loginDetails.ReadLine()) != null && flag == false)
                        {
                            var words = line.Split(',');

                            if (username.Equals(words[0]) && password.Equals(words[1]))
                            {
                                // If statements to provide the appropriate welcome message.
                                if (words[2].Equals("1"))
                                {
                                    MessageBox.Show($"Welcome, Admin: {username}","Welcome!");
                                    flag = true;
                                    isAdmin = true; // Important for determining user priviledges and functionality.
                                }
                                else if (words[2].Equals("0"))
                                {
                                    MessageBox.Show($"Welcome, user: {username}","Welcome!");
                                    flag = true;
                                    isAdmin = false; // Important for determining user priviledges and functionality.
                                    getUsername = username; // Used to personalise the user experience and to get user specific information.
                                }

                                // Functionality to open the menu form and hide the current form.
                                txtPassword.Clear();
                                txtUsername.Clear();
                                this.Hide();
                                Menu menu = new Menu();
                                menu.ShowDialog();
                                this.Show();
                            }
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Failed to validate user login.","ERROR");
                }

                // If statement in the event that the user's inputted login details are not found on file.
                if (flag == false)
                {
                    MessageBox.Show("No user data matches the username password combination!","VALIDATION ERROR");
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();

            MessageBox.Show("All text fields cleared!","ALERT!"); // Response to user action.
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using the Weather Forecaster!","Exit");
            this.Close();
            Application.Exit(); // Safe exit of the application.
        }

        private void Login_Load(object sender, EventArgs e)
        {
            PopulateFields(); // Method to populate dummy data.
        }

        // Personal Defined Methods.

        // Captures and populates the dummy data, used for testing the program.
        public void PopulateFields()
        {
            //MessageBox.Show("populate fields", "test"); // Used when testing the program.
            try
            {
                // Populates forecast dummy data.
                using (StreamWriter writeForecasts = new StreamWriter("Forecasts.txt", false))
                {
                    writeForecasts.WriteLine("DURBAN,15/06/2020,15,23,90,85,15");
                    writeForecasts.WriteLine("DURBAN,16/06/2020,18,28,60,83,4");
                    writeForecasts.WriteLine("DURBAN,17/06/2020,17,26,5,78,11");

                    writeForecasts.WriteLine("JOHANNESBURG,15/06/2020,10,29,0,43,19");
                    writeForecasts.WriteLine("JOHANNESBURG,16/06/2020,15,22,20,53,4");
                    writeForecasts.WriteLine("JOHANNESBURG,17/06/2020,13,26,3,50,11");

                    writeForecasts.WriteLine("CAPE TOWN,15/06/2020,10,29,0,43,5");
                    writeForecasts.WriteLine("CAPE TOWN,16/06/2020,12,19,60,83,8");
                    writeForecasts.WriteLine("CAPE TOWN,17/06/2020,17,26,5,78,13");
                }

                // Populates city names.
                using (StreamWriter writeCities = new StreamWriter("Cities.txt", false))
                {
                    writeCities.WriteLine("DURBAN");
                    writeCities.WriteLine("JOHANNESBURG");
                    writeCities.WriteLine("CAPE TOWN");
                }

                // Populates user information.
                using (StreamWriter writeUserFavourites = new StreamWriter("UserInfo.txt", false))
                {
                    writeUserFavourites.WriteLine("user,DURBAN,CAPE TOWN");
                    writeUserFavourites.WriteLine("user2");
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Error populating dummy data.","ERROR!");
            }
        }
    }
}
