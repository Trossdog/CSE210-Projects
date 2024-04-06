using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("123 Main St", "Anytown", "AK", "12345", "USA");
        Address receptionAddress = new Address("3028 Hoo Nose", "Sum Wear", "IL", "28376", "Canada");
        Address outdoorAddress = new Address("8675", "John Town", "MO", "02020", "Italy");

        Lecture lectureEvent = new Lecture(100, "John Doe", "Tech Talk", "A talk that will go over the use of AI today", "2024-04-10", "10:00 AM", lectureAddress);
        Reception receptionEvent = new Reception("lol@GeeMail.com", "Networking Event", "Meet with people to set up internships or just get to know people", "2024-04-15", "6:00 PM", receptionAddress);
        OutdoorGathering outdoorEvent = new OutdoorGathering("Sunny", "Picnic", "We are making hot dogs :)", "2024-04-20", "12:00 PM", outdoorAddress);

        Console.WriteLine("--------------------------------");
        Console.WriteLine("Standard Details:");
        Console.WriteLine("--------------------------------");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine(outdoorEvent.GetStandardDetails());
        
        Console.WriteLine("\n--------------------------------");
        Console.WriteLine("Full Details:");
        Console.WriteLine("--------------------------------");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(outdoorEvent.GetFullDetails());

        Console.WriteLine("\n--------------------------------");
        Console.WriteLine("Short Descriptions:");
        Console.WriteLine("--------------------------------");
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine(outdoorEvent.GetShortDescription());
    }
}