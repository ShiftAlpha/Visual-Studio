using System;

namespace _19015385_Prog6211_Task2
{
    class Forecaster : User
    {
        public Forecaster(string pUserName, string pUserSurname, string pEmailAddress, string pPassword) : base(pUserName, pUserSurname, pEmailAddress, pPassword)
        {
        }
        public Forecaster()
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

    }
}
