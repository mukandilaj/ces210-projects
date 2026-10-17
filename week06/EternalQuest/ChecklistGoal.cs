using System;

public class ChecklistGoal : Goal
{
    // Member variables
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructor
    public ChecklistGoal(string shortName, string description, int points, int amountCompleted, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    // Methods
    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetShortName()},{GetDescription()},{GetPoints()},{_amountCompleted},{_target},{_bonus}";
    }

    public int GetEarnedPoints()
    {
        if (_amountCompleted == _target)
        {
            return GetPoints() + _bonus;
        }
        return GetPoints();
    }
}