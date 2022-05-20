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

namespace _16012775_PROG6211_TASK1__POE
{
    public partial class BasicUser_AppInterface : Form
    {
        public BasicUser_AppInterface()
        {
            InitializeComponent();
        }
        //creates list of database data
        public List<string> lstDBData = new List<string>();

        //creates temp path 
        private static string tPath = Environment.CurrentDirectory;
        //new path variable is set to temp path
        private static string path = Directory.GetParent(tPath).Parent.FullName + @"\Database\";
        //sql connection
        private SqlConnection connection = new SqlConnection(new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "16012775_ProgDB.mdf;Integrated Security=True").ConnectionString);

        //reads database
        public void readDB() 
        {
            //open connection
            connection.Open();
            //selects all from forecast table
            SqlCommand query = new SqlCommand("Select * from tblForecasts", connection);
            //reader class creates an object dbReadeer
            SqlDataReader dbReader = query.ExecuteReader();
            //checks to see if rows are there
            if (dbReader.HasRows)
            {
                //if condition is satisfied, while loop is triggered
                while (dbReader.Read())
                {

                    lstDBData.Add(dbReader[0].ToString() + "," + dbReader[1].ToString() + "," + dbReader[2].ToString() + "," + dbReader[3].ToString() + "," + dbReader[4].ToString() + "," + dbReader[5].ToString() + "," + dbReader[6].ToString());
                }

            }
            //closes connection
            connection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //creates array named arrFile data
                //string array, length, counts the list length of database. 
                string[] arrFData = new string[lstDBData.Count];

                arrFData = lstDBData.ToArray();

                List<string> lstSelectedCities = new List<string>();
                Boolean fnd = false;

                lstSelectedCities.Add(chbCities.SelectedItems.ToString());

                //search array for matching element 
                try
                {
                    foreach (string item in lstSelectedCities)
                    {


                        //for loop
                        for (int i = 0; i < arrFData.Length; i++)
                        {
                            string cityname = arrFData[i].Substring(0, arrFData[i].IndexOf(","));
                            if (item == cityname)
                            {
                                rtbViewForecasts.Text = arrFData[i];
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
