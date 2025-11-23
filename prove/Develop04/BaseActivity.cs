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

    public BaseActivity(string welcomeMessage, string description, string endingMessage)
    {
        _welcomeMessage = welcomeMessage;
        _description = description;
        _endingMessage = endingMessage;
    }

    public BaseActivity(string welcomeMessage, string description, string endingMessage, List<string> prompts)
    {
        _welcomeMessage = welcomeMessage;
        _description = description;
        _endingMessage = endingMessage;
        _prompts = prompts;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"{_welcomeMessage}\n\n{_description}\n");
        GetTimeLength();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        DisplaySpinner();
    }

    public void EndActivity()
    {
        Console.WriteLine($"\n{_endingMessage}");
        DisplaySpinner();
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
        Console.Write($"\n----{prompts[rng.Next(0, prompts.Count)]}----\n");
    }

    public void CountDown(int time)
    {
        for (int i = 0; i < time; i++)
        {
                Console.Write(time - i);
                Thread.Sleep(1000);
                Console.Write("\b");
        }
        Console.WriteLine(" ");
    }

    public void DisplaySpinner()
    {
        string animationString = "\\|/-";
        int sleepTime = 250;
        int duration = 4;
        int index = 0;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);
        Console.CursorVisible = false;
        while(DateTime.Now < endTime)
        {
            Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }
        Console.Write(" ");
        Console.CursorVisible = true;
    }
    public int GetTime()
    {
        return _time;
    }

    public List<string> GetPrompt()
    {
        return _prompts;
    }


}   