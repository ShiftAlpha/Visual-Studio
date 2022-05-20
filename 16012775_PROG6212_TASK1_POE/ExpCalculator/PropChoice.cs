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
    //partial class property Choice
    public partial class PropChoice : Form
    {
        public PropChoice()
        {
            InitializeComponent();
        }

        //button to redirect the user to the pruchase of property form
        private void propertyPurchaseBtn_Click(object sender, EventArgs e)
        {
            //hides current form
            this.Hide();
            //creates instance of property pruchase form
            PurchaseProp Pp = new PurchaseProp();
            //displays form
            Pp.ShowDialog();
            this.Show();
        }

        //button to redirect the user to the rental of property form
        private void PropertyRentBtn_Click(object sender, EventArgs e)
        {
            //hides current form
            this.Hide();
            //creates instance of property rental form
            RentProp Rp = new RentProp();
            //displays form
            Rp.ShowDialog();
            this.Show();
        }
        //returns to previous form
        //redirects user to previous form
        private void previousBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
