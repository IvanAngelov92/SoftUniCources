using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = { };
        string text = "This is a test text.";

        // Act
        string result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.AreEqual(text, result);
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] bannedWords = { "test" };
        string text = "This is a test text.";

        // Act
        string result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.AreEqual("This is a **** text.", result);
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = { };
        string text = "This is a test text.";

        // Act
        string result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.AreEqual(text, result);
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] bannedWords = { "test", "word" };
        string text = "This is a test word.";

        // Act
        string result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.AreEqual("This is a **** ****.", result);
    }
}
