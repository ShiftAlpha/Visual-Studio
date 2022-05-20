using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace _16012775_PROG6211_TASK1__POE
{
    class User
    {
        //declare variables
        private string uName;
        private string uSurname;
        private string EmailAddress;
        private string PassW;
        protected char UserType;

        private static string tPath = Environment.CurrentDirectory;
        private static string path = Directory.GetParent(tPath).Parent.FullName + @"\Database\";




        public User(string pUName, string pUSurname, string pEmailAddress, string pPassW)
        {

           //checks for invalid inputs
            if ((pUName == "") || (pUSurname == "") || (pEmailAddress == "") || (pPassW == ""))
            {
                MessageBox.Show("Fields cannot be blank", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                uName = pUName;
                uSurname = pUSurname;
                EmailAddress = pEmailAddress;
                PassW = pPassW;
            }
        }

        public User()
        { }

        //get methods
        public string getName()
        {
            return uName;
        }

        public string getSurname()
        {
            return uSurname;
        }

        //get methods
        public string getPassword()
        {
            return PassW;
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


        //boolean method to set and confirm password
        public Boolean setPassword(string ConPassword)
        {
            Boolean passMatch = true;

            if (PassW != ConPassword)
            {
                passMatch = false;
            }
            else
            {
                PassW = ConPassword;
            }
            return passMatch;
        }
        //boolean method to check if user is registered
        public Boolean isRegistered(string email, char usertype)
        { 
            //sets boolean value to false
            Boolean isReg = false;
            List<string> lstEmail = new List<string>();
            List<char> lstUserType = new List<char>();

            SqlConnection connection = new SqlConnection(new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "16012775_ProgDB.mdf;Integrated Security=True").ConnectionString);


            using (connection) 
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Select User_Email, User_Type from tblUsers", connection);
                SqlDataReader dbReader = command.ExecuteReader();

                if (dbReader.HasRows)
                {
                    while (dbReader.Read())
                    {
                        lstEmail.Add(dbReader[0].ToString());
                        lstUserType.Add(dbReader[1].ToString()[0]);
                    }
                }

                Boolean isEmail = false; 
                foreach (string item in lstEmail)
                {
                    if (item == email)
                    {
                        isEmail = true;

                    }
                }

                Boolean isUserType = false; 
                foreach (char item in lstUserType)
                {
                    if (item == usertype)
                    {
                        isUserType = true;
                    }
                }

                if (isEmail == true && isUserType == true) //User is already registered
                {
                    isReg = true;

                }

            }
            //returns boolean value
            return isReg;
        }
        //registers user to database
        public void RegisterToDB()
        {
            //sql connection to establish one
            SqlConnection connection = new SqlConnection(new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "16012775_ProgDB.mdf;Integrated Security=True").ConnectionString);

            //inserts in table users with values
            SqlCommand query = new SqlCommand("Insert INTO tblUsers Values(@UserEmail, @UserPassword, @UserName, @UserSurname , @UserType)", connection);

            connection.Open();

            //values to be inserted into registered user
            query.Parameters.AddWithValue("@UserEmail", EmailAddress);
            query.Parameters.AddWithValue("@UserPassword", PassW);
            query.Parameters.AddWithValue("@UserName", uName);
            query.Parameters.AddWithValue("@UserSurname", uSurname);
            query.Parameters.AddWithValue("@UserType", UserType);

            query.ExecuteNonQuery();
            //closes connection
            connection.Close();

        }







    }
}
