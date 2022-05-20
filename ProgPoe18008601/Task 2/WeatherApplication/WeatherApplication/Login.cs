using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace WeatherApplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            
            SqlConnection con = new SqlConnection(Properties.Settings.Default.WaKon);
            con.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            string sql;

            sql = "SELECT * FROM USERS";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                

                if ((username == Convert.ToString(dataReader["username"].ToString()))&&(password == Convert.ToString(dataReader["passwords"].ToString()))) {
                    if (Convert.ToString(dataReader.GetValue(3)) == "2")
                    {
                        Form1 newForm = new Form1(dataReader["user_id"].ToString());
                        newForm.Show();
                        this.Hide();
                    }//code to direct user to coreect page
                    else {
                        DashBoard newReport = new DashBoard((dataReader["user_id"].ToString()));
                        newReport.Show();
                        this.Hide();
                        //directing only forecasters to create page
                    }

                    break;
                }
                
            }

            con.Close();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            CreateUser newUser = new CreateUser();
            newUser.Show();
            this.Hide();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
