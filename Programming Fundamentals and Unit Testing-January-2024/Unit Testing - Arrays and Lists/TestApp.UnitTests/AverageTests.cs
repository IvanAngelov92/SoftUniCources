using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class AverageTests
{
    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        // Arrange
        int[] array = { 42 };

        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.AreEqual(42, result);
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        //Arrange
        int[] array = { 1, 2, 3, 4, 5 };

        //Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.AreEqual(3, result);
    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        //Arrange
        int[] array = { -5, -4, -3, -2, -1 };

        //Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.AreEqual(-3, result);
    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        //Arrange
        int[] array = { -3, 5, 0, 2, -1 };

        //Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.AreEqual(0.6, result);
    }
}
