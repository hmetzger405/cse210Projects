using System.Runtime.CompilerServices;

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
            else if (goalType == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(name, description, points, status);
                _goals.Add(eternalGoal);
            }
            else if(goalType == "CheckListGoal")
            {
                int completions = int.Parse(parts[5]);
                int max = int.Parse(parts[6]);
                CheckListGoal checkListGoal = new CheckListGoal(name, description, points, status, completions, max);
                _goals.Add(checkListGoal);
            }
        }
    }   
    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        int i = 1;
        int response = 0;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetName()}");
            i++;
        }
        Console.Write("Which goal did you accomplish? ");
        do
        {
            try
            {
                response = int.Parse(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("Input must be an integer");
            }
        }while(!(response < i && response > 0));
        _totalScore += _goals[response-1].RecordEvent();
        Console.WriteLine($"You now have {_totalScore} points");
    }

    public int GetTotalPoints()
    {
        return _totalScore;
    }
}