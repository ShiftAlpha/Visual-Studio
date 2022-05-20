using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18011883_prog6112_task_1_poe
{
    public partial class SingleCityForm : Form
    {
        public SingleCityForm()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SingleCityForm_Load(object sender, EventArgs e)
        {
            this.listView1.View = View.Details;
            listView1.Columns.Add("City", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Maximum Temperature", 140, HorizontalAlignment.Left);
            listView1.Columns.Add("Mininimum Temperature", 140, HorizontalAlignment.Left);
            listView1.Columns.Add("Precipertation", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Wind", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("Humidity", 80, HorizontalAlignment.Left);

            for (int i = 0; i < ListStore.forecastCities.Count(); i++)
            {

                ListViewItem row = new ListViewItem(ListStore.forecastCities[i].getCName());
                row.SubItems.Add(ListStore.forecastCities[i].getMaxTemp().ToString());
                row.SubItems.Add(ListStore.forecastCities[i].getMinTemp().ToString());
                row.SubItems.Add(ListStore.forecastCities[i].getPrecipitation().ToString());
                row.SubItems.Add(ListStore.forecastCities[i].getWindSpeed().ToString());
                row.SubItems.Add(ListStore.forecastCities[i].getHumidity().ToString());


                listView1.Items.Add(row);
            }
        }
    }
}
