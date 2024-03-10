using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] inputStrings = new string[0];

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(inputStrings);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        // Arrange
        string[] inputStrings = { "hello" };

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(inputStrings);

        // Assert
        Assert.AreEqual("hello", result);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] inputStrings = { "hello", "world", "!" };

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(inputStrings);

        // Assert
        Assert.AreEqual("!worldhello", result);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        // Arrange
        string[] inputStrings = null;

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(inputStrings);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        // Arrange
        string[] inputStrings = { "  ", "\t", "\n" };

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(inputStrings);

        // Assert
        Assert.AreEqual("\n\t  ", result);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] input = Enumerable.Range(1, 10000).Select(i => i.ToString()).ToArray();

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Arrange
        string expected = string.Join("", Enumerable.Range(1, 10000).Select(i => i.ToString()).Reverse());

        // Assert
        Assert.AreEqual(expected, result);
    }
}
