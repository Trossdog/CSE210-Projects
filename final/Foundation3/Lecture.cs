

using System.ComponentModel;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(int capacity, string speaker, string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"\nTitle: {Title}\nWhat: {Description}\nDate: {Date}\nTime: {Time}\nWhere: {Address}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

    public override string GetShortDescription()
    {
        return $"\nType of Event: Lecture\nTitle: {Title}\nDate: {Date}";
    }
}