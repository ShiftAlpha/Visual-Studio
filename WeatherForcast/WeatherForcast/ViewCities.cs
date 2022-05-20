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
    public partial class ViewCities : Form
    {
        public ViewCities()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewCities_Load(object sender, EventArgs e)
        {
            this.viewcitiesLstView.View = View.Details;
            viewcitiesLstView.Columns.Add("Cities", 160, HorizontalAlignment.Left);

            for (int i = 0; i < StoreList.forcastOfCities.Count(); i++)
            {
                ListViewItem row1 = new ListViewItem(StoreList.forcastOfCities[i].getCityName());//displays recent forcast data

                viewcitiesLstView.Items.Add(row1);
            }

        }
    
        

        private void vcSelectBtn_Click(object sender, EventArgs e)
        {
            if (viewcitiesLstView.SelectedItems.Count > 0)
            {
                SingleCity sc1 = new SingleCity();
                sc1.Show();
                this.Hide();
            }
            else {
                MessageBox.Show("Please select an item");
            }
        }

        private void vcSelectManyBtn_Click(object sender, EventArgs e)
        {
            //if (viewcitiesLstView.SelectedItems.Count > 1)
            //{
            //    ManyCities mc1 = new ManyCities();
            //    mc1.Show();
            //    Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Please select MULTIPLE items");
            //}
        }

        private void vcbackBtn_Click(object sender, EventArgs e)
        {
            Form1 fo2 = new Form1();
            fo2.Show();
            this.Hide();
        }
    }
}
