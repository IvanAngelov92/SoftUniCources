using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> oneElement = new() { 10 };

        // Act
        List<int> result = GaussTrick.SumPairs(oneElement);

        // Assert
        CollectionAssert.AreEqual(oneElement, result);
    }

    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        //Test with up to 4 elements
        List<int> numbers = new() { 1,2,3,4};

        // Act
        List<int> result = GaussTrick.SumPairs(numbers);

        // Assert
        List<int> assertResult = new List<int>() { 5, 5 };
        CollectionAssert.AreEqual(result, assertResult);
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        List<int> numbers = new() { 1, 2, 3, 4, 5 };

        // Act
        List<int> result = GaussTrick.SumPairs(numbers);

        // Assert
        List<int> assertResult = new List<int>() { 6, 6, 3 };
        CollectionAssert.AreEqual(result, assertResult);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

        // Act
        List<int> result = GaussTrick.SumPairs(numbers);

        // Assert
        List<int> assertResult = new List<int>() { 11, 11, 11, 11, 11};
        CollectionAssert.AreEqual(result, assertResult);
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {
        List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7};

        // Act
        List<int> result = GaussTrick.SumPairs(numbers);

        // Assert
        List<int> assertResult = new List<int>() {8, 8, 8, 4};
        CollectionAssert.AreEqual(result, assertResult);
    }
}
