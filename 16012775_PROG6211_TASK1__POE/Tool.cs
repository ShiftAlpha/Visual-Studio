using System;
using System.Data.SqlClient;
using System.IO;

namespace _16012775_PROG6211_TASK1__POE
{
    class Tool
    {
        public Tool() { }

        public void showMainForm()
        {
            loginForm frmLogin = new loginForm();
            frmLogin.Show();
        }
    }
}
