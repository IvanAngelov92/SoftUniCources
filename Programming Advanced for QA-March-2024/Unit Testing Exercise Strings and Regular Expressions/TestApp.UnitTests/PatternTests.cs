using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class PatternTests
{

    [Test]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult()
    {
        // Arrange
        string input = "abc";
        int repetitionFactor = 3;
        string expected = "aBcaBcaBc";

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        string input = "";
        int repetitionFactor = 3;

        // Act & Assert
        Assert.Throws<ArgumentException>(() =>
        {
            Pattern.GeneratePatternedString(input, repetitionFactor);
        });
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "abc";
        int repetitionFactor = -3;

        // Act & Assert
        Assert.Throws<ArgumentException>(() =>
        {
            Pattern.GeneratePatternedString(input, repetitionFactor);
        });
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "abc";
        int repetitionFactor = 0;

        // Act & Assert
        Assert.Throws<ArgumentException>(() =>
        {
            Pattern.GeneratePatternedString(input, repetitionFactor);
        });
    }
}
