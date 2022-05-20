using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19015385_Prog6211_Task2
{
    public partial class WeatherAppGeneralUser : Form
    {
        public WeatherAppGeneralUser()
        {
            InitializeComponent();
        }


        public List<string> lstDBData = new List<string>();

        private static string tempPath = Environment.CurrentDirectory;
        private static string path = Directory.GetParent(tempPath).Parent.FullName + @"\Database\";

        private SqlConnection connection = new SqlConnection(new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "WeatherAppDB.mdf;Integrated Security=True").ConnectionString);

        public void readDB() //reads database records into list
        {

            connection.Open();
            SqlCommand query = new SqlCommand("Select * from tblForecasts", connection);
            SqlDataReader dbReader = query.ExecuteReader();

            if (dbReader.HasRows)
            {
                while (dbReader.Read())
                {
                    lstDBData.Add(dbReader[0].ToString() + "," + dbReader[1].ToString() + "," + dbReader[2].ToString() + "," + dbReader[3].ToString() + "," + dbReader[4].ToString() + "," + dbReader[5].ToString() + "," + dbReader[6].ToString());
                }

            }
            connection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                string[] arrFileData = new string[lstDBData.Count];

                arrFileData = lstDBData.ToArray();

                List<string> lstSelectedCities = new List<string>();
                Boolean found = false;

                lstSelectedCities.Add(chklstbxCities.SelectedItems.ToString());

                //search array for matching element 
                try
                {
                    foreach (string item in lstSelectedCities)
                    {



                        for (int i = 0; i < arrFileData.Length; i++)
                        {
                            string cityname = arrFileData[i].Substring(0, arrFileData[i].IndexOf(","));
                            if (item == cityname)
                            {
                                richTextBox1.Text = arrFileData[i];
                            }
                        }

                    }
                }
                catch (Exception error)
                { MessageBox.Show(error.Message); }



            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
