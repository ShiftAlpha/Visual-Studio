using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private string[] CityData = new string[6];

        private Tools tools = new Tools();
        private string getfilePath()
        {
    
                string filePath = @"..\..\19015385_Prog6211_Task2\CitiesReports.txt";

                return filePath;
          

            
        }

        public void Display()
        {
            richTextBox1.Text =  String.Format("{0,10 }{1,10 }{2,10 }{3,10 }{4,10 }{5,10 }", CityData[0], CityData[1] , CityData[2],CityData[3],CityData[4],CityData[5],CityData[6]);
        }

        public void ViewForecst()
        {


            try
            {
                string[] arrFileData = File.ReadAllLines(getfilePath());

                foreach (string str in arrFileData)
                {
                    if (str==(string)chklstbxCities.SelectedItem)
                    {
                       CityData = str.Split(new char[1] { ',' });
                        Display();

                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //extract cities 
            //search in file for cities 
            //all data found into array
            //separate each array into individual arrays 
            //Use Tab Spacing code from stack overflow
            //display with tabs in richedit 
            ViewForecst();
        }
    }
}
