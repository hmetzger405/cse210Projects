class Option : Investment
{
    private int _weeksTillExpiration;
    private string _sector;
    public Option(double value, string sector, int expirationDate) : base(value, "Option")
    {
        _weeksTillExpiration = expirationDate;
        _sector = sector;
    }

    public int GetWeeksTillExpiration()
    {
        return _weeksTillExpiration;
    }

    public override void DisplayInvestment()
    {
        double returnRate = GetReturnRate();
        if (returnRate >= 0)
        {
            Console.WriteLine($"{_sector} {GetName()}: {GetCurrentValue():C2} - +%{returnRate:F2} -> Expires in {_weeksTillExpiration} weeks");
        }
        else
        {
            Console.WriteLine($"{_sector} {GetName()}: {GetCurrentValue():C2} - %{returnRate:F2} -> Expires in {_weeksTillExpiration} weeks");
        }
    }

    public override void UpdateValue(double gRate, double tRate, double reifRate)
    {
        double leverage = 3 * (1 + 10/_weeksTillExpiration);
        if(_sector == "General")
        {
            double value = GetCurrentValue();
            double newValue = value * (1+(leverage* gRate));
            SetCurrentValue(newValue);
        }
        if(_sector == "Technology")
        {
            double value = GetCurrentValue();
            double newValue = value * (1+(leverage * tRate));
            SetCurrentValue(newValue);
        }
        if(_sector == "Real Estate")
        {
            double value = GetCurrentValue();
            double newValue = value * (1+(leverage * reifRate));
            SetCurrentValue(newValue);
        }
        _weeksTillExpiration--;       
    }
}