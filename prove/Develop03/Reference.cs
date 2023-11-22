class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public string Book { get => _book; set => _book = value; }
    public int EndVerse { get => _endVerse; set => _endVerse = value; }
    public int Verse { get => _verse; set => _verse = value; }
    public int Chapter { get => _chapter; set => _chapter = value; }

    // Methods
    public Reference(string book, int chapter, int verse)
    {
        _book=book;
        _chapter = chapter;
        _verse=verse;
        _endVerse=0;
    }
    // Use this when specifying you want a start and end
    public Reference(string book, int chapter, int verse, int endVerse )
    {
        _book=book;
        _chapter = chapter;
        _verse=verse;
        _endVerse=endVerse;
    }
    public string GetDisplayText()
    {
        // if (_verse==_endVerse)
        // {
        //     return $"{_book} {_chapter}:{_verse}";
        // }
        // else
        // {
        //     return $"{_book} {_chapter}:{_verse}={_endVerse}";
        // }
        string displayText = $"{_book} {_chapter}:{_verse}";

        if (_endVerse != 0)
        {
            displayText += $"-{_endVerse}";
        }

        return displayText;
    }
}