using System;

public abstract class Activity
{
    // Member variables
    private DateTime _date;
    private int _minutes;

    // Getter

    public int GetMinutes()
    {
        return _minutes;
    }

    // Constructor
    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Methods
    public abstract string GetActivityName();
    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public string GetSummary()
    {
        return ($"{_date.ToString("dd MMM yyyy")} {GetActivityName()} ({_minutes} min): Distance {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km");
    }

}