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
}