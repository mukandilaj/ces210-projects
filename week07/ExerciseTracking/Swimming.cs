using System;

public class Swimming : Activity
{
    // Member variable
    private int _laps;

    // Constructor
    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    // Methods
    public override double GetDistance()
    {
        return (_laps * 50.0) / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return (60.0 / GetSpeed());
    }

    public override string GetActivityName()
    {
        return "Swimming";
    }
}