using _16012775_PROG6211_TASK1__POE;
using Microsoft.VisualBasic;
using System;
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
            dashboard frmWeatherApp = new dashboard();
            
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
            RegisterForm frmRegistration = new RegisterForm();
            frmRegistration.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loginEmailAddress = txbEmail.Text;
            string loginPassword = txbPassW.Text;

            User user = new User();

            if (chbForecast.Checked == false)
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
                Forecast forecaster = new Forecast();


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
    }
}
