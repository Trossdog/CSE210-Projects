


using System.Diagnostics.Contracts;

public class EternalGoal : Goal
{

    public EternalGoal(bool status, string name, int points) : base(status, name, points)
    {}

    public override bool IsComplete()
    {
        return false;
    }
}