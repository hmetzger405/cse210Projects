using System.ComponentModel.DataAnnotations;

class CheckListGoal : Goal
{
    private int _numberOfCompletions;
    private int _maxGoals;
    private int _bonusPoints;
    public CheckListGoal(string name, string description, int points, bool status, int completions, int max)
    : base(name, description, points, status, "CheckListGoal")
    {
        _numberOfCompletions = completions;
        _maxGoals = max;
    }
    public CheckListGoal() : base(null, null, 0, false, "CheckListGoal"){}

    public int GetCompletions()
    {
        return _numberOfCompletions;
    }

    public void SetMax(int max)
    {
        _maxGoals = max;
    }

    public int GetMax()
    {
        return _maxGoals;
    }

    public void SetBonus(int bonus)
    {
        _bonusPoints = bonus;
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
        Console.Write("How many times can the goal be completed? ");
        success = false;
        while(!success)
        {
            try
            {
                SetMax(int.Parse(Console.ReadLine()));
                success = true;
            }
            catch
            {
                Console.Write("Please Input an Integer Value: ");
            }
        }  
        Console.Write("How many bonus points does this goal give? ");
        success = false;
        while(!success)
        {
            try
            {
                SetBonus(int.Parse(Console.ReadLine()));
                success = true;
            }
            catch
            {
                Console.Write("Please Input an Integer Value: ");
            }
        }  
    }

    public override int RecordEvent()
    {
        _numberOfCompletions++;
        if (_numberOfCompletions == _maxGoals)
        {
            Console.WriteLine($"Congratualions! You earned {(GetPoints()) + _bonusPoints} points!");
            MarkComplete();
            return(GetPoints() + _bonusPoints);
        }
        else if (_numberOfCompletions > _maxGoals)
        {
            Console.WriteLine("Goal Already Complete");
            _numberOfCompletions--;
            return 0;
        }
        else
        {
            Console.WriteLine($"Congralations! You earned {GetPoints()} points!");
            return GetPoints();
        }
    }

    public override string GetConsoleString()
    {
        return $"{GetName()} ({GetDescription()}) - Completed {_numberOfCompletions} of {_maxGoals} times";
    }

    public override string GetFileSystemString()
    {
        return $"{GetGoalType()}#{GetName()}#{GetDescription()}#{GetPoints()}#{GetStatus()}#{_numberOfCompletions}#{_maxGoals}";
    }
}