using System.Diagnostics.Contracts;

class BreathingActivity : BaseActivity
{
    public BreathingActivity(string welcomeMessage, string description, string endingMessage)
    : base(welcomeMessage, description, endingMessage) {}
    public void DisplayBreathing(int time)
    {
        bool done = false;
        DateTime start = DateTime.Now;
        while (!done)
        {
            Console.Write("\nBreathe In...");
            CountDown(4);
            Console.Write("\nNow Breath Out...");
            CountDown(6);
            Console.WriteLine(" ");
            if (start.AddSeconds(time) < DateTime.Now)
            {
                done = true;
            }
        }
    } 

    public void DoBreathingActivity()
    {
        StartActivity();
        DisplayBreathing(GetTime());
        EndActivity();
    }
}