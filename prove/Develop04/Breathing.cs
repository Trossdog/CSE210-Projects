

public class BreathingActivity : Base
{



    public BreathingActivity()
    {
        
    }
    public BreathingActivity(string name, int duration): base(name, "we will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", duration)
    {
        _duration = duration;
    }
    
    public void Breathing()
    {
        StartingMessage();
        Spinner(5);

        int remainingSeconds = _duration;

        while (remainingSeconds > 0)
        {
            Console.WriteLine("Breathe in...");
            Spinner(2);
            Console.WriteLine("Breathe out...");
            Spinner(2);

            remainingSeconds -= 4;
        }

        EndingMessage();

    }
    

}