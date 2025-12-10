class Portfolio
{
    private List<Investment> _investments = new List<Investment>();
    private double _cash;

    public Portfolio(double cash)
    {
        _cash = cash;
    }

    public double GetCash()
    {
        return _cash;
    }
    public void SetCash(double cash)
    {
        _cash = cash;
    }

    public void DisplayReturns()
    {
    }

    public void DisplayInvestments()
    {
        int i = 0;
        foreach(Investment investment in _investments)
        {
            i++;
            Console.Write($"{i}. ");
            investment.DisplayInvestment();
        }
    }

    public void AddInvestment(Investment investment)
    {
        _investments.Add(investment);
    }

    public void RemoveInvestment(Investment investment)
    {
        _investments.Remove(investment);
    }   

    public void SellAsset()
    {
        Console.WriteLine("Which investment would you like to sell? ");
        DisplayInvestments();
        Console.Write(" > ");
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
            if(success && (response < 1 || response > _investments.Count()))
            {
                Console.Write("Please Choose the Number of an Investment");
                success = false;
            }
        }
        _cash += _investments[response - 1].SellAsset();


    }

    public void CreateBond()
    {
        Console.WriteLine("How much would you like to put into this bond? ");
        double value = -1;
        bool success = false;
        while(!success)
        {
            try
            {
                value = double.Parse(Console.ReadLine());
                success = true;
            }
            catch
            {
                Console.WriteLine("Please Input an Integer Value");
            }
            if (value > _cash)
            {
                success = false;
                Console.WriteLine("You Don't Have Enough Money! Please Try Again");
            }
        }
        Bond myBond = new Bond(value);
        _cash -= value;
        _investments.Add(myBond);
    }

    public void CreateIndexFund(string sector)
    {
        Console.WriteLine("How much would you like to put into this Index Fund? ");
        double value = -1;
        bool success = false;
        while(!success)
        {
            try
            {
                value = double.Parse(Console.ReadLine());
                success = true;
            }
            catch
            {
                Console.WriteLine("Please Input an Integer Value");
            }
            if (value > _cash)
            {
                success = false;
                Console.WriteLine("You Don't Have Enough Money! Please Try Again");
            }
        }
        IndexFund myIndexFund = new IndexFund(value, sector);
        _cash -= value;
        _investments.Add(myIndexFund);
    }

    public void CreateOption(string sector)
    {
        Console.WriteLine("How much would you like to put into this Option? ");
        double value = -1;
        bool success = false;
        while(!success)
        {
            try
            {
                value = double.Parse(Console.ReadLine());
                success = true;
            }
            catch
            {
                Console.WriteLine("Please Input an Integer Value");
            }
            if (value > _cash)
            {
                success = false;
                Console.WriteLine("You Don't Have Enough Money! Please Try Again");
            }
        }
        Option myOption = new Option(value, sector, DateTime.Now);
        _cash -= value;
        _investments.Add(myOption);
    }
}