class Bond : Investment
{
    private double _rate = .000625;
    public Bond(double value) : base(value, "Bond"){}
    public override void UpdateValue(double gRate, double tRate, double reifRate)
    {
        double value = GetCurrentValue();
        double newValue = (value * (1+_rate));
        SetCurrentValue(newValue);
    }
}