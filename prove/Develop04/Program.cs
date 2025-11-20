using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int decision = 0;

        while(decision != 4)
        {
            menu.PrintMenu();
            decision = menu.ProcessMenu();
            Console.Clear();
        }

        Console.WriteLine(decision);
    }
}