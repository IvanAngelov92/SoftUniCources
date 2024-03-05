using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace TestApp.Tests;

public class WordEraserTests
{
    [Test]
    public void Test_Erase_EmptyWordsList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> words = new List<string>();
        string eraserWord = null;
        string expectedResult = string.Empty;

        WordEraser eraser = new WordEraser();

        // Act
        string actualResult = eraser.Erase(words, eraserWord);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);

    }

    [Test]
    public void Test_Erase_NullWordsList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> words = null;
        string wordToErase = "erase";

        WordEraser eraser = new WordEraser();

        // Act
        string result = eraser.Erase(words, wordToErase);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_Erase_NullOrEmptyWordToErase_ShouldReturnStringOfGivenWordsList()
    {
        // Arrange
        List<string> words = new List<string> { "erase", "this", "word" };
        string wordToErase = null;

        WordEraser eraser = new WordEraser();

        // Act
        string resultNull = eraser.Erase(words, wordToErase);

        // Assert
        Assert.AreEqual("erase this word", resultNull);
    }

    [Test]
    public void Test_Erase_ValidInput_ShouldReturnEmptyString_WhenAllWordsMatchedTheWordToErase()
    {
        // Arrange
        List<string> words = new List<string> { "erase", "erase", "erase" };
        string wordToErase = "erase";

        WordEraser eraser = new WordEraser();

        // Act
        string result = eraser.Erase(words, wordToErase);

        // Assert
        Assert.AreEqual(string.Empty, result);
    }

    [Test]
    public void Test_Erase_ValidInput_ShouldReturnStringWithoutErasedWords_WhenFewOfWordsMatchedWordToArese()
    {
        // Arrange
        List<string> words = new List<string> { "erase", "keep", "erase", "remove", "erase" };
        string wordToErase = "erase";

        WordEraser eraser = new WordEraser();

        // Act
        string result = eraser.Erase(words, wordToErase);

        // Assert
        Assert.AreEqual("keep remove", result);
    }
}

