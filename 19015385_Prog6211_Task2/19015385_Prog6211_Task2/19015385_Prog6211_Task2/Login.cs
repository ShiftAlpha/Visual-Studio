using _19015385_Prog6211_Task1;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _19015385_Prog6211_Task2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       


        public void SearchForUser()
        {






        }

        public void verifyUser()
        {
            string loginEmailAddress = txtbxEmail.Text;
            string loginPassword = txtboxPassword.Text;

            User user = new User();

            if (chkbxIsForecaster.Checked == false)
            {

                try
                {

                    if (user.isRegistered(loginEmailAddress, 'G') == true)
                    {
                        showWeatherApp();
                    }
                    else
                    {
                        MessageBox.Show("User not registered");
                    }
                }




                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                int pin = Convert.ToInt32(Interaction.InputBox("Enter Forecaster Pin: ", "Forecaster Login Pin"));
                Forecaster forecaster = new Forecaster();
                

                try
                {

                    if (forecaster.isRegistered(loginEmailAddress, 'F') == true)
                    {
                        if (forecaster.isPin(pin) == true && pin.ToString()!="")
                        {

                            showWeatherAppforForecaster();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Pin");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Forecaster not registered");
                    }
                }




                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {




        }

        private void showWeatherApp()
        {
            WeatherAppGeneralUser frmWeatherAppGeneralUser = new WeatherAppGeneralUser();
            frmWeatherAppGeneralUser.Show();
            this.Hide();
        }

        private void showWeatherAppforForecaster()
        {
            WeatherApp frmWeatherApp = new WeatherApp();
            frmWeatherApp.pnlcaptureforecast.Enabled = true;
            frmWeatherApp.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Register frmRegistration = new Register();
            frmRegistration.Show();
            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {


            Application.Exit();
        }

        private void chkbxIsForecaster_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            verifyUser();
        }
    }
}




