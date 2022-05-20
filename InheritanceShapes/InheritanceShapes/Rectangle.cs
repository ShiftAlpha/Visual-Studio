using System;
public class Rectangle : Shape
{  // fields 
    double length, width;
    // constructors
    public Rectangle()
    {
        name = "Rectangle";
        length = width = 0;
    }
    public Rectangle(double length, double width)
    {
        name = "Rectangle";
        this.length = length;
        this.width = width;
    }

    public Rectangle(string colour, double length, double width) : base("Rectangle", colour)
    {
        this.length = length;
        this.width = width;
    }
    // methods 
    public void calcArea()
    {
        Console.WriteLine("Area of " + name + ": " + (length * width));
    }
    public void calcPerimeter()
    {
        Console.WriteLine("Perimeter of " + name + ": " + (2 * (length + width)));
    }

    public override string ToString()
    {
        return base.ToString() + "Length: " + length + "\nWidth: " + width + "\n";
    }
}