

public class Running : Activity
{
    private double _distance;

    public Running(string date, int lengthMinutes, int distance) : base(date, lengthMinutes)
    {
        _distance = distance;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetLengthMinutes()} min) - Distance: {GetDistance()} miles, Speed: {GetDistance() / GetLengthMinutes() * 60} mph. Pace: {GetPace()} min/mile";
    }
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / GetLengthMinutes() * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}