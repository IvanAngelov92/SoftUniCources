using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string emptyString = string.Empty;

        // Act
        string empty = StringReverse.Reverse(emptyString);

        // Assert
        Assert.AreEqual("", empty);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string emptyString = "A";

        // Act
        string result = StringReverse.Reverse(emptyString);

        // Assert
        Assert.AreEqual("A", result);
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string emptyString = "ABC";

        // Act
        string result = StringReverse.Reverse(emptyString);

        // Assert
        Assert.AreEqual("CBA", result);
    }
}
