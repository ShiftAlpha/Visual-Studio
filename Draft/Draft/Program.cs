using System;

namespace Draft
{
    class Program
    {
        static void Main(string[] args)
        {
            //prints hello world
            Console.WriteLine("Hello World!");

            //variables and dataTypes
            string charName = "Dhirav";
            char grade = 'A';
            int age = 0;
            double gpa = 3.3;
            Boolean isMale = false;
            
          /*float 
            decimal
            double */

            //reads line
            Console.ReadLine();

            //String manip

            //new line
            Console.WriteLine("\n");
            //length
            Console.WriteLine(charName.Length);
            //index of
            Console.WriteLine(charName[4]);
            Console.WriteLine(charName.IndexOf('X'));

            Console.Write("Enter your name");
            string name = Console.ReadLine();
            Console.Write("Enter your age");
            string newAge = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " +newAge);

            //arrays
            int[] luckyNumbers = { 5, 3 };
            Console.WriteLine(luckyNumbers[1]);

            //methods
            SayHi("Mike");
            static void SayHi(string name)
            {
                Console.WriteLine("Hello "+name);
            }

            //return statements
            Console.WriteLine(cube(5));
            static int cube(int variable)
            {
                int result = variable * variable;
                return result;
            }

            //if statements
            isMale = true;
            bool isTall = true;
            if (isMale && isTall)
            {
                Console.WriteLine("You are male and tall");
            }
            else if(!isMale && isTall)
            {
                Console.WriteLine("You are female and tall");
            }
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are male and not tall");
            }
            else if (!isTall && !isMale) 
            {
                Console.WriteLine("You are female and not tall");
            }

            //cont.
            Console.WriteLine(GetMax(20, 10, 4));
            static int GetMax(int newNum1, int newNum2, int num3)
            {
                int result;
                if(newNum1 >= newNum2 && newNum1 >= num3)
                {
                    result = newNum1;
                }
                else if(newNum2 >= newNum1 && newNum2 >= num3){
                    result = newNum2;
                }
                else
                {
                    result = num3;
                }
                return result;
            }

            //while loops

            int index = 1;
            while (index <=5)
            {
                Console.WriteLine(index);
                index++;
            }
            Console.ReadLine();

            //for loop
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine(index);

            }
            Console.ReadLine();

            //exponent function

            static int getPow(int baseNum, int powNum)
            {
                int result = 1;
                for (int i = 0; i < powNum; i++)
                {
                    result = result * baseNum;
                }
                return result;
            }

            //2D arrays
            int[,] numberGrid =
           {
                {1, 2},
                {3, 4},
                {5, 6}
            };

            //exception handling
            try
            {
                //try with code
            }
            catch
            {
                //exception
            }
            //object 
            ObjectClass book1 = new ObjectClass("Dhirav");
            book1.title = "Harry potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            ObjectClass book2 = new ObjectClass("Bhavir");
            book2.title = "LOTR";
            book2.author = "Tolkien";
            book2.pages = 400;

            Console.WriteLine(book1.author);
        }
    }
}
