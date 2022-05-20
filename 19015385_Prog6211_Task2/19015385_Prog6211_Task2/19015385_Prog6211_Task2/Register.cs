using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
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
        
        // private char UserType; 

        private string getUsersFilePath()
        {
            string filePath = @"C:\Users\zafar\Desktop\College\Prog2020\POE\19015385_Prog6211_Task2\19015385_Prog6211_Task2\19015385_Prog6211_Task2\Users.txt";

            return filePath;
        }


        public void createUser()
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
                    if (forecaster.isRegistered(Email,'F') == false) //check if Forecaster already registered
                    {
                        if (forecaster.isPin(pin) == true)
                        {

                            try
                            {


                                File.AppendAllText(getUsersFilePath(), forecaster.FileFormat() + Environment.NewLine);

                                MessageBox.Show("Forecaster Registered");


                                this.Close();

                            }
                            catch (Exception e)
                            {
                                MessageBox.Show(e.Message);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Pin", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }


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

                if (cnfrmPswrdmatch = true)
                {
                    if (user.isRegistered(Email, 'G') == false)
                    {
                        try
                        {


                            File.AppendAllText(getUsersFilePath(), user.FileFormat()+Environment.NewLine);

                            MessageBox.Show("User Registered");


                            this.Close();

                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message);
                            return;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Passwords DO NOT match", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }



        }



        private void button1_Click(object sender, EventArgs e)
        {
            createUser();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
        
        }

        private void chkbxIsForecaster_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            tools.showMainForm();
        }
    }
}
