using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatchUrlsTests
{
    [Test]
    public void Test_ExtractUrls_EmptyText_ReturnsEmptyList()
    {
        // Arrange
        string text = "";

        // Act
        List<string> actualUrls = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.IsEmpty(actualUrls);
    }

    [Test]
    public void Test_ExtractUrls_NoUrlsInText_ReturnsEmptyList()
    {
        // Arrange
        string text = "This text does not contain any URLs.";

        // Act
        List<string> actualUrls = MatchUrls.ExtractUrls(text);

        // Assert
        Assert.IsEmpty(actualUrls);
    }

    [Test]
    public void Test_ExtractUrls_SingleUrlInText_ReturnsSingleUrl()
    {
        // Arrange
        string text = "Here is a single URL: https://www.example.com";
        List<string> expectedUrls = new List<string> { "https://www.example.com" };

        // Act
        List<string> actualUrls = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(expectedUrls, actualUrls);
    }

    [Test]
    public void Test_ExtractUrls_MultipleUrlsInText_ReturnsAllUrls()
    {
        // Arrange
        string text = "Here are multiple URLs: https://www.example.com, http://another-example.com/path/page.html, and https://example.org";
        List<string> expectedUrls = new List<string> {"https://www.example.com", "http://another-example.com", "https://example.org" };

        // Act
        List<string> actualUrls = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(expectedUrls, actualUrls);
    }

    [Test]
    public void Test_ExtractUrls_UrlsInQuotationMarks_ReturnsUrlsInQuotationMarks()
    {
        // Arrange
        string text = "Here are some URLs in quotation marks: \"https://www.example.com\", \"http://another-example.com/path/page.html\"";
        List<string> expectedUrls = new List<string> { "https://www.example.com", "http://another-example.com" };

        // Act
        List<string> actualUrls = MatchUrls.ExtractUrls(text);

        // Assert
        CollectionAssert.AreEqual(expectedUrls, actualUrls);
    }
}
