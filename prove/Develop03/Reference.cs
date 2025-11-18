class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private bool _isMultipleVerses;


    public void SetBook(string book)
    {
        _book = book;
    }

    public void SetChapter(int chapter)
    {
       _chapter = chapter;
    }

    public void SetStartVerse(int startVerse)
    {
        _startVerse = startVerse;
    }

    public void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }
    
    public void SetVerseCountTrue()
    {
        _isMultipleVerses = true;
    }

    public string GetReference()
    {
        if (_isMultipleVerses)
        {
            return ($"{_book} {_chapter}:{_startVerse}-{_endVerse}");
        }
        else
        {
            return($"{_book} {_chapter}:{_startVerse}");
        }
    }
}