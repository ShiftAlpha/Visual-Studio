using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace WeatherApplication
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string Username;
            string pass1;
            string pass2;
            int SelectInt;
            int userType; 

            Boolean valid = true ; 

            Username = txtUsername.Text;
            pass1 = txtP1.Text;
            pass2 = txtP2.Text;
            SelectInt = cmbUser.SelectedIndex;

            if (Username == null) 
                valid = false; 

            if ((pass1 == null))
                valid = false;

            if ((pass2 == null) && (pass1 != pass2)) {
                valid = false; 
            }

            if (cmbUser.SelectedIndex == 0)
            {
                userType = 1;

            }
            else {
                userType = 2; 
            }


            if (valid) {

                SqlCommand cmd; 

                SqlConnection con = new SqlConnection(Properties.Settings.Default.WaKon);
                con.Open();
                
                cmd = new SqlCommand("insert into users(username,passwords,user_type) values (@username , @passwords ,@user_type)",con);
                
                cmd.Parameters.AddWithValue("@username",Username);
                cmd.Parameters.AddWithValue("@passwords", pass1);
                cmd.Parameters.AddWithValue("@user_type",userType);
                //INSERTING NEW user details
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("insert Succesful");//successful input

                Login newLogin = new Login();
                newLogin.Show();
                this.Hide();
                 
            }
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {

        }

        private void txtP2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtP1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
