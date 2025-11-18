class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    private int _weight;

    public Person(string firstName, string lastName, int age, int weight)
    {
        _firstName = firstName;
        _lastName = lastName;
        setAge(age);
        setWeight(weight);
    }

    public string GetPersonInformation()
    {
        return $"{_firstName} {_lastName} - Age: {_age}, Weight {_weight}";
    }

    public void setAge(int age)
    {
        if (age > 0)
        {
            _age = age;;
        }
        else
        {
            _age = 0;
        }
    }

    public void setWeight(int weight)
    {
        if (weight > 0)
        {
            _weight = weight;
        }
        else
        {
            _weight = 100;
        }
    }

}