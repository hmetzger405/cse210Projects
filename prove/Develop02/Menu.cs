class Menu
{
    public string[] _menuStrings =
     {
        "Please select one of the following:",
        "1. Create Journal Entry",
        "2. Display Journal",
        "3. Save Journal to File",
        "4. Read Journal from File",
        "5. Quit"
    };

    public int ProcessMenu()
    {
        int userSelection = 0;
        do
        {
            foreach (string menuItem in _menuStrings)
            {
                Console.WriteLine(menuItem);
            }
            userSelection = int.Parse(Console.ReadLine());
        } while (userSelection < 1 || userSelection > 5);
        return userSelection;
    }
}