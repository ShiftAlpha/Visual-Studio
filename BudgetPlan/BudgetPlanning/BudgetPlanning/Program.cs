//Student Number: 20105661
//PROG6211

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetPlanning
{
    //(C# Classes and Objects, 2021)
    class Program
    {
        //(C# Variables, 2021)
        static double afterTaxDeduction = 0;
        static double afterAllDeduction = 0;
        static double monthlyRepayment = 0;

        ////(C# Constructors, 2021)
        static void Main(string[] args)
        {
            Console.WriteLine("Budget Planning Application: Lets Begin....................................\r\n");
            Console.WriteLine($"Press any key to Continue to Expense Inputs");
            Console.ReadKey();
            //Creates a new obj of Expenses Class
            Expenses expenses = new Expenses();
            //Prompts User With Expense Method Inputs
            Console.WriteLine("Expenses Guide: Lets Begin....................................\r\n");
            expenses.ExpensePrompts();
            //Calls the Expenses Methods for Calculating different Expenses
            Console.WriteLine($"\r\nYour expenses per Month: {expenses.MonthlyExpenses().ToString("c")}");
            Console.WriteLine($"Your daily expenses: {expenses.DailyExpenses().ToString("c")}\r\n");
            Console.WriteLine($"Press any key to Continue to Income Inputs");
            Console.ReadKey();

            Console.WriteLine("Income Guide: Lets Begin....................................\r\n");
            //Creates instance of Income Class
            Income income = new Income();
            //Prompts User With Income Method Inputs
            income.IncomePrompts();
            //Calls the Income Methods for Inputing and Tallying Up Income
            Console.WriteLine($"\r\n\r\nTotal Monthly Income: {income.getMonthlyIncome().ToString("c")}");

            //Calculation for Monthly Income After Tax Deduction
            afterTaxDeduction = (income.getMonthlyIncome() * (100 - income.getTax())/100);

            //Calculation for Monthly Income After All Deduction
            afterAllDeduction = afterTaxDeduction - expenses.MonthlyExpenses();

            Console.WriteLine($"\r\n\r\nMonthly Income After Tax Deductions: {(afterTaxDeduction).ToString("c")}");
            Console.WriteLine("\n\n\n");
            Console.WriteLine($"Press any key to Continue to Property Inputs\n\n\n");
            Console.ReadKey();

            Console.WriteLine("Property Guide: Lets Begin....................................\r\n");
            //Creates a new obj of Expenses Class
            Property property = new Property();
            //Prompts User With Expense Method Inputs
            property.PropertyPrompts();

            //Calculation for Monthly Repayment
            monthlyRepayment = ((property.getPurchasePrice() - property.getTotalDeposit())*(1 + ((property.getInterestRate()/100) * (property.getRepaymentPeriod()/12))))/property.getRepaymentPeriod();

            Console.WriteLine($"\r\nYour Monthly Repayment is: {monthlyRepayment.ToString("c")}");

            if(monthlyRepayment > (income.getMonthlyIncome()/3))
            {
                Console.WriteLine($"ALERT: Your gross monthly income is below the minimum for this home loan repayment\r\n");
                Console.WriteLine($"ALERT: You May Be Declined For This Home Loan\r\n");
            }
            else
            {
                Console.WriteLine($"SUCCESS: Your gross monthly income is above the minimum for this home loan repayment\r\n");
                Console.WriteLine($"SUCCESS: You Are Eligible For This Home Loan\r\n");
            }

            Console.WriteLine($"\r\n\r\nRemaining balance after all expenses and tax deductions: {(afterAllDeduction).ToString("c")}");

            Console.WriteLine($"Thank You For Using Budget Planner");
            Console.ReadKey();
        }
    }
}
