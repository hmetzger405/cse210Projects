using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void Display()
    {
        Console.WriteLine($"{_date}\n{_prompt}\n{_response}\n");
    }
    public void CreateEntry(string _date, string _prompt, string _response)
    {
    }
    public void CreateEntry()
    {
    }
}