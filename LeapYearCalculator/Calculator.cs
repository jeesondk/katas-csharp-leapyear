namespace LeapYear;

public class Calculator
{
    public object IsLeapYear(int year)
    {
        return year % 4 == 0;
    }
}