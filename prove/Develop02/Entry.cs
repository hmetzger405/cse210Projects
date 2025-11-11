class Entry
{
    Random rng = new Random();
    DateTime dateTime = DateTime.Now;
    public string _date;
    public string _prompt;
    public string _response;
    List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What did I do today that was unusual for my regular schedule?",
        "How did I see the hand of the Lord in my life today?",
        "What was the hardest part of my day?",
        "If I had one thing I could do over today, what would it be?",
        "What is one lesson I learned today?"
    };

    

    public void Display()
    {
        Console.WriteLine($"\nDate: {_date} - {_prompt}\n{_response}\n");
    }
    public string CreateFileSystemString()
    {
        string file = "";
        file = $"{_date}#{_prompt}#{_response}";
        return file;
    }
    public void CreateEntry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;  
        _response = response;
    }
    public void CreateEntry()
    {
        // Here I added the ability to use a custom prompt
        // While sometimes we don't what to write about, on other days there are significant
        // events we actually are excited to write about that the random prompt might not cover 
        string customPrompt = "";
        while (customPrompt != "Y" && customPrompt != "N")
        {
            Console.Write("Would you like to use a custom prompt? (Y/N): ");
            customPrompt = Console.ReadLine();
        }
        if (customPrompt == "Y")
        {
            Console.Write("Input the prompt you would like to use:\n > ");
            _prompt = Console.ReadLine();
            Console.Write("Your response:\n > ");
        }
        else
        {
            _prompt = prompts[rng.Next(prompts.Count + 1)];
            Console.Write($"Here is today's prompt:\n{_prompt}\n > ");
        }
        _date = dateTime.ToShortDateString();
        _response = Console.ReadLine();
    }
}