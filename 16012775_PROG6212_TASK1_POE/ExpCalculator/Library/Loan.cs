using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpCalculator
{
    public class Loan : Exp
    {
        //variables to be attributed to the (Home) Loan class
        private double propPrice;
        private double propDeposit;
        private double propInterest;
        private double propMonthlyRepayment;

        //constructor to pass variables
        public Loan(double propPrice, double propDeposit, double propInterest, double propMonthlyRepayment)
        {
            this.propPrice = propPrice;
            this.propDeposit = propDeposit;
            this.propInterest = propInterest;
            this.propMonthlyRepayment = propMonthlyRepayment;
        }

        //getters and setters for (Home) Loan class 
        public double PropPrice { get => propPrice; set => propPrice = value; }
        public double PropDeposit { get => propDeposit; set => propDeposit = value; }
        public double PropInterest { get => propInterest; set => propInterest = value; }
        public double PropMonthlyRepayment { get => propMonthlyRepayment; set => propMonthlyRepayment = value; }

        //method for calculating (Home) Loan 
        public double calcLoan()
        {
            //
            double calculatedHomeloan;

            //variable calculations for attributes
            double price = propPrice - propDeposit;
            double interest = propInterest / 100;
            double numberOfMonths = propMonthlyRepayment / 12;

            //calculation for home loan
            calculatedHomeloan = (price * (1 + interest * numberOfMonths)) / propMonthlyRepayment;

            //returns variable that is rounded off to two decimal places by the math.round class
            return Math.Round(calculatedHomeloan, 2);
        }

        //output method
        //outputs the information and calculations
        public override string outPutExp()
        {
            string homeLoan = "Home Loan Information:\n\n";
            homeLoan += $"{"Property Purchase Price:",-35}R{propPrice}\n";
            homeLoan += $"{"Total Deposit:",-35}R{propDeposit}\n";
            homeLoan += $"{"Interest Rate:",-35}{propInterest}%\n";
            homeLoan += $"{"Number Of Repayment Months",-35}{propMonthlyRepayment}\n";
            homeLoan += $"{"Monthly Repayments",-35}R{calcLoan()}\n\n";
            return homeLoan;
        }

    }
}
