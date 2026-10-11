using System;

public class Circle : Shape
{
    // Member variable
    private double _radius;

    // Constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // Method
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}