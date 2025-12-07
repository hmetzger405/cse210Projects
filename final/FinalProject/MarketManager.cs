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
        _generalReturn = rng.NextDouble();
        _techReturn = rng.NextDouble();
        _realEstateReturn = rng.NextDouble();
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