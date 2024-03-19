using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] nums = new int[0];

        // Act
        string actualOutput = CountRealNumbers.Count(nums);

        // Assert
        Assert.AreEqual(string.Empty, actualOutput);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] nums = new int[] { 5 };
        string expectedOutput = "5 -> 1";

        // Act
        string actualOutput = CountRealNumbers.Count(nums);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] nums = new int[] { 1, 2, 2, 3, 3, 3 };
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("1 -> 1");
        sb.AppendLine("2 -> 2");
        sb.AppendLine("3 -> 3");

        string expectedResult = sb.ToString().TrimEnd();

        // Act
        string result = CountRealNumbers.Count(nums);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] nums = new int[] { -1, -2, -2, -3, -3, -3 };
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("-3 -> 3");
        sb.AppendLine("-2 -> 2");
        sb.AppendLine("-1 -> 1");

        string expectedResult = sb.ToString().TrimEnd();

        // Act
        string result = CountRealNumbers.Count(nums);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] nums = new int[] { 0, 1, 1, 3, 3, 3 };
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("0 -> 1");
        sb.AppendLine("1 -> 2");
        sb.AppendLine("3 -> 3");

        string expectedResult = sb.ToString().TrimEnd();

        // Act
        string result = CountRealNumbers.Count(nums);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
