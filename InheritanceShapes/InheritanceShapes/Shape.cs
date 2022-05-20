using System;
public class Shape
{ // fields 
    protected string name;
    protected string colour;

    // constructor 
    public Shape()
    {
        name = "undetermined";
        colour = "black";
    }

    public Shape(string name, string colour)
    {
        this.name = name;
        this.colour = colour;
    }

    // methods 
    public override string ToString()
    {
        return "Name: " + name + "\nColour: " + colour + "\n";
    }
}