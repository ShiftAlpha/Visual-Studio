using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpCalculator
{
    public class Rent : Exp
    {
        //variables to be attributed to the Rent Amount class
        private double rentAmt;

        //constructor
        public Rent(double rentAmt)
        {
            this.rentAmt = rentAmt;
        }
        //getter and setter
        public double RentAmt { get => rentAmt; set => rentAmt = value; }

        //output 
        public override string outPutExp()
        {
            string Rent = "Rent Information:\n\n";
            //  Rent += $"{"Property Purchase Price:",-35}R{rentAmt}\n\n";
            Rent = Rent + $"{"Property Purchase Price:",-35}R{rentAmt}\n\n";
            return Rent;
        }
    }
}
