class Journal
{
    private static List<Write> entries = new List<Write>();

    public static void AddEntry(Write entry)
    {
        entries.Add(entry);
    }

    public void WriteNewEntry()
    {
        string randomPrompt = GenerateRandomPrompt();
        Write entry = new Write(randomPrompt, "", "");
        entry.WriteJournalEntry();
    }

    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            entry.DisplayJournalEntry();
            Console.WriteLine("-----------");
        }
    }

    public void LoadJournal()
    {
    Console.WriteLine("Enter the filename to load the journal: ");
    string filename = Console.ReadLine();

       
    entries.Clear();
    using (StreamReader reader = new StreamReader(filename))
    {
        while (!reader.EndOfStream)
        {
            
            string[] entryDetails = reader.ReadLine().Split(',');
            
            if (entryDetails.Length == 3)
            {
                string prompt = entryDetails[0];
                string response = entryDetails[1];
                string date = entryDetails[2];
                
                entries.Add(new Write(prompt, response, date));
            }
        }
    }
    Console.WriteLine("Journal loaded successfully!");
    
    }


    public void SaveJournal()
    {
        Console.WriteLine("Enter the filename to save the journal: ");
        string filename = Console.ReadLine();
       
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.prompt},{entry.response},{entry.date}");
            }
        }
        Console.WriteLine("Journal saved successfully!");
        
    }


    private string GenerateRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What would I change about today?",
            "Who should I visit soon an why?"
        };

        // Choose a random prompt from the list
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}
