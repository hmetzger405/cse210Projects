class Bond : Investment
{
    private double _rate = 0.3;
    public Bond(double value) : base(value){}
    public override void UpdateValue()
    {
        double value = GetCurrentValue();
        double newValue = (value * (1+_rate));
        SetCurrentValue(newValue);
    }


}