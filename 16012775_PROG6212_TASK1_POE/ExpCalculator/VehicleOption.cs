using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//16012775_PROG_Task 1
namespace ExpCalculator
{
    //partial class
    public partial class VehicleOption : Form
    {
        public VehicleOption()
        {
            InitializeComponent();
        }

        private void previousUD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VehiclePurchaseUD_Click(object sender, EventArgs e)
        {
            //redirects the user to the vehicle purchasing form.
            //hides current form
            this.Hide();
            //creates instance of form Purchase Vehicle, called PV
            PurchaseVehicle PV = new PurchaseVehicle();
            //displays form
            PV.ShowDialog();
            this.Show();
        }

        private void VehicleDoNotUD_Click(object sender, EventArgs e)
        {
            // Redirects the user to the Expense report form.
            //hides the current form
            this.Hide();
            //creates instance of Expense report, called ER
            ExpenseReport ER = new ExpenseReport();
            //displays form
            ER.ShowDialog();
            this.Show();
        }
    }
}
