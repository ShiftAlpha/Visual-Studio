//Student Number: 20105661
//PROG6211

using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetPlanning
{

    //(C# Classes and Objects, 2021)
    class Expenses
    {
        //(C# Variables, 2021)
        double totalDailyExpenses = 0;
        double totalMonthlyExpenses = 0;
        double groceriesExpenses = 0;
        double waterAndLightsExpenses = 0;
        double travelExpenses = 0;
        double cellPhoneExpenses = 0;
        double otherExpenses = 0;

        double[] expensesArr = new double[5];

        ////(C# Constructors, 2021)
        public void ExpensePrompts()
        {
            //Ask For Inputs

            Console.WriteLine($"Enter Your Average Expendature On Groceries(Eg: 1000 = R1000): ");
            expensesArr[0] = Double.Parse(Console.ReadLine());

            Console.WriteLine($"Enter Your Average Expendature On Water and Lights per Month(Eg: 1000 = R1000): ");
            expensesArr[1] = Double.Parse(Console.ReadLine());

            Console.WriteLine($"Enter Your Average Expendature On Travel Costs (Including Fuel)(Eg: 1000 = R1000): ");
            expensesArr[2] = Double.Parse(Console.ReadLine());

            Console.WriteLine($"Enter Your Average Expendature On Your Cellphone and Telephone per Month(Eg: 1000 = R1000): ");
            expensesArr[3] = Double.Parse(Console.ReadLine());

            Console.WriteLine($"If there are any extra Expenses, Please enter them as well as a Lump Sum, if not, please Enter 0 Value(Eg: 1000 = R1000): ");
            expensesArr[4] = Double.Parse(Console.ReadLine());

            groceriesExpenses = expensesArr[0];
            waterAndLightsExpenses = expensesArr[1];
            travelExpenses = expensesArr[2];
            cellPhoneExpenses = expensesArr[3];
            otherExpenses = expensesArr[4];

            //Check to see if values are stored correctly

            /*Console.WriteLine($"R" + groceriesExpenses);
            Console.WriteLine($"R" + waterAndLightsExpenses);
            Console.WriteLine($"R" + travelExpenses);
            Console.WriteLine($"R" + cellPhoneExpenses);
            Console.WriteLine($"R" + otherExpenses);*/

        }

        public double DailyExpenses()
        {
            totalDailyExpenses = (groceriesExpenses + travelExpenses)/30;
            return totalDailyExpenses;
        }

        public double MonthlyExpenses()
        {
            totalMonthlyExpenses = groceriesExpenses + waterAndLightsExpenses + travelExpenses + cellPhoneExpenses + otherExpenses;
            return totalMonthlyExpenses;
        }
    }
}
