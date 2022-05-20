using System;
using System.Data.SqlClient;
using System.IO;

namespace _19015385_Prog6211_Task2
{
    class Tools
    {
        public Tools() { }

        public void showMainForm()
        {
            Login frmLogin = new Login();
            frmLogin.Show();
        }

    }
}
