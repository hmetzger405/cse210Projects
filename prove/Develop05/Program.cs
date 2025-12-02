using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Goal testGoal = new Goal("Run", "Run more");
        int response = 0;
        while(response != 6)
        {
            response = menu.DisplayMenu();

            Console.WriteLine(testGoal.GetName());
        }

    }
}