using System.Runtime.CompilerServices;

class Scripture
{
    private Random rng = new Random();
    private Reference _reference = new Reference();
    private List<Word> _words = new List<Word>();


    public Scripture(string book, int chapter, int startVerse, string text)
    {
        _reference.SetBook(book);
        _reference.SetChapter(chapter);
        _reference.SetStartVerse(startVerse);
        ConvertToWords(text);
    }
    public Scripture(string book, int chapter, int startVerse, int endVerse, string text)
    {
        _reference.SetBook(book);
        _reference.SetChapter(chapter);
        _reference.SetStartVerse(startVerse);
        _reference.SetEndVerse(endVerse);
        _reference.SetVerseCountTrue();
        ConvertToWords(text);
    }


    public Scripture(Reference reference)
    {
        _reference = reference;    
    }

    public void PrintScripture(int method)
    {
        Console.Clear();
        if (method == 1)
        {
            Console.Write($"Welcome to the Scripture Memorizer. Press enter to remove a word, and quit when you are done.\n{_reference.GetReference()} - ");
        }
        else
        {
            Console.Write($"Type the missing word in lowercase ignoring punctuation\n {_reference.GetReference()} - ");
        }
        foreach (Word word in _words)
        {
            word.WriteWord();
        }
    }

    public void RemoveRandom()
    {
        bool wordRemoved = false;
        while (!wordRemoved)
        {
            int wordIndex = rng.Next(0, _words.Count);
            if (!_words[wordIndex].GetIsHidden())
            {
                _words[wordIndex].RemoveWord();
                wordRemoved = true;
            }
        }
    }

    public string RemoveRandomPractice()
    {
        bool wordRemoved = false;
        string stringOfWord = "";
        while (!wordRemoved)
        {
            int wordIndex = rng.Next(0, _words.Count);
            if (!_words[wordIndex].GetIsHidden())
            {
                _words[wordIndex].RemoveWord();
                stringOfWord = _words[wordIndex].GetWord();
                wordRemoved = true;
            }
        }
        return stringOfWord;
    }

    public int GetWordCount()
    {
        return _words.Count;
    }

    public void UnHideScripture()
    {
        foreach(Word word in _words)
        {
            word.UnhideWord();
        }
    }

    private void ConvertToWords(string text)
    {
        string[] parts = text.Split(' ');
        foreach(string word in parts)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }
}