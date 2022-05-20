using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace _19015385_Prog6211_Task2
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private Tools tools = new Tools();

        private string Name;
        private string Surname;
        private string Password;
        private string Email;

        private void button1_Click(object sender, EventArgs e)
        {
            //extract details
            Name = txtbxFName.Text;
            Surname = txtbxSurname.Text;
            Password = txtboxPassword.Text;
            Email = txtbxEmail.Text;

            if (chkbxIsForecaster.Checked == true)
            {

                int pin = Convert.ToInt32(Interaction.InputBox("Enter Forecaster Pin: ", "Forecaster Pin"));
                Forecaster forecaster = new Forecaster(Name, Surname, Email, Password);

                //check and set password 
                Boolean cnfrmPswdmatch = forecaster.setPassword(txtbxCPassword.Text);

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
                else if (chkbxIsForecaster.Checked == false)
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
                Boolean cnfrmPswrdmatch = user.setPassword(txtbxCPassword.Text);

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


        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            tools.showMainForm();
        }


    }
}
