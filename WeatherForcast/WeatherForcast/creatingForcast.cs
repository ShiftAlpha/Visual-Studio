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
    public partial class creatingForcast : Form
    {
        public creatingForcast()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime cfdate = dateTimeP1.Value;
            string cfName = cityTxt.Text;
            int cfIdNum = Convert.ToInt32(idNumTxt.Text);
            int cfMax = Convert.ToInt32(MaxTemp.Text);
            int cfMin = Convert.ToInt32(MinTemp.Text);
            double cfprecip = Convert.ToDouble(PrecipTxt.Text);
            double cfwind = Convert.ToDouble(windTxt.Text);
            double cfHumid = Convert.ToDouble(humidTxt.Text);

            ForcastObject fo1 = new ForcastObject(cfName, cfIdNum,cfMin, cfMax, cfHumid, cfwind, cfprecip, cfdate);
            StoreList.forcastOfCities.Add(fo1);
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void creatingForcast_Load(object sender, EventArgs e)
        {

        }
    }
}
