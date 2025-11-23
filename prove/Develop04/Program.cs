using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        BreathingActivity breathingActivity = new BreathingActivity("Welcome to the Breathing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Well Done!");
        ReflectionActivity reflectionActivity= new ReflectionActivity("Welcome to the Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Well Done!");
        int decision = 0;

        while(decision != 4)
        {
            Console.Clear();
            menu.PrintMenu();
            decision = menu.ProcessMenu();

        switch (decision)
        {
            case 1:
                breathingActivity.DoBreathingActivity();
                break;
            case 2:
                reflectionActivity.DoReflectionActivity();
                break;
            case 3:
                break;
        }


        }

        Console.WriteLine(decision);


    }
}