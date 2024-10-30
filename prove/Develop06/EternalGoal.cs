using System;
public class EternalGoal : Goal
{
    private bool _isComplete;

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }
    public override void RecordEvent()
    {
        _isComplete = false;
    }
    public override bool IsComplete()
    {
        return IsComplete();
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName}, {_description}, (POINTS: {_points})";
    }
    
}

