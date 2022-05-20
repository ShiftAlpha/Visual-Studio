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
    public partial class RentProp : Form
    {
        public RentProp()
        {
            InitializeComponent();
        }

        //method to rertieve user information
        public void GetUserInformation()
        {
            //key value pair is string, rent
            string key = "rent";

            //try catch block
            try
            {
                //if the expense instance , retrieved does contain the key value pair
                if (Worker.ExpInstance.GetExp().ContainsKey(key))
                {
                    //the value key will be removed 
                    Worker.ExpInstance.GetExp().Remove(key);
                }
                //variables will be assigned to the values the user that input
                double monthlyRent = Convert.ToDouble(rentAmtUD.Value);

                //Rent object, consisting of monthly rent amount.value
                Rent rent = new Rent(monthlyRent);

                //addsthe key value pair which consists of the object attributes
                //which is then stored in the dictionary
                Worker.ExpInstance.addExp(key, rent); 

                //displays messsage dialog if the storage of the pair is successful
                MessageBox.Show("Rent information successfully captured.");

            }
           
            catch (Exception)
            {
                //message displayed if the key value pair could not be stored in the dictionary
                MessageBox.Show("Cannot store Rent key value pair in the dictionary!", "Error");
            }
        }
        //button to redirect the user to the previous page
        private void previousBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        private void confirmationUD_Click(object sender, EventArgs e)
        {

        }
    }
}
