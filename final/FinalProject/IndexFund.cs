class IndexFund : Investment
{
    private string _sector;
    public IndexFund(double value, string sector) : base(value, "Index Fund")
    {
        _sector = sector;
    }

    public override void DisplayInvestment()
    {
        double returnRate = GetReturnRate();
        if (returnRate >= 0)
        {
            Console.WriteLine($"{_sector} {GetName()}: {GetCurrentValue():C2} - +%{returnRate:F2}");
        }
        else
        {
            Console.WriteLine($"{_sector}{GetName()}: {GetCurrentValue():C2} - %{returnRate:F2}");
        }
    }
    public override void UpdateValue(double gRate, double tRate, double reifRate)
    {
        if(_sector == "General")
        {
            double value = GetCurrentValue();
            double newValue = value * (1+gRate);
            SetCurrentValue(newValue);
        }
        if(_sector == "Technology")
        {
            double value = GetCurrentValue();
            double newValue = value * (1+tRate);
            SetCurrentValue(newValue);
        }
        if(_sector == "Real Estate")
        {
            double value = GetCurrentValue();
            double newValue = value * (1+reifRate);
            SetCurrentValue(newValue);
        }
    }
}