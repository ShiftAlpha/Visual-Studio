using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpCalculator
{
    //class extends from expense/exp class
    public class Finance : Exp
    {
        //variables to be attributed to the (vehicle) finance class
        private string vehicleMake;
        private string vehicleModel;
        private double vehiclePrice;
        private double vehicleDeposit;
        private double vehicleInterest;
        private double vehicleInsurance;

        //constructor to pass variables
        public Finance(string vehicleMake, string vehicleModel, double vehiclePrice, double vehicleDeposit, double vehicleInterest, double vehicleInsurance)
        {
            this.vehicleMake = vehicleMake;
            this.vehicleModel = vehicleModel;
            this.vehiclePrice = vehiclePrice;
            this.vehicleDeposit = vehicleDeposit;
            this.vehicleInterest = vehicleInterest;
            this.vehicleInsurance = vehicleInsurance;
        }

        //getters and setters for (vehicle) finance class 
        public string VehicleMake { get => vehicleMake; set => vehicleMake = value; }
        public string VehicleModel { get => vehicleModel; set => vehicleModel = value; }
        public double VehiclePrice { get => vehiclePrice; set => vehiclePrice = value; }
        public double VehicleDeposit { get => vehicleDeposit; set => vehicleDeposit = value; }
        public double VehicleInterest { get => vehicleInterest; set => vehicleInterest = value; }
        public double VehicleInsurance { get => vehicleInsurance; set => vehicleInsurance = value; }

        //method for calculating vehicle repayments
        public double calcVehicleRepayments()
        {
            //variable for number of months 
            double monthlyRepayments;
            //price is calculated by the difference between vehicle price and deposit
            double price = vehiclePrice - vehicleDeposit;
            //interest rate of vehicle
            double interest = vehicleInterest / 100;
            //term of vehicle finance
            double numberOfYears = 5;
            //vehicle insurance
            double insurance = vehicleInsurance;

            //to calc monthly repayments of vehicle 
            // formulae is taken from siyavula
            //
            monthlyRepayments = ((price * (1 + (interest * numberOfYears))) / 60) + insurance;

            //returns value rounded off to two decimal places, by maths class
            return Math.Round(monthlyRepayments, 2);
        }

        //output method
        //outputs the information and calculations
        public override string outPutExp()
        {
            string vehicle = "Vehicle Payment Information:\n\n";
            vehicle += $"{"Vehicle Make:",-35}{vehicleMake}\n";
            vehicle += $"{"Vehicle Model:",-35}{vehicleModel}\n";
            vehicle += $"{"Vehicle Price:",-35}R{vehiclePrice}\n";
            vehicle += $"{"Total Deposit:",-35}R{vehicleDeposit}\n";
            vehicle += $"{"Interest Rate:",-35}{vehicleInterest}%\n";
            vehicle += $"{"Monthly Insurance:",-35}R{vehicleInsurance}\n";
            vehicle += $"{"Number Of Monthly Repayments",-35}{"60"}\n";
            vehicle += $"{"Monthly Repayments:",-35}R{calcVehicleRepayments()}\n\n";
            return vehicle;
        }
    }
}
