abstract class Investment
{
    private double _initialValue;
    private double _currentValue;

    public Investment(double value)
    {
        _initialValue = value;
        _currentValue = value;
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

    public abstract void UpdateValue();
}