class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool status)
    : base(name, description, points, status){}

    public override void CreateGoal()
    {
    }

    public override int RecordEvent()
    {
        return 0;
    }
}