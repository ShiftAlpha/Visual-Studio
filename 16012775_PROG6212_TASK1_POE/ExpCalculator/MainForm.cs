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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //confirms all information supplied by user
        
        private void ConfirmationUD_Click(object sender, EventArgs e)
        {
            //if statement for validation
            if (monthlyIncUD.Value == 0)
            {
                //error message if validation of amounts are below value required
                MessageBox.Show("Monthly Income cannot be 0 or less", "Error");
            }
            //else if statement for validation
            //if tax deductions amount is greater or equal to the monthly income amount, continue algorithm otherwise redirect to error message
            else if (taxDeductionsUD.Value >= monthlyIncUD.Value)
            {
                //error message to display if tax amount is greater than monthly income before tax
                MessageBox.Show("Tax amount cannot be greter than Monthly Income", "Error");
            }
            else
            {
                //if validation is successful
                //retrieve user information
                GetUserInformation(); 
                //re directs user to the type of property choices available
                this.Hide();
                //creates an instance of form
                PropChoice pC = new PropChoice();
                //displays form
                pC.ShowDialog();
                this.Show();
            }
        }
        //method to retrieve user information
        public void GetUserInformation()
        {
            // A key value pair for the general expense 
            string key = "generalExpenses"; 

            //try catch block
            try
            {
                //if Worker(class) Expense Instance , retrieves value that consists of the key value above
                //continue with algorithm
                if (Worker.ExpInstance.GetExp().ContainsKey(key))
                {
                    //Removes key value pair from Worker
                    Worker.ExpInstance.GetExp().Remove(key);
                }

                // User input values.
                //variables assigned to values from text box/ up down increment/decrement
                double grossMonthlyIncome = Convert.ToDouble(monthlyIncUD.Value);
                double estimatedMonthlyTaxDeducted = Convert.ToDouble(taxDeductionsUD.Value);
                double groceries = Convert.ToDouble(groceriesUD.Value);
                double utilities = Convert.ToDouble(UtilitiesUD.Value);
                double travelCommute = Convert.ToDouble(travelComUD.Value);
                double cellTelephone = Convert.ToDouble(CellTelUD.Value);
                double misc = Convert.ToDouble(MiscUD.Value);

                //general expenses object, consists of gross monthly income,
                //tax amount , groceries, utilities, travel commutes, celltell, misc and expense
                GenExp generalExpenses = new GenExp(grossMonthlyIncome, estimatedMonthlyTaxDeducted,
                    groceries, utilities, travelCommute, cellTelephone, misc);

                //calls add expense class, attributes consisting of key value pair, and general expenses
                Worker.ExpInstance.addExp(key, generalExpenses);

                //message dialog to state that the information was captured successfully
                MessageBox.Show("General Expenses information was captured successfully.");
            }
            catch (Exception)
            {
                //if failure to store key value pair, error message is programmed to display
                MessageBox.Show("Unable to store General Expenses key value pair in the dictionary!", "Error");
            }
        }
    }
}
