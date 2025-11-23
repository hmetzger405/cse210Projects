using System.Data;

class ListingActivity : BaseActivity
{
    
    public ListingActivity(string startMessage, string description, string endMessage)
    : base(startMessage, description, endMessage)
    {
        _prompts = ["Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"];
    }

    public void DoListingActivity()
    {
        StartActivity();
        Console.WriteLine("List as many responses you can with the following prompt:");
        DisplayPrompt(_prompts);
        Console.WriteLine("\nYou can begin in: ");
        CountDown(5);
        bool done = false;
        DateTime start = DateTime.Now;
        int items = 0;
        while (!done)
        {
            InputResponse();
            items++;
            if (start.AddSeconds(GetTime()) < DateTime.Now)
            {
                done = true;
            }
        }
        Console.WriteLine($"You listed {items} items!");
        EndActivity();


    }

    public void InputResponse()
    {
        Console.Write("> ");
        Console.ReadLine();
    }

}