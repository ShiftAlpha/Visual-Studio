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
    public partial class viewSelectedForcast : Form
    {
        public viewSelectedForcast()
        {
            InitializeComponent();
        }

        private void vsfBackBtn_Click(object sender, EventArgs e)
        {
            Form1 fo3 = new Form1();
            fo3.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            }
        

         private void vsfOkay_Click(object sender, EventArgs e)
          {
                    this.Close();
          }

         private void viewSelectedForcast_Load(object sender, EventArgs e)

          {
            this.viewSelectForcastListVierw.View = View.Details;
            viewSelectForcastListVierw.Columns.Add("City", 140, HorizontalAlignment.Left);
            viewSelectForcastListVierw.Columns.Add("Maximum Temperature", 110, HorizontalAlignment.Left);
            viewSelectForcastListVierw.Columns.Add("Mininimum Temp", 120, HorizontalAlignment.Left);
            viewSelectForcastListVierw.Columns.Add("Precipertation", 120, HorizontalAlignment.Left);
            viewSelectForcastListVierw.Columns.Add("Wind", 80, HorizontalAlignment.Left);
            viewSelectForcastListVierw.Columns.Add("Humidity", 80, HorizontalAlignment.Left);

            for (int i = 0; i < StoreList.forcastOfCities.Count(); i++)
            {

                ListViewItem row7 = new ListViewItem(StoreList.forcastOfCities[i].getCityName());
                row7.SubItems.Add(StoreList.forcastOfCities[i].getMaxTemp().ToString());
                row7.SubItems.Add(StoreList.forcastOfCities[i].getMinTemp().ToString());
                row7.SubItems.Add(StoreList.forcastOfCities[i].getPrecipertation().ToString());
                row7.SubItems.Add(StoreList.forcastOfCities[i].getWind().ToString());
                row7.SubItems.Add(StoreList.forcastOfCities[i].getHumidity().ToString());


                viewSelectForcastListVierw.Items.Add(row7);
            }
         }
       }
}
    
