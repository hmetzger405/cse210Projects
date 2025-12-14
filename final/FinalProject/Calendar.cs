class Calendar
{
    private int _timeWeeks = 1;
    private string [] _months = {"January", "February", "March", "April", "May", "June"
    , "July", "August", "September", "October", "November", "December"};

    public Calendar(int weeks)
    {
        _timeWeeks = weeks;
    }
    public void DisplayDate()
    {
        int years;
        int months;
        int weeks;
        years = 1 + (_timeWeeks - 1) / 48;
        months = 1 + ((_timeWeeks - 1) / 4 % 12);
        weeks = 1 + (_timeWeeks -1) % 4;

        Console.WriteLine($"Year {years}, Week {weeks} of {_months[months - 1]}");
    }

    public void MoveForward(int weeks)
    {
        _timeWeeks += weeks;
    }

}