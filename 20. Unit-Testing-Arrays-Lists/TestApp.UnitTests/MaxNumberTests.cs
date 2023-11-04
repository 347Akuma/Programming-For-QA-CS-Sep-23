using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(nullList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> emptyList = new();

        // Act & Assert
        Assert.That(() => MaxNumber.FindMax(emptyList), Throws.ArgumentException);
    }

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        //Arrange
        List<int> singleElementList = new List<int> { 1 };

        //Act
        int result = MaxNumber.FindMax(singleElementList);

        //Assert
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        //Arrange
        List<int> singleElementList = new List<int> { 1, 2, 3, 4, 5, 6 };

        //Act
        int result = MaxNumber.FindMax(singleElementList);

        //Assert
        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        //Arrange
        List<int> singleElementList = new List<int> { -1, -2, -3, -4, -5, -6 };

        //Act
        int result = MaxNumber.FindMax(singleElementList);

        //Assert
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        //Arrange
        List<int> singleElementList = new List<int> { -1, 2, -3, 4, -5, -6 };

        //Act
        int result = MaxNumber.FindMax(singleElementList);

        //Assert
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        //Arrange
        List<int> singleElementList = new List<int> { 1, 2, 3, 4, 5, 5, 5 };

        //Act
        int result = MaxNumber.FindMax(singleElementList);

        //Assert
        Assert.That(result, Is.EqualTo(5));
    }
}
