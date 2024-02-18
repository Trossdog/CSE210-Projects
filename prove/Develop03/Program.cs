using System;

class Program
{
    static void Main(string[] args)
    {
        // make a list
        List<Word> wordsList = new List<Word>();

        // hardcode the scripture text for John 3:16
        string[] john316Words = {
            "For", "God", "so", "loved", "the", "world,", "that", "he", "gave", "his", "only", "begotten", "Son,",
            "that", "whosoever", "believeth", "in", "him", "should", "not", "perish,", "but", "have", "everlasting", "life."
        };

        // make Words objects for each word in the scripture text and add them to wordsList
        foreach (string wordText in john316Words)
        {
            Word word = new Word(wordText);
            wordsList.Add(word);
        }

        // makwe a Scripture object for the scripture with its reference and words list
        Reference ForGodSoLoved_reference = new Reference("John", 3, 16);
        Scripture FGSL = new Scripture(ForGodSoLoved_reference.GetReference(), wordsList);

        // Display the scripture
        FGSL.DisplayScripture();

        // Loop until all words are hidden
        while (!FGSL.AllWordsHidden())
        {
            // Prompt the user to press Enter to continue or type "quit" to exit
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                // Exit the loop if the user types "quit"
                break;
            }

            // Clear the console screen
            Console.Clear();

            // Hide a few random words in the scripture
            FGSL.HideRandomWords();

            // Display the updated scripture
            FGSL.DisplayScripture();
        }

        // Display a message indicating that all words are hidden
        Console.WriteLine("All words in the scripture are now hidden. Press Enter to exit.");
        Console.ReadLine();
    }
}