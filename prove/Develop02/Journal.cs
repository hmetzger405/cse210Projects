using System.IO;
class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void SaveToFile()
    {
        Console.Write("What is the name of the file?: ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(var entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}#{entry._prompt}#{entry._response}");
            }
        }
    }
    public void ReadFromFile()
    {
        Console.Write("What is the name of the file?: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach(var line in lines)
        {
            string[] parts = line.Split("#");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            Entry entry = new Entry();
            entry.CreateEntry(date, prompt, response);
            _entries.Add(entry);
        }
    }

}