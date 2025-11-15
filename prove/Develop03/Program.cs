class Program
{
    static void Main(string[] args)
    {
        Scripture john = new Scripture("John", 3, 16, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");  
        string choice = "";
        int wordCount = john.GetWordCount();
        int count = 0;
        john.PrintScripture();
        while(choice != "quit" && count < (wordCount))
        {
            choice = Console.ReadLine();
            if (choice != "quit")
            {
                john.RemoveRandom();
                count++;
            }
            john.PrintScripture();
        }
    }
}