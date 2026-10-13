using System;

public class EternalGoal : Goal
{
    // Member variable : None

    // Constructor
    public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        
    }

    // Methods
    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}