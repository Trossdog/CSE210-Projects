


public class ChecklistGoal : Goal
{
    private int _completedCount;
    private int _completionTarget;
    private int _bonusPoints;

    public ChecklistGoal(bool status, string name, int points, int completionTarget, int bonusPoints) : base(status, name, points)
    {
        _completedCount = 0;
        _completionTarget = completionTarget;
        _bonusPoints = bonusPoints;
    }

    public int CompletionTarget
    {
        get { return _completionTarget; }
        set { _completionTarget = value; }
    }

    public int BonusPoints
    {
        get { return _bonusPoints; }
        set { _bonusPoints = value; }
    }
    public int CompletedCount
    {
        get { return _completedCount; }
        set { _completedCount = value; }
    }

    public override void RecordEvent()
    {
        _completedCount++;
        if (_completedCount >= _completionTarget)
        {
            _status = true;
            Console.WriteLine($"Goal {_name} completed with bonus points of {_bonusPoints}");
        }
        else
        {
            Console.WriteLine($"Event recorded for {_name} ({_completedCount}/{_completionTarget})");
        }
    }

    public override string GetCompletionInfo()
    {
        return $"Completed {_completedCount}/{_completionTarget} times";
    }
}