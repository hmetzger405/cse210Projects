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
                            break;
                        case 3:
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
                    break;
                case 5:
                    break;
            }
        }

    }
}