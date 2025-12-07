class Portfolio
{
    private List<Investment> _investments = new List<Investment>();
    private double _cash;

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
    }

    public void AddInvestment(Investment investment)
    {
        _investments.Add(investment);
    }

    public void RemoveInvestment(Investment investment)
    {
        _investments.Remove(investment);
    }   
}