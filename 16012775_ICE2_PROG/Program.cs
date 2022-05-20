using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16012775_ICE2_PROG
{
    class Program
    {
        //first program/pattern
        
        public static void firstPattern()
        {
            //variable to contain number of loops/rows
            int rows;
            //display heading
            Console.Write("\n\n");
            Console.Write("Display a right-angle triangle in asterisk:\n");
            Console.Write("____________________________________________");
            Console.Write("\n\n");
            //input row/loops
            Console.Write("Input number of rows: ");
            //convert to integer 32 bit
            rows = Convert.ToInt32(Console.ReadLine());
            //nested for loop
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    //prints asterisk
                    Console.Write("*");
                    Console.Write("\n");
                }

            }
        }

        //second program/pattern
        public static void Reversefirst()
        {
            //variable to contain number of loops/rows
            int rows;
            //display heading
            Console.Write("\n\n");
            Console.Write("Display a right-angle triangle in asterisk(revsere):\n");
            //input row/loops
            Console.Write("Input number of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());
            //nested for loop with seperate individual loops inside
            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j <= rows - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= rows; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }

        //third program/pattern 
        public static void numRevPattern()
        {
            //variable to contain number of loops/rows
            int rows;
            //display heading
            Console.Write("\n\n");
            Console.Write("Display a right-angle triangle in numbers(revsere):\n");
            //input row/loops
            Console.Write("Input number of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());
            //nested for loop with seperate individual loops inside
            for (int i = 0; i <= rows; i++)
            {
                for (int j = 0; j <= rows - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= rows; k++)
                {
                    Console.Write("{0}", k);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
        
        //fourth program/pattern
        public static void pyramidStar()
        {
            //variable to contain number of loops/rows
            int rows;
            //display heading
            Console.Write("\n\n");
            Console.Write("Display the pattern like pyramid containing odd number of asterisks:\n");
            //input row/loops
            Console.Write("Input number of rows for this pattern :");
            rows = Convert.ToInt32(Console.ReadLine());
            //nested for loop with seperate individual loops inside
            for (int i = 0; i < rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
         }
        
        //fifth program/pattern
        public static void multipleReverse()
        {
            //variable to contain number of loops/rows and number of times the display will recur
            int numPatterns;
            int rows;
            //display heading
            Console.Write("\n\n");
            Console.Write("Display a right-angle triangle in asterisk(revsere):\n");
            //input row/loops
            Console.Write("Input number of rows: ");
            rows = Convert.ToInt32(Console.ReadLine());
            //input number of displays to loop
            Console.Write("Input number of patterns: ");
            numPatterns = Convert.ToInt32(Console.ReadLine());

            //nested for loop with seperate individual loops inside
            for (int k = 0; k < numPatterns; k++)
            {


                for (int i = 0; i <= rows; i++)
                {
                    for (int j = 0; j <= rows - 1; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int l = 0; l <= rows; l++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
                Console.ReadLine();
            }
            
        }
        

        static void Main(string[] args)
        {
            //calls first pattern method (basic asterisk triangle)
            firstPattern();
            //calls reverse pattern(reverse asterisk triangle)
            Reversefirst();
            //calls number reverse pattern( revser number triangle)
            numRevPattern();
            //calls basic pyramid with asterisks displaying shape
            pyramidStar();
            //displays multiple reverse triangle patterns(with asterisks) 
            multipleReverse();

        }
    }
}