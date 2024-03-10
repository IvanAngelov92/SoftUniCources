using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class MatchDatesTests
{
    [Test]
    public void Test_Match_ValidDate_ReturnsExpectedResult()
    {
        // Arrange
        string dates = "The event is scheduled for 25-December-2024.";

        // Act
        string result = MatchDates.Match(dates);

        // Assert
        Assert.AreEqual("Day: 25, Month: December, Year: 2024", result);
    }

    [Test]
    public void Test_Match_NoMatch_ReturnsEmptyString()
    {
        // Arrange
        string dates = "No dates in this string.";

        // Act
        string result = MatchDates.Match(dates);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_Match_MultipleMatches_ReturnsFirstMatch()
    {
        // Arrange
        string dates = "This sentence contains multiple dates like 10-March-2024 and 20-April-2024.";

        // Act
        string result = MatchDates.Match(dates);

        // Assert
        Assert.AreEqual("Day: 10, Month: March, Year: 2024", result);
    }

    [Test]
    public void Test_Match_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string dates = "";

        // Act
        string result = MatchDates.Match(dates);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_Match_NullInput_ThrowsArgumentException()
    {
        // Arrange
        string dates = null;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => MatchDates.Match(dates));
    }
}
