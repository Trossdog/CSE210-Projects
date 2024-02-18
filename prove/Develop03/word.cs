

class Word
{
    // objects
    private string _text;
    private bool _isHidden;

    // Constructor  
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // gets or sets value indicating whether word is hidden
    public bool IsHidden
    {
        get { return _isHidden; }
        set { _isHidden = value; }
    }

    // method to indicate hidden word
    public void Hide()
    {
        _isHidden = true;
    }

    // method to indicate unhidden word
    public void Reveal()
    {
        _isHidden = false;
    }

    // gets text of word
    public string GetText()
    {
        return _text;
    }
}
