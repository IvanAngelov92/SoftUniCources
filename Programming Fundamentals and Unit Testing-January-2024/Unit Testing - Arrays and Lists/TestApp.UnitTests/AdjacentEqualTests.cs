using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyString = new List<int>();

        // Act
        string result = AdjacentEqual.Sum(emptyString);

        //Assert
        Assert.AreEqual("", result);

    }

    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> numbers = new List<int> { 1, 2, 3, 4 };

        // Act
        string result = AdjacentEqual.Sum(numbers);

        // Assert
        Assert.AreEqual("1 2 3 4", result);
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        //Arrange
        List<int> numbers = new List<int> { 1, 1, 2, 3, 3, 3, 4 };

        //Act
        string result = AdjacentEqual.Sum(numbers);

        //Assert
        Assert.AreEqual("2 2 9 4", result);
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        //Arrange
        List<int> numbers = new List<int> { 2, 2, 2, 2, 2 };

        //Act
        string result = AdjacentEqual.Sum(numbers);

        //Assert
        Assert.AreEqual("10", result);
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        //Arrange
        List<int> numbers = new List<int> { 1, 1, 2, 3, 4 };

        //Act
        string result = AdjacentEqual.Sum(numbers);

        //Assert
        Assert.AreEqual("2 2 3 4", result);
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        //Arrange
        List<int> numbers = new List<int> { 1, 2, 3, 4, 4 };

        //Act
        string result = AdjacentEqual.Sum(numbers);

        //Assert
        Assert.AreEqual("1 2 3 8", result);
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        //Arrange
        List<int> numbers = new List<int> { 1, 2, 2, 3, 4 };

        //Act
        string result = AdjacentEqual.Sum(numbers);

        //Assert
        Assert.AreEqual("1 4 3 4", result);
    }
}
