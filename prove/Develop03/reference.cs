

class Reference
{
    // create objects
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    // multiple constructors for the reference with single or multiple verses
    public Reference(string book, int chapter, int verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._startVerse = verse;
        this._endVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        this._book = book;
        this._chapter = chapter;
        this._startVerse = startVerse;
        this._endVerse = endVerse;
    }

    // get reference method to make into string
    public string GetReference()
    {
        if (_startVerse == _endVerse)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}