using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        // Arrange
        char[] input = "a1b2c3d4".ToCharArray();
        char[] expectedOutput = "abcd".ToCharArray();

        // Act
        char[] actualOutput = Fake.RemoveStringNumbers(input);

        // Assert
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        // Arrange
        char[] input = "abcdef".ToCharArray();

        // Act
        char[] result = Fake.RemoveStringNumbers(input);

        // Assert
        Assert.AreEqual(input, result);
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        char[] input = new char[0];

        // Act
        char[] result = Fake.RemoveStringNumbers(input);

        // Assert
        Assert.IsEmpty(result);
    }
}
