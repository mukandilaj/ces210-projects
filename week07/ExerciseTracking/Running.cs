using System;

public class Running : Activity
{
    // Member variable
    private double _distance;

    // Constructor
    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    // Methods
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

    public override string GetActivityName()
    {
        return "Running";
    }
}