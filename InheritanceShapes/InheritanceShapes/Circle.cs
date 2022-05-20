using System;
public class Circle : Shape
{  // fields 
    double radius;
    // constructors
    public Circle()
    {
        name = "Circle";
        radius = 0;
    }
    public Circle(double radius)
    {
        name = "Circle";
        this.radius = radius;
    }

    public Circle(string colour, double radius) : base("Circle", colour)
    {
        this.radius = radius;
    }

    // methods 
    public void calcArea()
    {
        Console.WriteLine("Area of " + name + ": " + (Math.PI * radius * radius));
    }

    public void calcPerimeter()
    {
        Console.WriteLine("Perimeter of " + name + ": " + (2 * Math.PI * radius));
    }

    public override string ToString()
    {
        return base.ToString() + "Radius: " + radius + "\n";
    }
}