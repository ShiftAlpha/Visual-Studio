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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\kreas\OneDrive\Desktop\prog 2a\Task1\Task1\bin\Debug\a.txt",true);
            string city;
            DateTime date;
            string minTemp;
            string maxTemp;
            string precipitation;
            string humidity;
            string windSpeed;


            city = textBox1.Text;
            date = Convert.ToDateTime(dateTimePicker1.Text);
            minTemp = textBox7.Text;
            maxTemp = textBox6.Text;
            precipitation = textBox5.Text;
            humidity = textBox4.Text;
            windSpeed = textBox3.Text;

            inputs store = new inputs(city, date, minTemp, maxTemp, precipitation, humidity, windSpeed);

            file.WriteLine(store.getInputs());

            file.Close();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string temp = "";
            textBox1.Clear();
            temp = "'C";
            textBox3.Clear();
            textBox3.Text = temp; 
            textBox4.Clear();
            textBox4.Text = temp;
            temp = "%";
            textBox5.Clear();
            textBox5.Text = temp; 
            textBox6.Clear();
            textBox6.Text = temp;
            temp = "km/h";
            textBox7.Clear();
            textBox7.Text = temp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportType1 rep = new ReportType1();
            rep.Show();
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.SelectedText = null; 

        }

        private void button4_Click(object sender, EventArgs e)
        {
            report rep = new report();
            rep.Show();
        }
    }
}
