using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    // TODO: finish the test
    [Test]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum()
    {
        // Arrange
        int[] arr = { 2, 4, 6, 8 };

        // Act
        int result = EvenOddSubtraction.FindDifference(arr);

        // Assert
        Assert.That(result, Is.EqualTo(20));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] arr = { 1, 3, 5, 7 };

        // Act
        int result = EvenOddSubtraction.FindDifference(arr);

        // Assert
        Assert.That(result, Is.EqualTo(16));    
    }

    [Test]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference()
    {
        // Arrange
        int[] arr = { 2, 4, 7, 9 };

        // Act
        int result = EvenOddSubtraction.FindDifference(arr);

        // Assert
        Assert.That(result, Is.EqualTo(10));
    }
}
