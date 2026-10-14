using System;

public abstract class Goal
{
    // Member variables
    private string _shortName;
    private string _description;
    private int _points;

    // Getters
    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    // Constructor
    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    // Methods
    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[]";
        return $"{status} {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();
}