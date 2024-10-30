using System;
using System.Formats.Tar;
public abstract class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        int _amountCompleted = amountCompleted;
        int _target = target;
        int _bonus = bonus;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName}, {_description}, (POINTS: {_points})";
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override void RecordEvent()
    {
        _isComplete = false;
    }
}