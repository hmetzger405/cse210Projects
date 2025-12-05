class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points, bool status)
    : base(name, description, points, status, "EternalGoal"){}

    public EternalGoal() : base(null, null, 0, false, "EternalGoal"){}

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratualions! You earned {GetPoints()} points!");
        return GetPoints();
    }

    public override void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        SetName(Console.ReadLine());   
        Console.Write("What is a description of it? ");
        SetDescription(Console.ReadLine());  
        Console.Write("How many points is the goal worth? ");
        bool success = false;
        while(!success)
        {
            try
            {
                SetPoints(int.Parse(Console.ReadLine()));
                success = true;
            }
            catch
            {
                Console.Write("Please Input an Integer Value: ");
            }
        }
    }
}