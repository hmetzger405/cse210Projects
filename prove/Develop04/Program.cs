using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        BaseActivity baseActivity= new BaseActivity("Welcome!", "This is a test", "Good Job", ["How do you feel today", "Think of a time you stood up for someone"]);
        int decision = 0;

        while(decision != 4)
        {
            Console.Clear();
            menu.PrintMenu();
            decision = menu.ProcessMenu();

        switch (decision)
        {
            case 1:
                baseActivity.StartActivity();
                baseActivity.EndActivity();
                break;
            case 2:
                baseActivity.DisplayPrompt(baseActivity._prompts);
                break;
        }

        }

        Console.WriteLine(decision);


    }
}