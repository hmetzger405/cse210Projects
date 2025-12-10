class Menu
{
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
        while(response < 1 || response > 5)
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine(" 1. View Investments");
            Console.WriteLine(" 2. Make New Investment");
            Console.WriteLine(" 3. Sell Investment");
            Console.WriteLine(" 4. Move Forward");
            Console.WriteLine(" 5. Quit");
            Console.Write(" > ");
            response = ProcessInt();
            if (response < 1 || response > 5)
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