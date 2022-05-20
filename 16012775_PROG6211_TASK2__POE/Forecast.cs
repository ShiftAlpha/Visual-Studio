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
        //each forecaster has a pin
        //this sets the variable to 0
        private int ForecasterPin = 0000;
        
        /*public override void setUserType()
        {
            UserType = 'F';
        }*/

            //method to check true or false
            //is the pin verified or not
        public Boolean isPin(int pin)
        {
            Boolean isPin = false;
            if (pin == ForecasterPin)
            {
                isPin = true;
            }
            return isPin;
        }
        //registers to db if validation for forecaster
        internal void RegisterToDB()
        {
            throw new NotImplementedException();
        }
    }
}
