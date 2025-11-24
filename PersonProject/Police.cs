class Police : Person
{
    private string _weapons;
    public Police(string weapons, string firstNamename, string lastName, int age, int weight) 
    : base(firstNamename, lastName, age, weight)
    {
        _weapons = weapons;
    }

    public string GetPoliceInformation()
    {
        return $"{base.GetPersonInformation()}, Weapons: {_weapons}";
    } 
    public override string GetPersonInformation()
    {
        return $"{base.GetPersonInformation()}, Weapons: {_weapons}";
    }
}