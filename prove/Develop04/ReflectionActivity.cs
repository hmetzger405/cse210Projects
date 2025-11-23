class ReflectionActivity : BaseActivity
{
    private List<string> _secondaryPrompts = ["Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?"];
    public ReflectionActivity(string welcomeMessage,string description, string endingMessage)
    : base(welcomeMessage, description, endingMessage)
    {
        _prompts = ["Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."];
    }

    public void ListPrompts(int time)
    {
        Console.Clear();
        bool done = false;
        DateTime startTime = DateTime.Now;
        Console.WriteLine("");
        while (!done)
        {
            Console.Write("\n> ");
            DisplayPrompt(_secondaryPrompts);
            DisplaySpinner();
            if (startTime.AddSeconds(time) < DateTime.Now)
            {
                done = true;
            }
        }
    }
    public void DoReflectionActivity()
    {
        StartActivity();
        Console.WriteLine("Consider the Following Prompt:\n");
        DisplayPrompt(GetPrompt());
        Console.WriteLine("\nWhen you have something in mind, press enter to continue: ");
        Console.ReadLine();
        Console.WriteLine("Now think about each of the coming questions in relation the this experience\nYou may begin in: ");
        CountDown(5);
        ListPrompts(GetTime());
        EndActivity();
    }
}