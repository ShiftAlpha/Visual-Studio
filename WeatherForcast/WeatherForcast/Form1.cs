using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherForcast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { //create
            creatingForcast cf1 = new creatingForcast();
            cf1.Show();
            this.Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void viewBtn_Click(object sender, EventArgs e)
        { //view

            ViewCities vc1 = new ViewCities();
            vc1.Show();
            this.Hide();

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
