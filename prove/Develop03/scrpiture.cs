

class Scripture
{
    // objects
    private string _reference;
    private List<Word> _wordsList;
    private Random _random;

    // Contructor
    public Scripture(string reference, List<Word> wordsList)
    {
        _reference = reference;
        _wordsList = wordsList;
        _random = new Random();
    }

    // method to check hidden words and display scripture
    public void DisplayScripture()
    {
        Console.WriteLine(_reference);
        foreach (Word word in _wordsList)
        {
            if (word.IsHidden)
            {
                Console.Write(new string('_', word.GetText().Length) + " ");
            }
            else
            {
                Console.Write($"{word.GetText()} ");
            }
        }
        Console.WriteLine();
    }

    // method to hide 3 random words at a time from scripture
    // SHOWING CREATIVITY: Only hid words that were unhidden
    public void HideRandomWords()
    {
        // Filter unhidden words
        List<int> unhiddenIndices = new List<int>();
        for (int i = 0; i < _wordsList.Count; i++)
        {
            if (!_wordsList[i].IsHidden)
            {
                unhiddenIndices.Add(i);
            }
        }

        // Check if there are unhidden words
        if (unhiddenIndices.Count == 0)
        {
            return;
        }

        // Select up to 3 random unhidden words to hide
        int wordsToHide = Math.Min(3, unhiddenIndices.Count);
        for (int i = 0; i < wordsToHide; i++)
        {
            int randomIndex = unhiddenIndices[_random.Next(0, unhiddenIndices.Count)];
            _wordsList[randomIndex].Hide();
            unhiddenIndices.Remove(randomIndex); // Remove the selected index from unhiddenIndices
        }
    }

    // Checks to see if all the words are hidden
    public bool AllWordsHidden()
    {
        foreach (Word word in _wordsList)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }
        return true;
    }
}