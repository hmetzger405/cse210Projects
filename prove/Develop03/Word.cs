class Word
{
    private string _word;
    private bool _isHidden;
    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }
    public string GetWord()
    {
        return _word;
    }

    public void WriteWord()
    {
        if (_isHidden)
        {
            foreach (char c in _word)
            {
                Console.Write("_");
            }
            Console.Write(" ");
        }
        else
        {
            Console.Write($"{_word} ");
        }
    }
    public void RemoveWord()
    {
        _isHidden = true;
    }

    public void UnhideWord()
    {
        _isHidden = false;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }
}