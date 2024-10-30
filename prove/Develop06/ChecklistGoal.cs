using System;
using System.Formats.Tar;
public abstract class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool isComplete;

    public ChecklistGoal(string name, string description, int points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        int _amountCompleted = amountCompleted;
        int _target = target;
        int _bonus = bonus;
    }
    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName}: {_description} (Completed: {_amountCompleted}/{_target})";
    }
    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
    }
}