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

namespace _18011883_prog6112_task_1_poe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                SingleCityForm sc = new SingleCityForm();
                sc.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select an item");
            }
        }
        private void view_Load(object sender, EventArgs e)
        {
            
            //this.listView1.View = View.Details;
            listView1.Columns.Add("Dates", 160, HorizontalAlignment.Left);
            listView1.Columns.Add("Cities", 160, HorizontalAlignment.Left);

            for (int i = 0; i < ListStore.forecastCities.Count(); i++)

            {


                ListViewItem row = new ListViewItem(ListStore.forecastCities[i].getDate().ToShortDateString());
                row.SubItems.Add(ListStore.forecastCities[i].getCName().ToString());

                listView1.Items.Add(row);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CreateForecast cf = new CreateForecast();
            cf.Show();
            this.Hide();
        }


    }
}
   
    


