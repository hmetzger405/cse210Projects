class Program
{
    static void Main(string[] args)
    {
        Scripture john = new Scripture("John", 3, 16, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");  
        Menu menu = new Menu();
        string choice = "";
        int wordCount = john.GetWordCount();
        int count = 0;
        int menuChoice;
        menu.PrintMenu();
        menuChoice = menu.ProcessMenu();
        switch (menuChoice)
        {
            case 1:
                john.PrintScripture(1);
                while(choice != "quit" && count < (wordCount))
                {
                    choice = Console.ReadLine();
                    if (choice != "quit")
                    {
                        john.RemoveRandom();
                        count++;
                    }
                    john.PrintScripture(1);
                }
                break;
            case 2:
                menu.Practice(john);
                break;
            case 3:
                break;


        }


    }
}