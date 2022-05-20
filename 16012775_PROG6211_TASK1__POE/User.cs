using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace _16012775_PROG6211_TASK1__POE
{
    class User
    {
        private string UserName;
        private string UserSurname;
        private string EmailAddress;
        private string Password;
        protected char UserType;

        private static string tempPath = Environment.CurrentDirectory;
        private static string path = Directory.GetParent(tempPath).Parent.FullName + @"\Database\";



        //constructor
        public User(string pUserName, string pUserSurname, string pEmailAddress, string pPassword)
        {

            //check for nulls
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

        //constructor 
        public User()
        { }

        public string getName()
        {
            return UserName;
        }

        public string getSurname()
        {
            return UserSurname;
        }

        public Boolean setPassword(string ConfirmedPassword)//checks if confirm password matches password entered 
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

        public Boolean isRegistered(string email, char usertype) //checks if user is registered
        {
            Boolean isReg = false;
            List<string> lstEmail = new List<string>();
            List<char> lstUserType = new List<char>();

            SqlConnection connection = new SqlConnection(new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "WeatherAppDB.mdf;Integrated Security=True").ConnectionString);


            using (connection) //extract records from database to list
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

                Boolean isEmail = false; //check if email already in database
                foreach (string item in lstEmail)
                {
                    if (item == email)
                    {
                        isEmail = true;

                    }
                }

                Boolean isUserType = false; //check if usertype already in database
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
            return isReg;
        }

        public void RegisterToDB() //Saves User To Database. 
        {
            SqlConnection connection = new SqlConnection(new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "WeatherAppDB.mdf;Integrated Security=True").ConnectionString);


            SqlCommand query = new SqlCommand("Insert INTO tblUsers Values(@UserEmail, @UserPassword, @UserName, @UserSurname , @UserType)", connection);

            connection.Open();

            query.Parameters.AddWithValue("@UserEmail", EmailAddress);
            query.Parameters.AddWithValue("@UserPassword", Password);
            query.Parameters.AddWithValue("@UserName", UserName);
            query.Parameters.AddWithValue("@UserSurname", UserSurname);
            query.Parameters.AddWithValue("@UserType", UserType);

            query.ExecuteNonQuery();

            connection.Close();

        }







    }
}
