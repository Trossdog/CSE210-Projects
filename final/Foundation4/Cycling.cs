

public class Cycling : Activity
{
    private int _speed;

    public Cycling(string date, int lengthMinutes, int speed) : base(date, lengthMinutes)
    {
        _speed = speed;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetLengthMinutes()} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min/mile";
    }
    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return _speed * GetLengthMinutes() / 60;
    }

    public override double GetPace()
    {
        return GetLengthMinutes() / GetDistance();
    }

}