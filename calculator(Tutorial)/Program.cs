using System;

namespace calculator_Tutorial_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            } else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "/") 
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "*") 
            {
                Console.WriteLine(num1 * num2);
            }
            else 
            {
                Console.WriteLine("Invalid Operator");
            }

            switch (op)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 + num2);
                    break;
                case "/":
                    Console.WriteLine(num1 + num2);
                    break;
                case "*":
                    Console.WriteLine(num1 + num2);
                    break;
            }
        }
    }
}
