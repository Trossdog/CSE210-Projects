

public class ListingActivity : Base
{

    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private int _itemsListed;

    public ListingActivity(string name, int duration) : base(name, @"will help you reflect on the good things in your 
    life by having you list as many things as you can in a certain area.", duration)
    {
        _itemsListed = 0;
    }

    public void ListItems()
    {
        StartingMessage();
        Spinner(10);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int remainingSeconds = _duration;

        Random random = new Random();

        string randomPrompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(randomPrompt);
        Spinner(3);
        Console.WriteLine($"You have {remainingSeconds} seconds to list items. ");
        Spinner(3);
        Console.WriteLine("Start listing items:");

        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();

            if (input == "")
                break;

            _itemsListed++;

            remainingSeconds = (int)(endTime - DateTime.Now).TotalSeconds;
        }
        Spinner(3);
        Console.WriteLine($"You listed {_itemsListed} items.");
        EndingMessage();
    }
}