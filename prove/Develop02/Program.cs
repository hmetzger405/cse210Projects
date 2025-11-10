using System;
class Program
{
    static void Main(string[] args)
    {
        Random rng = new Random();
        Menu journalMenu = new Menu();
        Jounral journal = new Jounral(); 
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day",
            "How did I see the hand of the Lord in my life today",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        int userSelection;

        bool done = false;

        do
        {
            userSelection = journalMenu.ProcessMenu();

            switch (userSelection)
            {
                case 1:
                    // Create new entry object
                    // Call create on that object
                    // Add the entry to the journal
                    Entry entry = new Entry();
                    entry._prompt = prompts[rng.Next(5)];
                    Console.Write("Input Today's Date: ");
                    entry._date = Console.ReadLine();
                    Console.WriteLine($"Here is today's prompt:\n{entry._prompt}");
                    entry._response = Console.ReadLine();
                    journal.AddEntry(entry);
                    break;
                case 2:
                    // Call jounral.Display()
                    journal.Display();
                    break;
                case 3:
                    // Save to a file
                    journal.SaveToFile();
                    break;
                case 4:
                    // Read from a file
                    journal.ReadFromFile();
                    break;
                case 5:
                    done = true;
                    break;
            }
        } while (!done);
        

    }
}