class Menu
{
    private string[] _menu =
    {
        "Welcome to the Scripture Memorizer! Input your desired action:",
        "1. Remove Words to Memorize",
        "2. Guess missing words",
        "3. Exit Program"
    };

    public int ProcessMenu()
    {
        Console.Write(" > ");
        return int.Parse(Console.ReadLine());
    }

    public void PrintMenu()
    {
        foreach (string item in _menu)
        {
            Console.WriteLine(item);
        }
    }

    public void Practice(Scripture scripture)
    {
        string input;
        string removedWord;
        string stay = "Y";
        while (stay != "N")
        {
            string newRemovedWord = "";
            scripture.UnHideScripture();
            removedWord = scripture.RemoveRandomPractice();
            removedWord = removedWord.ToLower();
            foreach (char c in removedWord)
            {
                if (!char.IsPunctuation(c))
                {
                    newRemovedWord  += c;
                } 
            }
            scripture.PrintScripture(2);
            Console.Write(" > ");
            input = Console.ReadLine();
            if (input == newRemovedWord)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine($"Incorrect. The correct word was: {newRemovedWord}");
            }
            Console.Write("Continue? (Y/N): \n > ");
            stay = Console.ReadLine();
        }
            
    }
}