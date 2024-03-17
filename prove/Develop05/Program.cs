using System;

class Program
{
    static List<Goal> goals = new List<Goal>();

    static void Main(string[] args)
    {


        bool quit = false;
        while (!quit)
        {
            DisplayMenu();
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine($"Current Points: {CalculateTotalPoints()}");
            Console.WriteLine();
        }

        Console.WriteLine("All done!");
        
    }

    static int CalculateTotalPoints()
    {
        int totalPoints = 0;
        foreach (Goal goal in goals)
        {
            if (goal.GetStatus()) 
            {
                totalPoints += goal.GetPoints();
            }
        }
        return totalPoints;
    }

    static void CreateNewGoal()
    {
    Console.WriteLine("Select the type of goal:");
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. Checklist Goal");
    Console.Write("Enter your choice: ");

    if (int.TryParse(Console.ReadLine(), out int choice))
    {
        switch (choice)
        {
            case 1:
                Console.Write("Enter the name of the simple goal: ");
                string name = Console.ReadLine();
                Console.Write("Enter the points for completing the goal: ");
                if (int.TryParse(Console.ReadLine(), out int points))
                {
                    Goal newGoal = new SimpleGoal(false, name, points);
                    goals.Add(newGoal);
                    Console.WriteLine("Simple goal created successfully!");
                }
                else
                {
                    Console.WriteLine("Invalid points value.");
                }
                break;
            case 2:
                Console.Write("Enter the name of the eternal goal: ");
                string eternalName = Console.ReadLine();
                Console.Write("Enter the points for each instance of the eternal goal: ");
                if (int.TryParse(Console.ReadLine(), out int eternalPoints))
                {
                    Goal eternalGoal = new EternalGoal(false, eternalName, eternalPoints);
                    goals.Add(eternalGoal);
                    Console.WriteLine("Eternal goal created successfully!");
                }
                else
                {
                    Console.WriteLine("Invalid points value.");
                }
                break;
            case 3:
                Console.Write("Enter the name of the checklist goal: ");
                string checklistName = Console.ReadLine();
                Console.Write("Enter the points for completing each instance of the goal: ");
                if (int.TryParse(Console.ReadLine(), out int checklistPoints))
                {
                    Console.Write("Enter the completion target for the checklist goal: ");
                    if (int.TryParse(Console.ReadLine(), out int completionTarget))
                    {
                        Console.Write("Enter the bonus points for completing the checklist goal: ");
                        if (int.TryParse(Console.ReadLine(), out int bonusPoints))
                        {
                            Goal checklistGoal = new ChecklistGoal(false, checklistName, checklistPoints, completionTarget, bonusPoints);
                            goals.Add(checklistGoal);
                            Console.WriteLine("Checklist goal created successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid bonus points value.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid completion target value.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid points value.");
                }
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid choice.");
        }
    }


    static void ListGoals()
    {
        Console.WriteLine("List of Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            string completionStatus = goals[i].GetStatus() ? "[X]" : "[]";
            string completionInfo = goals[i] is ChecklistGoal checklistGoal
                ? $"(Completed {checklistGoal.CompletedCount}/{checklistGoal.CompletionTarget})"
                : "";
            Console.WriteLine($"{i + 1}. {completionStatus} {goals[i].GetName()} {completionInfo}");
        }
    }


    static void SaveGoals()
    {
        Console.WriteLine("What file name would you like to save under? ");
        string UserSave = Console.ReadLine();
        try
        {
            using (StreamWriter writer = new StreamWriter(UserSave))
            {
                foreach (Goal goal in goals)
                {
                    if (goal is ChecklistGoal checklistGoal)
                    {
                        writer.WriteLine($"{goal.GetType().Name},{goal.GetStatus()},{goal.GetName()},{goal.GetPoints()},{checklistGoal.CompletionTarget},{checklistGoal.BonusPoints}");
                    }
                    else
                    {
                        writer.WriteLine($"{goal.GetType().Name},{goal.GetStatus()},{goal.GetName()},{goal.GetPoints()}");
                    }
                }
            }
            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }



    static void LoadGoals()
    {
        Console.WriteLine("What file would you like to open from? ");
        string UserLoad = Console.ReadLine();
        try
        {
            goals.Clear(); 
            using (StreamReader reader = new StreamReader(UserLoad))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length >= 4) 
                    {
                        string type = parts[0];
                        bool status = bool.Parse(parts[1]);
                        string name = parts[2];
                        int points = int.Parse(parts[3]);
                        int completionTarget = int.Parse(parts[4]); 
                        int bonusPoints = int.Parse(parts[5]); 

                        switch (type)
                        {
                            case "SimpleGoal":
                                goals.Add(new SimpleGoal(status, name, points));
                                break;
                            case "EternalGoal":
                                goals.Add(new EternalGoal(status, name, points));
                                break;
                            case "ChecklistGoal":
                                goals.Add(new ChecklistGoal(status, name, points, completionTarget, bonusPoints));
                                break;
                            default:
                                Console.WriteLine($"Unknown goal type: {type}");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid data format in goals file.");
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }
    
    static void RecordEvent()
    {
        Console.Write("Enter the index of the goal you want to record an event for: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < goals.Count)
        {
            goals[index].RecordEvent();
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("     1. Create New Goal");
        Console.WriteLine("     2. List Goals");
        Console.WriteLine("     3. Save Goals");
        Console.WriteLine("     4. Load Goals");
        Console.WriteLine("     5. Record Event");
        Console.WriteLine("     6. Quit");
        Console.Write(" Select a choice from the menu: ");
    }
}
