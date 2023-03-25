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
    
    [Theory]
    [InlineData(2020, true)]
    [InlineData(2021, false)]
    public void IsYearDivisibleBy4(int year, bool expectedResult)
    {
        _calculator.IsLeapYear(year)
            .Should()
            .Be(expectedResult);
    }

    [Theory]
    [InlineData(1800, false)]
    [InlineData(1900, false)]
    [InlineData(2100, false)]
    [InlineData(2200, false)]
    [InlineData(2300, false)]
    [InlineData(2500, false)]
    public void IsYearDivisibleBy100(int year, bool expectedResult)
    {
        _calculator.IsLeapYear(year)
            .Should()
            .Be(expectedResult);
    }
    
}