using System.Drawing;

abstract class Goal
{
    private string _name;
    private string _description;
    private int _numberOfPoints;
    private bool _status;
    private string _goalType;

    public Goal(string name, string description, int points, bool status)
    {
        _name = name;
        _description = description;
        _numberOfPoints = points;
        _status = status;
        _goalType = "";
    }

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }
    public void SetPoints(int points)
    {
        _numberOfPoints = points;
    }
    public int GetPoints()
    {
        return _numberOfPoints;
    }
    public bool GetStatus()
    {
        return _status;
    }
    public void MarkComplete()
    {
        _status = true;
    }

    public virtual string GetConsoleString()
    {
        return $"Name: {_name}, Description: {_description}, Points: {_numberOfPoints}, Status: {_status}";
    }

    public virtual string GetFileSystemString()
    {
        return $"{_goalType}#{_name}#{_description}#{_numberOfPoints}#{_status}";
    }

    public virtual string GetGoalType()
    {
        return _goalType;
    }

    public abstract int RecordEvent();

    public abstract void CreateGoal();
}