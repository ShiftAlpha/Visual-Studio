//Student Number: 20105661
//PROG6211

using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetPlanning
{

    //(C# Classes and Objects, 2021)
    class Income
    {
        //(C# Variables, 2021)
        double grossMonthlyIncome = 0;
        int estimatedMonthlyTax = 0;

        ////(C# Constructors, 2021)
        public void IncomePrompts()
        {
            //Ask For Inputs

            Console.WriteLine($"Enter Your Gross Monthly Income(Eg: 1000 = R1000): ");
            grossMonthlyIncome = Double.Parse(Console.ReadLine());

            Console.WriteLine($"Enter Your Estimated Monthly Tax(Eg: 1000 = R1000): ");
            estimatedMonthlyTax = int.Parse(Console.ReadLine());


            //Check that the values saved correctly
            /*Console.WriteLine($"R" + grossMonthlyIncome);
            Console.WriteLine($"" + estimatedMonthlyTax + "%");*/
        }

        //(C# Properties (Get and Set), 2021)
        public double getMonthlyIncome()
        {
            return grossMonthlyIncome;
        }

        //(C# Properties (Get and Set), 2021)
        public int getTax()
        {
            return estimatedMonthlyTax;
        }
    }
}
