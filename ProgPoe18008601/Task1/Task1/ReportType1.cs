using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Task1
{
    public partial class ReportType1 : Form
    {

        private inputs forcasting ; 
        string[] vals = new string[100];
        string[] cityNames = new string[100];
        public ReportType1()
        {
            InitializeComponent();
        }
      

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReportType1_Load(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("a.txt");
            string line = "";
            string city = "";
            int count = 0 ;
            Boolean a = true; 
            while ((line =file.ReadLine()) != null) {

                city = line.Substring(0 , line.IndexOf(","));
                //making the city only unique values 
                
                    if (cityNames.Contains(city))
                    {
                        a = false;
                    }
                    else {

                        a = true;
                    }
                if (a == true)
                {
                    cityNames[count] = city;
                    count++;
                }
            }

            file.Close();
            
            comboBox1.DataSource = cityNames;
            comboBox2.DataSource = cityNames; 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader file = new StreamReader("a.txt");
            string line = "";
            string temp = "";
            string city = "";
            string date = "";
            int count = 0;
            
            string[] ab = new string[100];
            string[] abc = new string[100];

            while ((line = file.ReadLine()) != null)
            {
                city = line.Substring(0, line.IndexOf(","));
                
                temp = line.Substring(line.IndexOf(",") + 1);
          
                //making the city only unique values 
                object cityvals = comboBox1.SelectedItem;
                if (cityvals.ToString() == city)
                {

                    date = temp.Substring(0, temp.IndexOf(","));

                    vals[count] = date;
                    
                    ab[count] = date;
                    count++;
                }
            }
            file.Close();
            abc = ab;
            comboBox3.DataSource = ab;
            comboBox4.DataSource = abc; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchArray();
        }
        public void searchArray() {
            StreamReader file = new StreamReader("a.txt");
            string line = "";
            string temp = "";
            string city = "";
            string date = "";
            
            string[] ab = new string[100];

            while ((line = file.ReadLine()) != null)
            {
                city = line.Substring(0, line.IndexOf(","));
                temp = line.Substring(line.IndexOf(",") + 1);

                object cityvals = comboBox3.SelectedItem;
                object cityvalsa = comboBox4.SelectedItem;
                date = temp.Substring(0, temp.IndexOf(","));
                if ((Convert.ToDateTime(cityvals.ToString()) >= Convert.ToDateTime(date)) && (Convert.ToDateTime(cityvalsa.ToString()) <= Convert.ToDateTime(date)))
                {
                    forcasting = new inputs(line);
                    richTextBox1.AppendText(forcasting.getInputs().Replace(",", "\t"));                   
                }
            }
            file.Close();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
