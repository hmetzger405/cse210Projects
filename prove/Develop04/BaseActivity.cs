class BaseActivity
{
    private string _welcomeMessage;
    private string _description;
    private string _endingMessage;
    private int _time = -1;
    private DateTime _startTime;
    private DateTime _endTime;
    public List<string> _prompts;
    private Random rng = new Random();

    public BaseActivity(string welcomeMessage, string description, string endingMessage, List<string> prompts)
    {
        _welcomeMessage = welcomeMessage;
        _description = description;
        _endingMessage = endingMessage;
        _prompts = prompts;
    }

    public void StartActivity()
    {
        Console.WriteLine($"{_welcomeMessage}\n\n{_description}\n");
        GetTimeLength();
    }

    public void EndActivity()
    {
        Console.WriteLine($"{_endingMessage}");
    }

    public void GetTimeLength()
    {
        do
        {
            Console.Write("How long, in seconds, would you like your session? ");
            try
            {
                _time = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid number, please try again");
                _time = -1;
            }
        } while(_time == -1);
    }

    public void DisplayPrompt(List<string> prompts)
    {
        Console.WriteLine(prompts[rng.Next(0, prompts.Count)]);
        Thread.Sleep(4000);
    }
    

}