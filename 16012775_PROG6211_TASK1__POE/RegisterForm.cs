using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace _16012775_PROG6211_TASK1__POE
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private Tool tools = new Tool();

        private string Name;
        private string Surname;
        private string Password;
        private string Email;

        private void button1_Click(object sender, EventArgs e)
        {
            //extract details
            Name = txbfName.Text;
            Surname = txbsName.Text;
            Password = txbPassW.Text;
            Email = txbfName.Text;

            if (chbForecast.Checked == true)
            {

                int pin = Convert.ToInt32(Interaction.InputBox("Enter Forecaster Pin: ", "Forecaster Pin"));
                Forecast forecaster = new Forecast(Name, Surname, Email, Password);

                //check and set password 
                Boolean cnfrmPswdmatch = forecaster.setPassword(txbCPassW.Text);

                //set user type
                forecaster.setUserType();

                if (cnfrmPswdmatch == true)  //check if password matches confirm password
                {
                    if (forecaster.isRegistered(Email, 'F') == false) //check if Forecaster already registered
                    {
                        if (forecaster.isPin(pin) == true)
                        {
                            try
                            {
                                //Add Forecaster to DataBase
                                forecaster.RegisterToDB();
                                MessageBox.Show("Forecaster Registered");
                                this.Close();
                            }
                            catch (Exception error)
                            {
                                MessageBox.Show(error.Message);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Pin", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email already registered", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (chbForecast.Checked == false)
                {
                    MessageBox.Show("Passwords DO NOT Match", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                User user = new User(Name, Surname, Email, Password);

                //set User Type 
                user.setUserType();

                //check and set password
                Boolean cnfrmPswrdmatch = user.setPassword(txbCPassW.Text);

                //Save User To Textfile if passwords match
                if (cnfrmPswrdmatch == true)
                {
                    if (user.isRegistered(Email, 'G') == false)
                    {
                        try
                        {
                            //Add User to DB
                            user.RegisterToDB();
                            MessageBox.Show("User Registered");
                            this.Close();

                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.Message);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email already registered", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Passwords DO NOT match", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
