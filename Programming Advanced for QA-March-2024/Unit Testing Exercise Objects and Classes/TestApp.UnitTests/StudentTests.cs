using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class StudentTests
{
    private Student _student;

    [SetUp]
    public void SetUp()
    {
        this._student = new();
    }

    [Test]
    public void Test_AddAndGetByCity_ReturnsStudentsInCity_WhenCityExists()
    {
        // Arrange
        string[] students = { "John Doe 25 Sofia", "Jane Smith 22 Varna", "Alice Johnson 20 Sofia" };
        string expected = $"John Doe is 25 years old.{Environment.NewLine}Alice Johnson is 20 years old.";

        // Act
        string result = _student.AddAndGetByCity(students, "Sofia");

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetByCity_ReturnsEmptyString_WhenCityDoesNotExist()
    {
        // Arrange
        var student = new Student();
        string[] students = {
            "John Doe 20 New York",
            "Jane Smith 22 Los Angeles",
            "Michael Johnson 25 New York",
            "Emily Brown 21 New York"
        };
        string wantedTown = "Houston";

        // Act
        string result = student.AddAndGetByCity(students, wantedTown);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_AddAndGetByCity_ReturnsEmptyString_WhenNoStudentsGiven()
    {
        // Arrange
        var student = new Student();
        string[] students = { };

        // Act
        string result = student.AddAndGetByCity(students, "New York"); // City doesn't matter since there are no students

        // Assert
        Assert.That(result, Is.Empty);
    }
}
