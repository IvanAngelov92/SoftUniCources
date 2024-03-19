using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new List<string>();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new List<string> { "" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string> { "y" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("y -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string> { "ivan", "angelov" };

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("i -> 1");
        sb.AppendLine("v -> 2");
        sb.AppendLine("a -> 2");
        sb.AppendLine("n -> 2");
        sb.AppendLine("g -> 1");
        sb.AppendLine("e -> 1");
        sb.AppendLine("l -> 1");
        sb.AppendLine("o -> 1");


        string expectedOutput = sb.ToString().TrimEnd();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedOutput));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new List<string> { "a", "bc", "bca", "", "\"" };

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("a -> 2");
        sb.AppendLine("b -> 2");
        sb.AppendLine("c -> 2");
        sb.AppendLine("\" -> 1");

        string expectedOutput = sb.ToString().TrimEnd();


        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedOutput));
    }
}
