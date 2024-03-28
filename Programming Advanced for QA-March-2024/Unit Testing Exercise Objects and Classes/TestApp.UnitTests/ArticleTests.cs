using NUnit.Framework;

using System;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.UnitTests;

public class ArticleTests
{
    private Article _article;

    [SetUp]
    public void SetUp()
    {
        this._article = new Article();
    }
    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] articles = { "Article1 Content1 Author1", "Article2 Content2 Author2", "Article3 Content3 Author3" };

        // Act
        Article result = _article.AddArticles(articles);

        // Assert
        Assert.AreEqual(3, result.ArticleList.Count);
        Assert.AreEqual("Article1", result.ArticleList[0].Title);
        Assert.AreEqual("Content2", result.ArticleList[1].Content);
        Assert.AreEqual("Author3", result.ArticleList[2].Author);
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        /// Arrange
        string[] articles = { "B ContentB AuthorB", "A ContentA AuthorA", "C ContentC AuthorC" };
        Article article = _article.AddArticles(articles);

        // Act
        string result = _article.GetArticleList(article, "title");

        // Assert
        StringAssert.Contains("A - ContentA: AuthorA", result);
        StringAssert.Contains("B - ContentB: AuthorB", result);
        StringAssert.Contains("C - ContentC: AuthorC", result);
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        // Arrange
        string[] articles = { "Article1 Content1 Author1", "Article2 Content2 Author2", "Article3 Content3 Author3" };
        Article article = _article.AddArticles(articles);

        // Act
        string result = _article.GetArticleList(article, "invalidCriteria");

        // Assert
        Assert.AreEqual("", result);
    }
}
