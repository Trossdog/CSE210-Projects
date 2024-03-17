

using System.Data;

public class Goal
{
    protected bool _status;
    protected string _name;
    private int _points;

    public Goal(bool status, string name, int points)
    {
        _status = status;
        _name = name;
        _points = points;
    }

    public bool GetStatus() => _status;
    public string GetName() => _name;
    public int GetPoints() => _points;

    public virtual void RecordEvent()
    {
        _status = true;
        Console.WriteLine($"Event recorded for {_name}.");
    }

    public virtual bool IsComplete()
    {
        return _status;
    }

    public virtual int CalculatePoints()
    {
        return _status ? _points : 0;
    }

    public virtual string GetStringStatus()
    {
        return _status ? "[X]" : "[]";
    }

    public virtual string GetCompletionInfo()
    {
        return "";
    }

}