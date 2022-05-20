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
    //partial class form to purchase vehicle
    public partial class PurchaseVehicle : Form
    {
        public PurchaseVehicle()
        {
            InitializeComponent();
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            //redirects user to previous pair
            this.Close();
        }

        //confirmation button to validate information supplied by the user
        //redirects the user if successful
        private void ConfirmationBtn_Click(object sender, EventArgs e)
        {
            // If statements to validate user input.
            //use .trim method to trim off edges, if any white space has been input
            if (vehicleMakeTB.Text.Trim().Equals("") || vehicleModelTB.Text.Trim().Equals(""))
            {
                //displays error message if user inputs null values in text boxes
                MessageBox.Show("Vehicle make and model cannot be blank!", "Error");
            }
            //else if statement to check if price of vehicle is equal to 0 
            else if (vehiclePriceUD.Value == 0)
            {
                MessageBox.Show("Vehicle purchase price cannot be 0!", "Error");
            }
            //else if statement to check if deposit amount is greater than price of vehicle amount
            else if (vehicleDepositUD.Value >= vehiclePriceUD.Value)
            {
                //displays error message if deposit is greate than vehicle price
                MessageBox.Show("Deposit is not to be greater than vehicle price", "Error");
            }
            else
            {
                //if all if statments are invalid in this case, meaning the users values are valid
                //the methid Get user Information is called
                GetUserInformation(); 

                // Redirects the user to the Report Form
                this.Hide();
                //creates expense reportform instance
                ExpenseReport ER = new ExpenseReport();
                //displays form
                ER.ShowDialog();
                this.Show();
            }
        }

        //method to retrive user information with regards to vehicle purchasing
        public void GetUserInformation()
        {
            // The key valiue pair for vehicle finance
            string key = "vehicle"; 

            //try catch block
            try
            {
                //if statement to validate if expense instance after retriving expenses info via the GetExp method, contains the key value pair
                if (Worker.ExpInstance.GetExp().ContainsKey(key))
                {
                    //if the expense instance does contain the value pair, it is then removed
                    Worker.ExpInstance.GetExp().Remove(key);
                }

                // User input values assigned to variables
                string vehicleMake = vehicleMakeTB.Text;
                string vehicleModel = vehicleModelTB.Text;
                double purchasePrice = Convert.ToDouble(vehiclePriceUD.Value);
                double deposit = Convert.ToDouble(vehicleDepositUD.Value);
                double interest = Convert.ToDouble(InterestRateUD.Value);
                double insurance = Convert.ToDouble(InsurancePremiumUD.Value);

                //Finance class object instance created, attributes are housed in this object
                Finance f = new Finance(vehicleMake, vehicleModel, purchasePrice, deposit, interest, insurance);

                //adds to the key value pair, the object attribute values
                Worker.ExpInstance.addExp(key, f); 

                //shows success message if the values are stored in the dictionary
                MessageBox.Show("Vehicle Finance information stored successfully.");
            }
            catch (Exception)
            {
                //error message is displayed if the information/key value pair could not be stored in the dictionary 
                MessageBox.Show("Unable to store Finance key value pair in the dictionary!", "Error");
            }
        }
    }
}
