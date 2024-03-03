

public class ReflectionActivity : Base
{

    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity()
    {
        _prompts = null;
        _questions = null;
    }
    public ReflectionActivity(string name, int duration): base(name, @"you will reflect on times in your life when you have shown strength and resilience.
    This will help you recognize the power you have and how you can use it in other aspects of your life.", duration)
    {
    }

    public void Reflect()
    {
        StartingMessage();
        Spinner(10);
        int remainingSeconds = _duration;

        Random random = new Random();

        while (remainingSeconds > 0)
        {
            string randomPrompt = _prompts[random.Next(_prompts.Count)];
            Console.WriteLine(randomPrompt);
            Spinner(4);
            foreach (string question in _questions)
            {
                Console.WriteLine(question);
                Spinner(10);
                remainingSeconds -= 10;
                if (remainingSeconds <= 0)
                    break;
            }

        
        }

        EndingMessage();
    }
}