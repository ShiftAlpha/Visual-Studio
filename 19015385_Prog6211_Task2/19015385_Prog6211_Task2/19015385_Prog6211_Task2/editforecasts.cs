using _19015385_Prog6211_Task1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19015385_Prog6211_Task2
{
    public partial class editforecasts : Form 
    {
        public editforecasts() 
        {
            InitializeComponent();
        }
        private Tools tools = new Tools();

        private string CityName;
        private DateTime Date;
        private int MinT;
        private int MaxT;
        private int Precip;
        private int Humidity;
        private int Windspeed;
        private string OriginalRecord;
        public string getFilePath()
        {

            string filePath = @"C:\Users\zafar\Desktop\College\Prog2020\POE\19015385_Prog6211_Task2\19015385_Prog6211_Task2\19015385_Prog6211_Task2\CitiesReports.txt";

            

            return filePath;
        }
       
        public void extractdatafromfile() 
        {


        string[] arrFileData = File.ReadAllLines(getFilePath());

        CityName = (string)cmbCitySelect.SelectedItem;
            Date = (dtpSelect.Value);
            Boolean found = false;
            try
            {
         

                foreach(string item in arrFileData)
                {

                    string[] cityrecord = item.Split(new char[1] { ',' } );

                    if (CityName == cityrecord[0] && Convert.ToString(Date.ToShortDateString()) == cityrecord[1])
                    {
                        found = true;
                        lstbxFileData.Items.Add(item);
                        
                    }
                

                }
                if(found == false)
                {
                    MessageBox.Show("Record Not Found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }


            }
            catch (Exception e)
            { MessageBox.Show(e.Message); }
        }

        private void btnCaptureData_Click(object sender, EventArgs e)
        {
            extractdatafromfile();
        }

        //move selected item from list box into string array, separate the values and put into gui components 
        public void setEdit()
        {
            pnleditRecord.Enabled = true;

            string SelectedRecord = (string)lstbxFileData.SelectedItem;
            OriginalRecord = SelectedRecord;

            string[] selectedrecord = SelectedRecord.Split(new char[1] {','});

            foreach (var item in selectedrecord)
            {
                cmbxedited.SelectedItem= selectedrecord[0];
                dtp.Value = Convert.ToDateTime(selectedrecord[1]);
                spnMinTemp.Value = Convert.ToInt32(selectedrecord[2]);
                spnMaxTemp.Value = Convert.ToInt32(selectedrecord[3]);
                spnPrecip.Value = Convert.ToInt32(selectedrecord[4]);
                spnHumidity.Value = Convert.ToInt32(selectedrecord[5]);
                spnWindSpd.Value = Convert.ToInt32(selectedrecord[6]);
            }

            /*cmbxedited.SelectedItem = SelectedRecord.Substring(0,SelectedRecord.IndexOf(",")-1);
            SelectedRecord.Remove(0, SelectedRecord.IndexOf(","));
            dtp.Value = Convert.ToDateTime(SelectedRecord.Substring(0, SelectedRecord.IndexOf(",") - 1));
            SelectedRecord.Remove(0, SelectedRecord.IndexOf(","));
            spnMinTemp.Value = Convert.ToInt32(SelectedRecord.Substring(0, SelectedRecord.IndexOf(",") - 1));
            SelectedRecord.Remove(0, SelectedRecord.IndexOf(","));
            spnMaxTemp.Value = Convert.ToInt32(SelectedRecord.Substring(0, SelectedRecord.IndexOf(",") - 1));
            SelectedRecord.Remove(0, SelectedRecord.IndexOf(","));
            spnPrecip.Value = Convert.ToInt32(SelectedRecord.Substring(0, SelectedRecord.IndexOf(",") - 1));
            SelectedRecord.Remove(0, SelectedRecord.IndexOf(","));
            spnHumidity.Value = Convert.ToInt32(SelectedRecord.Substring(0, SelectedRecord.IndexOf(",") - 1));
            SelectedRecord.Remove(0, SelectedRecord.IndexOf(","));
            spnWindSpd.Value = Convert.ToInt32(SelectedRecord.Substring(0, SelectedRecord.IndexOf(",") - 1));
            SelectedRecord.Remove(0, SelectedRecord.IndexOf(","));*/
        }

        private void lstbxFileData_SelectedIndexChanged(object sender, EventArgs e)
        {
            setEdit();
        }

        private void SaveEditedRecord()
        {
            //extract from listbox into variables 
            CityName = (string)cmbxedited.SelectedItem;
            Date = (dtp.Value);
            
            MinT = (int)spnMinTemp.Value;
            MaxT = (int)spnMaxTemp.Value;
            Precip = (int)spnPrecip.Value;
            Humidity = (int)spnHumidity.Value;
            Windspeed = (int)spnWindSpd.Value;

            //create city object
            City city = new City(CityName,Date, MinT,MaxT,Precip,Humidity,Windspeed);

            //search textfile and replace old record with edited record 
            try
            {
                List<string> FileData = new List<string>();

                string[] arrFileData = new string[FileData.Count];

                
                arrFileData = File.ReadAllLines(getFilePath());

                foreach (string line in arrFileData)
                {
                    
                    if (city.FileFormat() == line)
                    {
                        line.Replace(line,city.FileFormat());
                        break;
                    }
                }

                File.WriteAllLines(getFilePath(), arrFileData);

                

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveEditedRecord();
        }

        private void editforecasts_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
