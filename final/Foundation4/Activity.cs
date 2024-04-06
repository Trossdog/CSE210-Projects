

public class Activity
{
    private string _date;
    private double _lengthMinutes;

    public Activity(string date, int lengthMinutes)
    {
        _lengthMinutes = lengthMinutes;
        _date = date;
    }
    public double GetLengthMinutes()
    {
        return _lengthMinutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public virtual string GetSummary()
    {
        return "";
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }
}