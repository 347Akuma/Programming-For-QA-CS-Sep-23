using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class AdjacentEqualTests
{
    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => AdjacentEqual.Sum(nullList));
    }

    // TODO: finish test
    [Test]
    public void Test_Sum_InputIsEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        string result = AdjacentEqual.Sum(emptyList);

        // Assert
        Assert.That(result, Is.EqualTo(""));
    }

    // TODO: finish test
    [Test]
    public void Test_Sum_NoAdjacentEqualNumbers_ShouldReturnOriginalList()
    {
        // Arrange
        List<int> integers = new List<int> { 1, 2, 3, 4, 5 };

        // Act
        string result = AdjacentEqual.Sum(integers);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 5"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersExist_ShouldReturnSummedList()
    {
        // Arrange
        List<int> integers = new List<int> { 1, 2, 2, 3, 3, 4, 5 };

        // Act
        string result = AdjacentEqual.Sum(integers);

        // Assert
        Assert.That(result, Is.EqualTo("1 4 6 4 5"));
    }

    [Test]
    public void Test_Sum_AllNumbersAreAdjacentEqual_ShouldReturnSingleSummedNumber()
    {
        // Arrange
        List<int> integers = new List<int> { 2, 2, 4, 8 };

        // Act
        string result = AdjacentEqual.Sum(integers);

        // Assert
        Assert.That(result, Is.EqualTo("16"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtBeginning_ShouldReturnSummedList()
    {
        // Arrange
        List<int> integers = new List<int> { 1, 1, 2, 2, 3, 4, 5, 6, 7, 8 };

        // Act
        string result = AdjacentEqual.Sum(integers);

        // Assert
        Assert.That(result, Is.EqualTo("4 2 3 4 5 6 7 8"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersAtEnd_ShouldReturnSummedList()
    {
        // Arrange
        List<int> integers = new List<int> { 1, 2, 3, 4, 8, 9, 10, 10 };

        // Act
        string result = AdjacentEqual.Sum(integers);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 4 8 9 20"));
    }

    [Test]
    public void Test_Sum_AdjacentEqualNumbersInMiddle_ShouldReturnSummedList()
    {
        // Arrange
        List<int> integers = new List<int> { 1, 2, 3, 4, 4, 4, 8, 9, 10 };

        // Act
        string result = AdjacentEqual.Sum(integers);

        // Assert
        Assert.That(result, Is.EqualTo("1 2 3 8 4 8 9 10"));
    }
}
