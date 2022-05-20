using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19015385_Prog6211_Task2
{
    class Forecaster : User
    {
        public Forecaster(string pUserName, string pUserSurname, string pEmailAddress, string pPassword) : base(pUserName, pUserSurname, pEmailAddress, pPassword)
        {
        }

        private int ForecasterPin = 0000;

        public override void setUserType()
        {
            UserType = 'F';
        }

        public Boolean isPin(int pin)
        {
            Boolean isPin = false;
            if (pin == ForecasterPin)
            {
                isPin = true;
            }
            return isPin;
        }

        public override Boolean isRegistered(string email,char usertype)
        {
            Boolean isReg = false;

            try
            {


                string[] Lines = File.ReadAllLines(getUsersFilePath());

                foreach (string line in Lines)
                {
                    string[] forecasterInfo = line.Split(new char[1] { ',' });

                    if (email == forecasterInfo[0] && usertype == Convert.ToChar(forecasterInfo[4]))
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

        public Forecaster()
        {

        }



        public override string FileFormat()
        {
            string sLine = "";

            sLine = EmailAddress + "," + Password + "," + UserName + "," + UserSurname + "," + UserType;

            return sLine;
        }
    }
}
