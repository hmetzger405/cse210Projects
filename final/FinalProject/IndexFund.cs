class IndexFund : Investment
{
    private string _sector;
    public IndexFund(double value, string sector) : base(value)
    {
        _sector = sector;
    }

    public override void UpdateValue()
    {
    }
}