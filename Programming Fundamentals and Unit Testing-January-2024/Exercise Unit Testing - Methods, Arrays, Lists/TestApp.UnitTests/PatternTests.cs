using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        // Arrange
        int[] arr = { 5, 8, 2, 7, 1, 6, 4, 3 };
        int[] expectedResult = { 1, 8, 2, 7, 3, 6, 4, 5 };

        // Act
        int[] result = Pattern.SortInPattern(arr);

        // Assert
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] arr = new int[0];

        // Act
        int[] result = Pattern.SortInPattern(arr);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] arr = { 42 };

        // Act
        int[] result = Pattern.SortInPattern(arr);

        // Assert
        Assert.AreEqual(arr, result);
    }
}
