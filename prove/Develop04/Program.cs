using System;

class Program
{
    static void Main(string[] args)
    {
        Base myBase = new Base();
        int check = 0;
        while (check == 0)
        {
            Console.WriteLine("-----Welcome to the relaxation program-----");
            myBase.Spinner(3);

            Console.WriteLine("Please choose from one of these opitons.");
            myBase.Spinner(1);

            Console.WriteLine("1. Breathing Activity");
            myBase.Spinner(1);

            Console.WriteLine("2. Reflection Activity");
            myBase.Spinner(1);

            Console.WriteLine("3. Listing Activity");
            myBase.Spinner(1);

            Console.WriteLine("4. Quit");
            myBase.Spinner(1);

            string userchoice = Console.ReadLine();
            int choice = int.Parse(userchoice);

            string chosen_duration;
            int duration;
            switch (choice)
            {
                case 1:
                    myBase.Spinner(1);
                    Console.WriteLine("How Long would you like to do this activity in seconds?");
                    chosen_duration = Console.ReadLine();
                    duration = int.Parse(chosen_duration);
                    BreathingActivity breathingActivity = new BreathingActivity("breathing", duration);
                    myBase.Spinner(1);
                    breathingActivity.Breathing();
                    duration = 0;
                    break;

                case 2:
                    Console.WriteLine("How Long would you like to do this activity in seconds?");
                    chosen_duration = Console.ReadLine();
                    duration = int.Parse(chosen_duration);
                    ReflectionActivity reflectionActivity = new ReflectionActivity("reflection", duration);
                    reflectionActivity.Reflect();
                    duration = 0;
                    break;

                case 3:
                    Console.WriteLine("How Long would you like to do this activity in seconds?");
                    chosen_duration = Console.ReadLine();
                    duration = int.Parse(chosen_duration);
                    ListingActivity listingActivity = new ListingActivity("listing", duration);
                    listingActivity.ListItems();
                    duration = 0;
                    break;

                case 4:
                    Console.WriteLine("Goodbye");
                    myBase.Spinner(3);
                    check = 1;
                    break;

                default:
                    Console.WriteLine("Please choose a valid option.");
                    break;
            }
        }
    }
}