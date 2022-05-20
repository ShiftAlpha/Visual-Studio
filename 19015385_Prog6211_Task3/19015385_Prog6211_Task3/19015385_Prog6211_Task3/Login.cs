using _19015385_Prog6211_Task1;
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace _19015385_Prog6211_Task2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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

        private void button1_Click_1(object sender, EventArgs e)
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
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
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
                        if (forecaster.isPin(pin) == true && pin.ToString() != "")
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
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}




