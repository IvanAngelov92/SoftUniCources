using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    // TODO: finish the test
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] arr = new int[2] { 10,10 };

        // Act
        int result = EvenOddSubtraction.FindDifference(arr);

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] oddArr = new int[2] { 5, 3 };

        // Act
        int result = EvenOddSubtraction.FindDifference(oddArr);

        // Assert
        Assert.That(result, Is.EqualTo(-8));
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] arr = new int[4] { 1, 2, 3, 4, };

        // Act
        int result = EvenOddSubtraction.FindDifference(arr);

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }
}
