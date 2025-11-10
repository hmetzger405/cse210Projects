class Entry
{
    Random rng = new Random();
    public string _date;
    public string _prompt;
    public string _response;
    List<string> prompts = new List<string>
    {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day",
            "How did I see the hand of the Lord in my life today",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
    };

    

    public void Display()
    {
        Console.WriteLine($"{_date}\n{_prompt}\n{_response}\n");
    }
    public string CreateFileSystemString()
    {
        string file = "";
        file = $"{_date}#{_prompt}#{_response}";
        return file;
    }
    public void CreateEntry(string _date, string _prompt, string _response)
    {
    }
    public void CreateEntry()
    {
        _prompt = prompts[rng.Next(prompts.Count + 1)];
        Console.Write("Input Today's Date: ");
        _date = Console.ReadLine();
        Console.WriteLine($"Here is today's prompt:\n{_prompt}");
        _response = Console.ReadLine();
    }
}