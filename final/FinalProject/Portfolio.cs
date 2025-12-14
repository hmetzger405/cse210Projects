using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

class Portfolio
{
    private List<Investment> _investments = new List<Investment>();
    private double _cash;
    MarketManager _manager = new MarketManager();

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

    public void DisplayCash()
    {
        Console.WriteLine($"Cash: {_cash:C2}");
    }

    public void GetPortfolioValue()
    {
        double total = 0;
        foreach (Investment investment in _investments)
        {
            total += investment.GetCurrentValue();
        }
        Console.WriteLine($"Portfolio Value: {total:C2}");
    }

    public void DisplayInvestments(int context)
    {
        int i = 0;
        switch(context)
        {
            case 1:
            Console.Clear();
            foreach(Investment investment in _investments)
            {
                i++;
                Console.Write($"{i}. ");
                investment.DisplayInvestment();
            }
                Console.Write("(Press Enter to Continue)");
                Console.ReadLine();
                break;
            case 2:
            Console.Clear();
            Console.WriteLine("Which investment would you like to sell? ");
            foreach(Investment investment in _investments)
            {
                i++;
                
                Console.Write($"{i}. ");
                investment.DisplayInvestment();
            }
                break;
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
        if (_investments.Count() != 0)
        {
            DisplayInvestments(2);
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
            _investments.RemoveAt(response - 1);
        }
        else
        {
            Console.WriteLine("You Don't Own Any Investments!");
        }
    }

    public void UpdateValues(int weeks)
    {
        for (int i = 1; i <= weeks; i++)
        {
            _manager.SetReturns();
            foreach(Investment investment in _investments)
            {
                investment.UpdateValue(_manager.GetGeneralReturn(), _manager.GetTechReturn(), _manager.GetRealEstateReturn());
            }
        }
        for (int i = _investments.Count() - 1; i >= 0; i--)
        {
            Investment investment = _investments[i];
            if (investment is Option option && option.GetWeeksTillExpiration() <= 0)
            {
                _cash += option.GetCurrentValue();
                Console.WriteLine($"An option was sold at {option.GetCurrentValue():C2}");
                _investments.Remove(option);
            }
        }  
    }

    public void CreateBond()
    {
        Console.Write("How much, in dollars, would you like to put into this bond?\n $");
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
        Console.Write("How much, in dollars, would you like to put into this Index Fund?\n > $");
        double value = 1;
        bool success = false;
        while(!success ) 
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
                Console.WriteLine("You Don't Have Enough Money! Please Try Again \n > $");
            }
        }
        IndexFund myIndexFund = new IndexFund(value, sector);
        _cash -= value;
        _investments.Add(myIndexFund);
    }

    public void CreateOption(string sector)
    {
        Console.Write("How much, in dollars, would you like to put into this Option? \n > $");
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
                Console.WriteLine("You Don't Have Enough Money! Please Try Again \n > $");
            }
        }
        Console.WriteLine("How far out, in weeks, would you like the expiration date to be?");
        int exp = -1;
        bool success2 = false;
        while(!success2)
        {
            try
            {
                exp = int.Parse(Console.ReadLine());
                success2 = true;
            }
            catch
            {
                Console.WriteLine("Please Input an Integer Value");
            }
            if (exp < 1)
            {
                success = false;
                Console.WriteLine("In must expire in at least 1 week");
            }
        }
        Option myOption = new Option(value, sector, exp);
        _cash -= value;
        _investments.Add(myOption);
    }
}