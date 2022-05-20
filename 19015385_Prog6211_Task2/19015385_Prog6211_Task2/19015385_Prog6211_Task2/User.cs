using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19015385_Prog6211_Task2
{
    class User
    {
        protected string UserName;
        protected string UserSurname;
        protected string EmailAddress;
        protected string Password;
        protected char UserType;
       

        public User(string pUserName , string pUserSurname , string pEmailAddress, string pPassword)
        {

            if ((pUserName == "") || (pUserSurname == "") || (pEmailAddress == "") || (pPassword == ""))
            {
                MessageBox.Show("Fields cannot be blank", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                UserName = pUserName;
                UserSurname = pUserSurname;
                EmailAddress = pEmailAddress;
                Password = pPassword;
            }

        }

        public User()
        {
        }

        public string getName()
        {
            return UserName;
        }

        public string getSurname()
        {
            return UserSurname;
        }

        public Boolean setPassword(string ConfirmedPassword)
        {
            Boolean pswrdmatch = true;

            if (Password != ConfirmedPassword)
            {
                pswrdmatch = false;
                


            }
            else 
            {
                Password = ConfirmedPassword;
            }

            return pswrdmatch;

        }

        public string getPassword()
        {
            return Password;
        }

        public string getEmail()
        {
            return EmailAddress;
        }

        public char getUserType()
        {
            return UserType;
        }

        public virtual void setUserType()
        {
            UserType = 'G';

        }

        public virtual string FileFormat()
        {
            string sLine = "";

            sLine = EmailAddress + "," + Password + "," +  UserName + "," + UserSurname + "," + UserType;

            return sLine;
        }


     

        protected string getUsersFilePath()
        {

            string filePath = @"..\..\19015385_Prog6211_Task2\Users.txt";

            return filePath;
        }

        public virtual Boolean isRegistered(string email, char usertype) //method checks if user is already saved in textfile
        {
            Boolean isReg = false;

            try
            {
                string[] Lines = File.ReadAllLines(getUsersFilePath());

                foreach (string line in Lines)
                {
                 
                    string[] userInformation = line.Split(new char[1] { ',' });// set delimitter

                    if (email == userInformation[0] && usertype == Convert.ToChar(userInformation[4]))
                    {
                        isReg = true;
                    }





                }

            }


            
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

            return isReg;

        }





    }
}
