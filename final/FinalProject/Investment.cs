abstract class Investment
{
    private double _initialValue;
    private double _currentValue;
    private string _name;

    public Investment(double value, string name)
    {
        _initialValue = value;
        _currentValue = value;
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetIinitialValue(double value)
    {
        _initialValue = value;
    }

    public double GetInitialValue()
    {
        return _initialValue;
    }

    public void SetCurrentValue(double value)
    {
        _currentValue = value;
    }

    public double GetCurrentValue()
    {
        return _currentValue;
    }

    public double SellAsset()
    {
        return _currentValue;
    }

    public double GetReturnRate()
    {
        return ((_currentValue - _initialValue) / _initialValue) * 100;
    }

    public virtual void DisplayInvestment()
    {
        double returnRate = GetReturnRate();
        if (returnRate >= 0)
        {
            Console.WriteLine($"{_name}: {_currentValue:C2} - +%{returnRate:F2}");
        }
        else
        {
            Console.WriteLine($"{_name}: {_currentValue:C2} - %{returnRate:F2}");
        }

    }

    public abstract void UpdateValue(double gRate, double tRate, double reifRate);

}