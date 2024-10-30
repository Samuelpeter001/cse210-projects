using System;
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
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