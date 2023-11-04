using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverserTests
{
    [Test]
    public void Test_ReverseStrings_WithEmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        string[] inputArray = Array.Empty<string>();

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_ReverseStrings_WithSingleString_ReturnsReversedString()
    {
        // Arrange
        string[] inputArr = { "Hello" };

        // Act
        string[] result = Reverser.ReverseStrings(inputArr);

        // Assert
        Assert.That(result, Is.EqualTo(new[] { "olleH" }));
    }

    [Test]
    public void Test_ReverseStrings_WithMultipleStrings_ReturnsReversedStrings()
    {
        // Arrange
        string[] inputArr = { "Hello", "My Name", "Is Alex" };

        // Act
        string[] result = Reverser.ReverseStrings(inputArr);

        // Assert
        Assert.That(result, Is.EqualTo(new[] { "olleH", "emaN yM", "xelA sI" }));
    }

    [Test]
    public void Test_ReverseStrings_WithSpecialCharacters_ReturnsReversedSpecialCharacters()
    {
        // Arrange
        string[] inputArr = { "Hello!", "Who's There?" };

        // Act
        string[] result = Reverser.ReverseStrings(inputArr);

        // Assert
        Assert.That(result, Is.EqualTo(new[] { "!olleH", "?erehT s'ohW" }));
    }
}
