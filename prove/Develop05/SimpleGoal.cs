using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Net;

class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool status)
    : base(name, description, points, status, "SimpleGoal"){}

    public SimpleGoal() : base(null, null, 0, false, "SimpleGoal"){}

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

    public override int RecordEvent()
    {
        return 0;
    }
}