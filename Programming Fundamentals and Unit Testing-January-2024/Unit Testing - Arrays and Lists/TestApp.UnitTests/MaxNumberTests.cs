using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> oneElement = new List<int> { 10 };

        // Act
        int result = MaxNumber.FindMax(oneElement);

        // Assert
        Assert.AreEqual(10, result);
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> positiveList = new List<int> { 3, 7, 2, 9, 5 };

        // Act
        int result = MaxNumber.FindMax(positiveList);

        // Assert
        Assert.AreEqual(9, result);
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> negativeList = new List<int> { -3, -7, -2, -9, -5 };

        // Act
        int result = MaxNumber.FindMax(negativeList);

        // Assert
        Assert.AreEqual(-2, result);
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> misedList = new List<int> { -3, 7, -2, 9, -5 };

        // Act
        int result = MaxNumber.FindMax(misedList);

        // Assert
        Assert.AreEqual(9, result);
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> duplicateList = new List<int> { 3, 7, 9, 9, 5 };

        // Act
        int result = MaxNumber.FindMax(duplicateList);

        // Assert
        Assert.AreEqual(9, result);
    }
}
