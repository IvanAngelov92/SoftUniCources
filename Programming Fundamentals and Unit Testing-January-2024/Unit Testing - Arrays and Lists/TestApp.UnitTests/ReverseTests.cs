using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverseTests
{
    [Test]
    public void Test_ReverseArray_InputIsEmpty_ShouldReturnEmptyString()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        string result = Reverse.ReverseArray(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        // Arrange
        int[] arr = new int[1] { 3 };

        // Act
        string result = Reverse.ReverseArray(arr);

        // Assert
        Assert.That(result, Is.EqualTo("3"));
    }

    [Test]
    public void Test_ReverseArray_InputHasMultipleElements_ShouldReturnReversedString()
    {
        // Arrange
        int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Act
        string result = Reverse.ReverseArray(arr);

        // Assert
        Assert.That(result, Is.EqualTo("10 9 8 7 6 5 4 3 2 1"));
    }
}
