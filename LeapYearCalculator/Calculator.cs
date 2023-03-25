namespace LeapYear;

public class Calculator
{
    public object IsLeapYear(int year)
    {
        var divisibleBy4 = year % 4 == 0;
        var divisibleBy100 = year % 100 == 0;
        var divisibleBy400 = year % 400 == 0;

        if (!divisibleBy4) return false;
        return !divisibleBy100 || divisibleBy400;
    }
}