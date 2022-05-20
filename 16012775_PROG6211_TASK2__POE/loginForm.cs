using _16012775_PROG6211_TASK1__POE;
using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Windows.Forms;

namespace _16012775_PROG6211_TASK1__POE
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void showWeatherApp()
        {
            BasicUser_AppInterface basicUserForm = new BasicUser_AppInterface();
            basicUserForm.Show();
            this.Hide();
        }

        private void showWeatherAppforForecaster()
        {
            //calls dashboard form
            dashboard frmWeatherApp = new dashboard();
            //displays the dashboard 
            frmWeatherApp.Show();
            this.Hide();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)

        {
            
            string username = txbEmail.Text.ToString().Trim(); 
            string password = txbPassW.Text.ToString();
            //to determine verification, use of a boolean variable
            bool flg = false; 

            //checks for an input or null value
            if (username.Equals("") || password.Equals("")) 
            {
                MessageBox.Show("Both a valid username and password is required");
                txbEmail.Clear();
                txbPassW.Clear();
                flg = true;
            }
            else
            {
                //try catch block for validation
                try
                {
                    //uses stream reader to read and compare data to the text file 
                    using (StreamReader loginDetails = new StreamReader("Login.txt"))
                    {
                        string line;
                        while ((line = loginDetails.ReadLine()) != null && flg == false)
                        {
                            var words = line.Split(',');

                            if (username.Equals(words[0]) && password.Equals(words[1]))
                            {
                                // If statements to provide the appropriate welcome message.
                                if (words[2].Equals("1"))
                                {
                                    MessageBox.Show($"Welcome, Admin: {username}", "Welcome!");
                                    flg = true;
                                    isAdmin = true; 
                                }
                                else if (words[2].Equals("0"))
                                {
                                    MessageBox.Show($"Welcome, user: {username}", "Welcome!");
                                    flg = true;
                                    isAdmin = false; 
                                    getUsername = username; 
                                }

                                //opens current menu and hides form 
                                txbPassW.Clear();
                                txbEmail.Clear();
                                this.Hide();
                            }
                        }
                    }
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Failed to validate user login.", "ERROR");
                }

               
                if (flg == false)
                {
                    MessageBox.Show("No user data matches the username password combination!", "VALIDATION ERROR");
                    txbEmail.Clear();
                    txbPassW.Clear();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }
}
