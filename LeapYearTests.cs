using FluentAssertions;

namespace LeapYear;

public class LeapYearTests
{
    /// <summary>
    /// We need to be able to decide if a year is a leap year.
    /// The rules for when it's a leap year is:
    /// Occurs when the year is evenly divisible by 4
    /// If the year can also be evenly dividable by 100, it's not a leap year
    /// The year is also evenly divisible by 400. Then it's a leap year.
    /// </summary>

    private readonly Calculator _calculator;
    
    public LeapYearTests()
    {
        _calculator = new Calculator();
    }
    
    [Fact]
    public void IsYearDivisibleBy4()
    {
        _calculator.IsLeapYear(2020)
            .Should()
            .Be(true);
    }
}