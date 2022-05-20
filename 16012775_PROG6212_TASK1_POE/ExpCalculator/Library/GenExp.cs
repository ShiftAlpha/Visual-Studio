using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpCalculator
{
    public class GenExp : Exp
    {
        //variables to be attributed to the General Expense class
        private double monthlyIncome;
        private double taxDeductions;
        private double groceries;
        private double utilities;
        private double travelCom;
        private double cellTel;
        private double misc;

        //constructor to pass variables
        public GenExp(double monthlyIncome, double taxDeductions, double groceries, double utilities, double travelCom, double cellTel, double misc)
        {
            this.monthlyIncome = monthlyIncome;
            this.taxDeductions = taxDeductions;
            this.groceries = groceries;
            this.utilities = utilities;
            this.travelCom = travelCom;
            this.cellTel = cellTel;
            this.misc = misc;
        }

        //getters and setters for (vehicle) finance class 
        public double MonthlyIncome { get => monthlyIncome; set => monthlyIncome = value; }
        public double TaxDeductions { get => taxDeductions; set => taxDeductions = value; }
        public double Groceries { get => groceries; set => groceries = value; }
        public double Utilities { get => utilities; set => utilities = value; }
        public double TravelCom { get => travelCom; set => travelCom = value; }
        public double CellTel { get => cellTel; set => cellTel = value; }
        public double Misc { get => misc; set => misc = value; }

        //method for calculating Income after expenses 
        public double incomeAfterExp()
        {
            //calculatiion to calculate net income amount 
            //amount is calculated by monthly income subtracted tax deductions etc
            double netIncome = monthlyIncome - taxDeductions - groceries - utilities - travelCom - cellTel - misc;

            //returns variable that is rounded off to two decimal places by the math.round class
            return Math.Round(netIncome, 2);
        }

        //output method
        //outputs the information and calculations
        public override string outPutExp()
        {
            string generanlExpense = "General Expenses:\n\n";
            generanlExpense += $"{"Gross Income:",-35}R{monthlyIncome}\n";
            generanlExpense += $"{"Tax Deduction:",-35}R{taxDeductions}\n";
            generanlExpense += $"{"Groceries:",-35}R{groceries}\n";
            generanlExpense += $"{"Utilities:",-35}R{utilities}\n";
            generanlExpense += $"{"Travel & Commute",-35}R{travelCom}\n";
            generanlExpense += $"{"Miscellaneous:",-35}R{misc}\n\n";
            return generanlExpense;
        }
    }
}
