

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string rsvpEmail, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return $"\nTitle: {Title}\nWhat: {Description}\nDate: {Date}\nTime: {Time}\nWhere: {Address}\nRSVP Email: {_rsvpEmail}";
    }

    public override string GetShortDescription()
    {
        return $"\nType of Event: Reception\nTitle: {Title}\nDate: {Date}";
    }
}