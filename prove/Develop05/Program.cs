using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        int response = 0;
        while(response != 6)
        {
            response = menu.DisplayMenu();
        }

    }
}