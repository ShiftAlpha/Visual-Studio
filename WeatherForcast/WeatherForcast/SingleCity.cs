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
    public partial class SingleCity : Form
    {
        public SingleCity()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void SingleCity_Load(object sender, EventArgs e)
        {
            this.singlecityListView.View = View.Details;
            singlecityListView.Columns.Add("Dates", 160, HorizontalAlignment.Left);
            singlecityListView.Columns.Add("Cities", 160, HorizontalAlignment.Left);

            for (int i = 0; i < StoreList.forcastOfCities.Count(); i++)

            {
              // label1.Text= StoreList.forcastOfCities[i].getCityName();

                ListViewItem row2 = new ListViewItem(StoreList.forcastOfCities[i].getDate().ToShortDateString());
                row2.SubItems.Add(StoreList.forcastOfCities[i].getCityName().ToString());

                singlecityListView.Items.Add(row2);

            }

   

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (singlecityListView.SelectedItems.Count > 0)
            {
                viewSelectedForcast vsf1 = new viewSelectedForcast();
                vsf1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a SINGLE item");
            }
        }

        private void singlecityListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void scdateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void scdateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            singlecityListView.Clear();
           

            //for (int i = 0; i<= StoreList.forcastOfCities.Count; i++) 
            //{
            //    string date = StoreList.forcastOfCities[i].getDate().ToString();
            //    string datepick = singlecityListView.Items.ToString();

            //    if (date.Equals(datepick))
            //    {
            //        ListViewItem row4 = new ListViewItem(StoreList.forcastOfCities[i].getDate().ToShortDateString());

            //        singlecityListView.Items.Add(row4);
            //    }
            //    else {
            //        MessageBox.Show("No Items exist of selected date");
            //    }
            //}
           
        }
    }
}
