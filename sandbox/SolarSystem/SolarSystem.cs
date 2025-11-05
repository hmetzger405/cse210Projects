class SolarSystem
{
    public List<Planet> _solarSystem = new List<Planet>();

    public void DisplaySolarSystem()
    {
        foreach (Planet planet in _solarSystem)
        {
            planet.DisplayPlanetInformation();
        } 
    }

}
