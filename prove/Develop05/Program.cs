using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        SimpleGoal testGoal = new SimpleGoal("Run", "Run more", 50, false);
        int response = 0;
        while(response != 6)
        {
            response = menu.DisplayMenu();

            Console.WriteLine(testGoal.GetName());

            Console.WriteLine(testGoal.GetFileSystemString());
        }

    }
}