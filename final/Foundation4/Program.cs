using System;

class Program
{
    static void Main(string[] args)
    {
        Cycling cyclingActivity = new Cycling("2024-04-05", 60, 15);
        Running runningActivity = new Running("2024-04-06", 45, 3);
        Swimming swimmingActivity = new Swimming("2024-04-07", 30, 10);
        
        List<Activity> activities = new List<Activity>();
        activities.Add(cyclingActivity);
        activities.Add(runningActivity);
        activities.Add(swimmingActivity);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}