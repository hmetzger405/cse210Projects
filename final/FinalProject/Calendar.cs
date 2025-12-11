class Calendar
{
    private int _timeWeeks;
    private string [] _months = {"January", "February", "March", "April", "May", "June"
    , "July", "August", "September", "October", "November", "December"};

    public Calendar(int timeWeeks)
    {
        _timeWeeks = timeWeeks;
    }

    public void DisplayDate()
    {
        int years = 1 + _timeWeeks / 48;
        int months;
        int weeks;
        if (((_timeWeeks % 48) % 4) == 0)
        {
            months = ((_timeWeeks % 48) / 4) - 1;
            weeks = 4;
            
        }
        else
        {
            months = ((_timeWeeks % 48) / 4);
            weeks = (_timeWeeks % 48) % 4;
        }

        Console.WriteLine($"Year {years}, Week {weeks} of {_months[months]}");
    }

}