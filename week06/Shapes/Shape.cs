using System;

public class Shape
{
    // Member variables
    private string _color;

    // Getter
    public string GetColor()
    {
        return _color;
    }

    // Setter
    public void SetColor(string color)
    {
        _color = color;
    }

    // Constructor
    public Shape(string color)
    {
        _color = color;
    }

    // Method
    public virtual double GetArea()
    {
        return 0;
    }
}