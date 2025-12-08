class Menu
{
    public int DisplayGameMenu()
    {
        int response = 0;
        while(response < 1 || response > 3)
        {
            Console.WriteLine("Menu: ");
            Console.WriteLine(" 1. View Investments");
            Console.WriteLine(" 2. Make New Investment");
            Console.WriteLine(" 3. Sell Investment");
            Console.Write(" > ");
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
                    Console.WriteLine("Please Input an Integer Value");
                }
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
                    Console.WriteLine("Please Input an Integer Value");
                }
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
                    Console.WriteLine("Please Input an Integer Value");
                }
            }
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
}