using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.Tests;

public class GroupingTests
{
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> nums = new List<int>();

        // Act
        string result = Grouping.GroupNumbers(nums);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> nums = new List<int> { 1, 2, 3, 4, 5 };

        // Arrange the expected result using StringBuilder
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Odd numbers: 1, 3, 5");
        sb.AppendLine("Even numbers: 2, 4");
        string expectedResult = sb.ToString().TrimEnd();

        // Act
        string result = Grouping.GroupNumbers(nums);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> nums = new List<int> { 2, 4, 6, 8, 10 };

        // Arrange the expected result using StringBuilder
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Even numbers: 2, 4, 6, 8, 10");
        string expectedResult = sb.ToString().TrimEnd();

        // Act
        string result = Grouping.GroupNumbers(nums);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> nums = new List<int> { 1, 3, 5, 7, 9 };

        // Arrange the expected result using StringBuilder
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Odd numbers: 1, 3, 5, 7, 9");
        string expectedResult = sb.ToString().TrimEnd();

        // Act
        string result = Grouping.GroupNumbers(nums);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> nums = new List<int> { -1, -2, -3, -4, -5 };

        // Arrange the expected result using StringBuilder
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Odd numbers: -1, -3, -5");
        sb.AppendLine("Even numbers: -2, -4");
        string expectedResult = sb.ToString().TrimEnd();

        // Act
        string result = Grouping.GroupNumbers(nums);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}