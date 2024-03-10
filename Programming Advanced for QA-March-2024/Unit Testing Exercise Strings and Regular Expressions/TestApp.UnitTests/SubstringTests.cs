using NUnit.Framework;

namespace TestApp.UnitTests;

public class SubstringTests
{
    // TODO: finish the test
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        string toRemove = "fox";
        string input = "The quick brown fox jumps over the lazy dog";


        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        string expected = "The quick brown jumps over the lazy dog";
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        // Arrange
        string toRemove = "Hello";
        string input = "Hello, my name is Ivan";


        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        string expected = ", my name is Ivan";
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        // Arrange
        string toRemove = "Mercedes";
        string input = "The best car in the world is Mercedes";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        string expected = "The best car in the world is";
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        // Arrange
        string toRemove = "Golf";
        string input = "First Golf was made in 1976, and the latest version of Golf 8 is from 2024";


        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        string expected = "First was made in 1976, and the latest version of 8 is from 2024";
        Assert.AreEqual(expected, result);
    }
}
