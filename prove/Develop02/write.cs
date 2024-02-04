class Write
{
    public string prompt;
    public string response;
    public string date;

    public Write(string prompt, string response, string date)
    {
        this.prompt = prompt;
        this.response = response;
        this.date = date;
    }

    public void WriteJournalEntry()
    {
        Console.WriteLine("Enter your response: ");
        Console.WriteLine(prompt);
        response = Console.ReadLine();
        date = DateTime.Now.ToString();

        Journal.AddEntry(new Write(prompt, response, date));
    }

    public void DisplayJournalEntry()
    {
        Console.WriteLine($"Date: {date}");
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine($"Response: {response}");
    }
}