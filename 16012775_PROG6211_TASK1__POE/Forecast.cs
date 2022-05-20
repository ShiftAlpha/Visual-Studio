using System;


namespace _16012775_PROG6211_TASK1__POE
{
    class Forecast
    {
        public Forecast(string pUserName, string pUserSurname, string pEmailAddress, string pPassword) : base(pUserName, pUserSurname, pEmailAddress, pPassword)
        {
        }
        public Forecast()
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

        internal void RegisterToDB()
        {
            throw new NotImplementedException();
        }
    }
}
