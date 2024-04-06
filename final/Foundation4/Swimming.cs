

public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, int lengthMinutes, double laps) : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public override string GetSummary()
    {
        double RoundedPace = Math.Round(GetPace(), 2);
        return $"{GetDate()} Swimming ({GetLengthMinutes()} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {RoundedPace} min/mile";
    }

    public double GetLaps()
    {
        return _laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetLengthMinutes() * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

}