using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class ReverseTests
{
    [Test]
    public void Test_ReverseArray_InputIsEmpty_ShouldReturnEmptyString()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        string result = Reverse.ReverseArray(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseArray_InputHasOneElement_ShouldReturnTheSameElement()
    {
        // Arrange
        int[] arr = new int[1] { 42 };

        // Act
        string result = Reverse.ReverseArray(arr);

        // Assert
        Assert.That(result, Is.EqualTo("42"));
    }

    [Test]
    public void Test_ReverseArray_InputHasMultipleElements_ShouldReturnReversedString()
    {
        //Arrange
        int[] arr = new int[6] { 1, 2, 3, 4, 5, 6 };

        //Act
        string result = Reverse.ReverseArray(arr);

        //Assert
        Assert.That(result, Is.EqualTo("6 5 4 3 2 1"));
    }
}
