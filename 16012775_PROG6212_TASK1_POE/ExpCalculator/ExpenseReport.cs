using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpCalculator;

//16012775_PROG_Task 1
namespace ExpCalculator
{
    //parytial class extends from MainForm Class
    public partial class ExpenseReport : Form
    {
        //dictionary to for storage of information of user
        Dictionary<string, Exp> allExp;
        //variables for attributes
        //net income ; monthly income before tax; title of report
        double netIncome;
        double monthlyIncome;
        string title = "Report of Budget\n\n";

        public ExpenseReport()
        {
            InitializeComponent();
        }

        //navigates user to previous page
        private void previousBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //terminates program
        private void terminateBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program will now close");
            this.Close();
            System.Environment.Exit(0);
        }

        //loads the rich text box with the storage from the dictionary. 
        private void ExpenseReport_Load(object sender, EventArgs e)
        {
            //generates all expenses 
            //uses dictionary and getExp class to retrieve all expenses to produce report
            allExp = (Dictionary<string>, Exp>)Worker.ExpInstance.GetExp();


        }
    }
}
