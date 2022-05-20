using System;

namespace InheritanceShapes
{
    class Program
    {
        public static void Main(string[] args)
        {
            Shape s = new Shape();
            Rectangle r = new Rectangle("Red", 2.0, 3.0);
            Circle c1 = new Circle(5.0);
            Circle c2 = new Circle("Pink", 5.0);

            Console.WriteLine(s);

            Console.WriteLine(r);
            r.calcArea();
            r.calcPerimeter();

            Console.WriteLine(c1.ToString());
            c1.calcArea();
            c1.calcPerimeter();

            Console.WriteLine(c2);
            c2.calcArea();
            c2.calcPerimeter();
        }
    }
}
