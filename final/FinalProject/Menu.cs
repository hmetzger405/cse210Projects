class Menu
{

    public void DisplayIntro()
    {
        Console.Clear();
        Console.Write("Welcome to the Investing Simulator!\n(Press Enter to Continue) ");
        Console.ReadLine();
        Console.Write("The Goal of this game is to make as much money as possible! This is a gameified version of investing and is not meant to mimic the real world\n(Press Enter to Continue) ");
        Console.ReadLine();
        Console.Write("Here's a quick rundown of how it all works\n(Press Enter to Continue) ");
        Console.ReadLine();
        Console.Write("There are three types of investments: Index Funds, Options, and Bonds \n(Press Enter to Continue) ");
        Console.ReadLine();
        Console.Write("An Index Fund is the most standard investment. It's value is directly tied to it's sector. In this simulator, there are three sectors you can purchase funds for. They are the General Market, Technology, and Real Estate. \n(Press Enter to Continue) ");
        Console.ReadLine();
        Console.Write("The Technology sector is the most volitile, it has the highest return potential but can also lose more\n(Press Enter to Continue) ");
        Console.ReadLine();
        Console.Write("The Real Estate sector is the least volatile index, it has less return potential, but is also less risky.\n(Press Enter to Continue) ");
        Console.ReadLine();
        Console.Write("The General Market index is a middle ground between the two, less volatile than the Technology sector, but more volatile than the Real Estate sector\n(Press Enter to Continue) ");
        Console.ReadLine();
        Console.Write("For this simulator, options are leveraged positions with expiration dates. They are tied to the same sectors as the Index Funds, but the returns are amplified in either direction, be it positive or negative.\n(Press Enter to Continue) ");
        Console.ReadLine();
        Console.Write("As the expiration date gets closer, the levarage increases, making them more volatile. When it reaches the expiration date it is automatically sold.\n(Press Enter to Continue) ");
        Console.ReadLine();
        Console.Write("Bonds are the safest and simplist investment. In this simulator, they return a flat rate of roughly 3% APY\n(Press Enter to Continue) ");
        Console.ReadLine();
        Console.Write("You're all set to start now! Try to earn as much money as quickly as possible! \n(Press Enter to Continue) ");
        Console.ReadLine();


        
    }
    public int ProcessInt()
    {
        int response = 0;
        bool success = false;
        while(!success)
        {
            try
            {
                response = int.Parse(Console.ReadLine());
                success = true;
            }
            catch
            {
                Console.Write("Please Input an Integer Value\n > ");
            }
        }
        return response;
    }
    public int DisplayGameMenu()
    {
        int response = 0;
        while(response < 1 || response > 6)
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine(" 1. View Investments");
            Console.WriteLine(" 2. Make New Investment");
            Console.WriteLine(" 3. Sell Investment");
            Console.WriteLine(" 4. Move Forward");
            Console.WriteLine(" 5. See Intro and Rules");
            Console.WriteLine(" 6. Quit");
            Console.Write(" > ");
            response = ProcessInt();
            if (response < 1 || response > 6)
            {
                Console.WriteLine("Chose an input on the menu");
            }
        }
        return response;
    }
    public int DisplayInvestmentMenu()
    {
        int response = 0;
        while(response < 1 || response > 3)
        {
            Console.WriteLine("Choose an Investment: ");
            Console.WriteLine(" 1. Index Fund");
            Console.WriteLine(" 2. Option");
            Console.WriteLine(" 3. Bond");
            Console.Write(" > ");
            response = ProcessInt();
            if (response < 1 || response > 3)
            {
                Console.WriteLine("Chose an input on the menu");
            }
        }
        return response;
    }

    public string DisplaySectorMenu()
    {
        int response = 0;
        string sector = "";
        while(response > 3 || response < 1)
        {
            Console.Clear();
            Console.WriteLine("Which sector? ");
            Console.WriteLine(" 1. General Market");
            Console.WriteLine(" 2. Technology");
            Console.WriteLine(" 3. Real Estate");
            Console.Write(" > ");
            response = ProcessInt();
            if (response > 3 || response < 1)
            {
                Console.WriteLine("Please choose one of the options above");
            }
        }
        switch(response)
        {
            case 1:
                sector = "General";
                break;
            case 2:
                sector = "Tech";
                break;
            case 3: 
                sector = "RealEstate";
                break;
        }
        return sector;
    }

    public int DisplayTimeMenu()
    {
        int response = 0;
        while(response < 1 || response > 6)
        {
            Console.WriteLine("Chose the amount of Time to Simulate: ");
            Console.WriteLine(" 1. 1 Week");
            Console.WriteLine(" 2. 1 Month");
            Console.WriteLine(" 3. 3 Months");
            Console.WriteLine(" 4. 6 Months");
            Console.WriteLine(" 5. 1 Year");
            Console.WriteLine(" 6. 10 Years");
            Console.Write(" > ");
            response = ProcessInt();
            if (response < 1 || response > 6)
            {
                Console.WriteLine("Chose an input on the menu");
            }
        }
        return response;
        
    }
}