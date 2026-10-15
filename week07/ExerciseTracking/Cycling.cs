using System;

public class Cycling : Activity
{
    // Member variable
    private double _speed;

    // Constructor
    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    // Methods
    public override double GetDistance()
    {
        return (GetSpeed() * GetMinutes() / 60);
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return (60.0 / GetSpeed());
    }

    public override string GetActivityName()
    {
        return "Cycling";
    }
}