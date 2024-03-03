

public class Base
{
    private string _name;
    private string _description;
    protected int _duration;

    public Base()
    {
        _name = null;
        _description = null;
        _duration = 0;

    }
    public Base(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void Spinner(int duration)
    {
        // 4 second animation
        int seconds = duration * 125;
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(seconds);
            Console.Write("\b \b");
        }
    }
    public string Activity()
    {
        
        return "hello";
    }


    public void StartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity. For this activity, {_description} You will do this for {_duration} seconds.");
    }

    public void EndingMessage()
    {
        Console.WriteLine($"Congrats on completing the {_name} activity.");
        Thread.Sleep(2000);
        Console.WriteLine($"You have done this activity for {_duration} seconds.");
        Thread.Sleep(2000);
    }
}