using System;
class Program
{
    static void Main(string[] args)
    {
        Random rng = new Random();
        Menu journalMenu = new Menu();
        Journal journal = new Journal(); 

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
                    entry.CreateEntry();
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