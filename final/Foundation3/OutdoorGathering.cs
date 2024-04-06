

public class OutdoorGathering : Event
{
    private string _weatherStatement;

    public OutdoorGathering(string weatherStatement, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _weatherStatement = weatherStatement;
    }

    public override string GetFullDetails()
    {
        return $"\nTitle: {Title}\nWhat: {Description}\nDate: {Date}\nTime: {Time}\nWhere: {Address}\nWeather Statement: {_weatherStatement}";
    }

    public override string GetShortDescription()
    {
        return $"\nType of Event: Outdoor Gathering\nTitle: {Title}\nDate: {Date}";
    }
}