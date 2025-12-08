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
            Console.WriteLine($"{_sector} {GetName()}: ${GetCurrentValue()} - +%{returnRate}");
        }
        else
        {
            Console.WriteLine($"{_sector}{GetName}: {GetCurrentValue()} - %{returnRate}");
        }
    }
    public override void UpdateValue()
    {
    }
}