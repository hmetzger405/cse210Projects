class Option : Investment
{
    private DateTime _expirationDate;
    private string _sector;
    public Option(double value, string sector, DateTime expirationDate) : base(value)
    {
        _expirationDate = expirationDate;
        _sector = sector;
    }

    public override void UpdateValue()
    {
    }
}