//Student Number: 20105661
//PROG6211

using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetPlanning
{

    //(C# Classes and Objects, 2021)
    class Property
    {
        //(C# Variables, 2021)
        double purchasePrice = 0;
        double totalDeposit = 0;
        double interestRate = 0;
        int repaymentPeriod = 0;

        ////(C# Constructors, 2021)
        public void PropertyPrompts()
        {
            //Ask For Inputs

            Console.WriteLine($"What is the Price of the property(Eg: 1000 = R1000): ");
            purchasePrice = Double.Parse(Console.ReadLine());

            Console.WriteLine($"What amount will be your initial deposit(Eg: 1000 = R1000): ");
            totalDeposit = Double.Parse(Console.ReadLine());

            Console.WriteLine($"What is the interest rate in percentages(Eg: 10 = 10%): ");
            interestRate = Double.Parse(Console.ReadLine());

            Console.WriteLine($"What is your preferred payment period (Must be between 240 - 360 months): ");
            repaymentPeriod = int.Parse(Console.ReadLine());

            //Check to see if values are stored correctly

            Console.WriteLine($"R" + purchasePrice);
            Console.WriteLine($"R" + totalDeposit);
            Console.WriteLine($"" + interestRate + "%");
            Console.WriteLine($"" + repaymentPeriod + " Months");
        }

        //Get Methods

        //(C# Properties (Get and Set), 2021)
        public double getPurchasePrice()
        {
            return purchasePrice;
        }

        //(C# Properties (Get and Set), 2021)
        public double getTotalDeposit()
        {
            return totalDeposit;
        }

        //(C# Properties (Get and Set), 2021)
        public double getInterestRate()
        {
            return interestRate;
        }

        //(C# Properties (Get and Set), 2021)
        public int getRepaymentPeriod()
        {
            return repaymentPeriod;
        }

    }
}
