using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class SongTests
{
    private Song _song;

    [SetUp]
    public void Setup()
    {
        this._song = new();
    }

    [Test]
    public void Test_AddAndListSongs_ReturnsAllSongs_WhenWantedListIsAll()
    {
        // Arrange
        string[] songs = { "Pop_Song1_3:30", "Rock_Song2_4:15", "Pop_Song3_3:00" };
        string expected = $"Song1{Environment.NewLine}Song2{Environment.NewLine}Song3";

        // Act
        string result = _song.AddAndListSongs(songs, "all");

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndListSongs_ReturnsFilteredSongs_WhenWantedListIsSpecific()
    {
        // Arrange
        string[] songs = { "Pop_Song1_3:30", "Rock_Song2_4:15", "Pop_Song3_3:00" };
        string expected = $"Song1{Environment.NewLine}Song3";

        // Act
        string result = _song.AddAndListSongs(songs, "Pop");

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndListSongs_ReturnsEmptyString_WhenNoSongsMatchWantedList()
    {
        // Arrange
        var song = new Song();
        string[] songs = {
            "Rock_Stairway to Heaven_8:03",
            "Pop_Shape of You_3:54",
            "Rock_Bohemian Rhapsody_5:55",
            "Jazz_Take Five_5:24"
        };
        string wantedList = "Country"; // No songs in the list are of type "Country"

        // Act
        string result = song.AddAndListSongs(songs, wantedList);

        // Assert
        Assert.That(result, Is.Empty);
    }
}
