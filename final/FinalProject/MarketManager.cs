class MarketManager
{
    Random rng = new Random();
    private double _generalReturn;
    private double _techReturn;
    private double _realEstateReturn;
    private List<string> _marketEvents = new List<string>();
    private string _currentEvent = "";

    private bool EventHappened()
    {
        int rand = rng.Next(1, 100);
        if (rand == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void SetEvent()
    {
        _currentEvent = _marketEvents[rng.Next(_marketEvents.Count)];
    }

    public void SetReturns()
    {
        double gMean = .002;
        double tMean = .004;
        double reifMean = .0018;
        double gDev = .0005;
        double tDev = .0001;
        double reifDev = 0.0008;
        _generalReturn = gMean + (gDev * Math.Sqrt(-2*Math.Log(1-rng.NextDouble())) * Math.Cos(2*Math.PI*(1-rng.NextDouble())));
        _techReturn = tMean + (tDev * Math.Sqrt(-2*Math.Log(1-rng.NextDouble())) * Math.Cos(2*Math.PI*(1-rng.NextDouble())));
        _realEstateReturn = reifMean + (reifDev * Math.Sqrt(-2*Math.Log(1-rng.NextDouble())) * Math.Cos(2*Math.PI*(1-rng.NextDouble())));

        if (rng.Next(3) == 1)
        {
            _generalReturn = _generalReturn * -0.5;
        }

        if (rng.Next(3) == 1)
        {
            _techReturn = _techReturn * -0.5;
        }

        if (rng.Next(3) == 1)
        {
            _realEstateReturn = _realEstateReturn * -0.5;
        }
    }

    public double GetGeneralReturn()
    {
        return _generalReturn;
    }

    public double GetTechReturn()
    {
        return _techReturn;
    }

    public double GetRealEstateReturn()
    {
        return _realEstateReturn;
    }

    public string GetCurrentEvent()
    {
        return _currentEvent;
    }
}