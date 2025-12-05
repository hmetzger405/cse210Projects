using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Goals goals = new Goals();
        int response = 0;
        while(response != 6)
        {
            Console.WriteLine($"\nYou Have {goals.GetTotalPoints()} points\n");
            response = menu.DisplayMenu();

            switch(response)
            {
                case 1:
                    response = menu.DisplayCreateGoalMenu();
                    switch(response)
                    {
                        case 1:
                            SimpleGoal simple = new SimpleGoal();
                            simple.CreateGoal();
                            goals.AddGoal(simple);
                            break;
                        case 2:
                            EternalGoal eternal = new EternalGoal();
                            eternal.CreateGoal();
                            goals.AddGoal(eternal);
                            break;
                        case 3:
                            CheckListGoal check = new CheckListGoal();
                            check.CreateGoal();
                            goals.AddGoal(check);
                            break;
                    }
                    break;
                case 2:
                    goals.DisplayGoals();
                    break;
                case 3:
                    goals.SaveGoals();
                    break;
                case 4:
                    goals.LoadGoals();
                    break;
                case 5:
                    goals.RecordEvent();
                    break;
            }
        }

    }
}