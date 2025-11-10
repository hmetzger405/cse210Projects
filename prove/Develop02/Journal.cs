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

    }
    public void ReadFromFile()
    { }

}