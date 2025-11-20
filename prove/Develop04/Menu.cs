class Menu
{
    private List<string> _options = new List<string>
    {
        "Menu Options:",
        "   1. Start Breathing Activity",
        "   2. Start Reflecting Activity",
        "   3. Start Listing Activity",
        "   4. Quit",
    };

    public void PrintMenu()
    {
        foreach (var option in _options)
        {
            Console.WriteLine(option);
        }
    }

    public int ProcessMenu()
    {
        Console.Write("Please input your choice: ");
        try
        {
            return int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Number");
            return 0;
        }
        
    }
}