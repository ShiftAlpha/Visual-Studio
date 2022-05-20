using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace _19015385_Prog6211_Task2
{
    public partial class editforecasts : Form
    {
        public editforecasts()
        {
            InitializeComponent();
        }

        private string CityName;
        private DateTime Date;
        private int MinT;
        private int MaxT;
        private int Precip;
        private int Humidity;
        private int Windspeed;

        private string[] OriginalRecord = new string [7]; 
        public List<string> lstDBData = new List<string>();

        private static string tempPath = Environment.CurrentDirectory;
        private static string path = Directory.GetParent(tempPath).Parent.FullName + @"\Database\";



        public void readDB() //reads database records into list
        {
            SqlConnection connection = new SqlConnection(new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "WeatherAppDB.mdf;Integrated Security=True").ConnectionString);

            connection.Open();
            SqlCommand query = new SqlCommand("Select * from tblForecasts", connection);
            SqlDataReader dbReader = query.ExecuteReader();

            //check if record exists
            if (dbReader.HasRows)
            {
                while (dbReader.Read()) //while not end of table 
                {
                    lstDBData.Add(dbReader[0].ToString() + "," + dbReader[1].ToString() + "," + dbReader[2].ToString() + "," + dbReader[3].ToString() + "," + dbReader[4].ToString() + "," + dbReader[5].ToString() + "," + dbReader[6].ToString()); //reads records from database into list 
                }

            }
            connection.Close();

        }

        private void btnViewRecords_Click(object sender, EventArgs e) //adds appropriate records to listbox 
        {
            readDB();

            string[] arrFileData = new string[lstDBData.Count];

            arrFileData = lstDBData.ToArray();

            CityName = (string)cmbCitySelect.SelectedItem;
            Date = (dtpSelect.Value);

            Boolean found = false;

            //search array for matching element 
            try
            {
                foreach (string item in arrFileData)
                {

                    //extract city name and date from array of strings
                    string cityname = item.Substring(0, item.IndexOf(","));
                    string date = item.Substring(item.IndexOf(",") + 1, 10);

                    if ((CityName == cityname) && (Convert.ToString(Date.ToShortDateString()) == date))
                    {
                        found = true;
                        lstbxFileData.Items.Add(item);

                    }
                }

                if (found == false)
                {
                    MessageBox.Show("Record Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception error)
            { MessageBox.Show(error.Message); }

        }

        private void lstbxFileData_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnleditRecord.Enabled = true;

            string SelectedRecord = (string)lstbxFileData.SelectedItem;
            
            

            string[] selectedrecord = SelectedRecord.Split(new char[1] { ',' });

            for (int  i = 0;  i < OriginalRecord.Length;  i++)
            {
                OriginalRecord[i] = selectedrecord[i];
            }

            foreach (var item in selectedrecord) //adds selected record to be updated into gui components for editing 
            {
                cmbxedited.SelectedItem = selectedrecord[0];
                dtp.Value = Convert.ToDateTime(selectedrecord[1]);
                spnMinTemp.Value = Convert.ToInt32(selectedrecord[2]);
                spnMaxTemp.Value = Convert.ToInt32(selectedrecord[3]);
                spnPrecip.Value = Convert.ToInt32(selectedrecord[4]);
                spnHumidity.Value = Convert.ToInt32(selectedrecord[5]);
                spnWindSpd.Value = Convert.ToInt32(selectedrecord[6]);
            }

      
        }

        private void deletefromDB() //deletes record from database
        {

            readDB();

            //extracts records values into variables

            CityName = OriginalRecord[0];
            Date = Convert.ToDateTime( OriginalRecord[1]);
            MinT = Convert.ToInt32(OriginalRecord[2]);
            MaxT = Convert.ToInt32(OriginalRecord[3]);
            Precip = Convert.ToInt32(OriginalRecord[4]);
            Humidity = Convert.ToInt32(OriginalRecord[5]);
            Windspeed = Convert.ToInt32(OriginalRecord[6]);

            SqlConnection connection = new SqlConnection(new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "WeatherAppDB.mdf;Integrated Security=True").ConnectionString);

            using (SqlCommand query = new SqlCommand("Delete from tblForecasts where (City_Name = @CityName ) and (Date =  @Date) and (Min_Temp = @MinTemp) and (Max_Temp = @MaxTemp) and (Precipitation = @Precip) and (Humidity = @Humid) and (Wind_Speed = @WS)", connection))
            {
                connection.Open();
                query.Parameters.AddWithValue("@CityName", CityName);
                query.Parameters.AddWithValue("@Date", Date);
                query.Parameters.AddWithValue("@MinTemp", MinT);
                query.Parameters.AddWithValue("@MaxTemp", MaxT);
                query.Parameters.AddWithValue("@Precip", Precip);
                query.Parameters.AddWithValue("@Humidity", Humidity);
                query.Parameters.AddWithValue("@WS", Windspeed);

                query.ExecuteNonQuery();
            }
        }

        private void saveupdatedrecord() //save updated record to database 
        {
            CityName = (string)cmbxedited.SelectedItem;
            Date = dtp.Value;
            MinT = (int)spnMinTemp.Value;

            MaxT = (int)spnMaxTemp.Value;

            Precip = (int)spnPrecip.Value;

            Humidity = (int)spnHumidity.Value;
            Windspeed = (int)spnWindSpd.Value;

            SqlConnection connection = new SqlConnection(new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "WeatherAppDB.mdf;Integrated Security=True").ConnectionString);

            SqlCommand query = new SqlCommand("Insert INTO tblForecasts Values(@CityName, @Date, @MinTemp, @MaxTemp, @Precip , @Humidity , @WindSpd)", connection);

            connection.Open();

            query.Parameters.AddWithValue("@CityName", CityName);
            query.Parameters.AddWithValue("@Date", Date);
            query.Parameters.AddWithValue("@MinT", MinT);
            query.Parameters.AddWithValue("@MaxT", MaxT);
            query.Parameters.AddWithValue("@Precip", Precip);
            query.Parameters.AddWithValue("@Humidity", Humidity);
            query.Parameters.AddWithValue("@WindSpd", Windspeed);


            query.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Record Updated","Confirmation", MessageBoxButtons.OK , MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //delete old record from database 
            deletefromDB();


            //save new record to database 
            saveupdatedrecord();
        }


    }
}
