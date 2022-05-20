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
    //partial class within ExpensesCalulator space
    public partial class PurchaseProp : Form
    {
        public PurchaseProp()
        {
            InitializeComponent();
        }
        //redirects user to previous page/form
        private void previousUD_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //confirms and validates information, to supply and storage in Dictionary
        private void confirmationUD_Click(object sender, EventArgs e)
        {
            //if to validate if property price is equal to zero
            if (priceUD.Value == 0)
            {
                //displays error is price is 0 
                MessageBox.Show("Price cannot be 0.", "Error");
            }
            //else if to validate if deposit amount is greater than equal to price of property
            else if (depositAmtUD.Value >= priceUD.Value)
            {
                //message to display if deposit amount is greater than property price
                MessageBox.Show("Depost amount cannot be greater than the price!", "Error");
            }
            else
            {
                //calls the Method to get all the values input by the user.
                GetUserInformation(); 

                // Redirects the user to the vehicle choice form.
                this.Hide();
                //creates instance of Vehicle Option Form
                VehicleOption vo = new VehicleOption();
                //displays form 
                vo.ShowDialog();
                this.Show();
            }
        }

        //method to retrieve user values
        public void GetUserInformation()
        {
            //using a string as a key value pair
            string key = "homeloan"; 

            //try catch block
            try
            {
                //if statement to valid if Expense instance from worker class, contains the key value pair
                if (Worker.ExpInstance.GetExp().ContainsKey(key))
                {
                    //if valid, removes key value pair
                    Worker.ExpInstance.GetExp().Remove(key);
                }

                // input values stored in variables
                //attributes of property stored in variables
                double purchasePrice = Convert.ToDouble(priceUD.Value);
                double deposit = Convert.ToDouble(depositAmtUD.Value);
                double interest = Convert.ToDouble(InterestRateUD.Value);
                double repaymentMonths = Convert.ToDouble(NumberMonthlyPayUD.Value);

                //creates loan object called Hl - Home loan, consists of values above to be stored. 
                Loan hL = new Loan(purchasePrice, deposit, interest, repaymentMonths);

                //adds the key value pair to the dictionary for storage
                Worker.ExpInstance.addExp(key, hL); 

                //message dialog displayed to state that the information has be captured
                MessageBox.Show("Loan information stored.");
            }
            catch (Exception)
            {
                //if the validation fails to store values, an error appears 
                MessageBox.Show("Cannot store loan key value pair in the dictionary!", "Error");
            }
        }
    }
}
