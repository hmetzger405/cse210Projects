class Goals
{
    private List<Goal> _goals = new List<Goal>();
    private string _fileName;
    private int _totalScore;
    
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("The Goals Are: ");
        int i = 1;
        foreach(Goal goal in _goals)
        {
            if (goal.GetStatus())
            {
                Console.WriteLine($"{i}. [X] {goal.GetConsoleString()}");
                i++;
            }
            else
            {
                Console.WriteLine($"{i}. [ ] {goal.GetConsoleString()}");
                i++;
            }
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the name of the file?: ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetFileSystemString());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the name of the file?: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach(var line in lines)
        {
            string[] parts = line.Split("#");

            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);
            bool status = bool.Parse(parts[4]);

            if (goalType == "SimpleGoal")
            {
                SimpleGoal simple = new SimpleGoal(name,description, points, status);
                _goals.Add(simple);
            }
        }
    }
}