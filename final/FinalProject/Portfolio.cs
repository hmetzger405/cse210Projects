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
        foreach(Investment investment in _investments)
        {
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
        _investments.Add(myOption);
    }
}