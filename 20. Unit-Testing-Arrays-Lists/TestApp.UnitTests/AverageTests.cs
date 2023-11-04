using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class AverageTests
{
    // TODO: finish the test
    [Test]
    public void Test_CalculateAverage_InputIsEmptyArray_ShouldThrowArgumentException()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Average.CalculateAverage(emptyArray));
       
    }

    // TODO: finish the test
    [Test]
    public void Test_CalculateAverage_InputHasOneElement_ShouldReturnSameElement()
    {
        // Arrange
        int[] array = { 42 };

        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(42));
    }

    [Test]
    public void Test_CalculateAverage_InputHasPositiveIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] array = { 1, 2, 3, 4, 5 };

        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void Test_CalculateAverage_InputHasNegativeIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] array = { -1, -2, -3, -4, -5 };

        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(-3));
    }

    [Test]
    public void Test_CalculateAverage_InputHasMixedIntegers_ShouldReturnCorrectAverage()
    {
        // Arrange
        int[] array = { -20, 30, -40, 50 };

        // Act
        double result = Average.CalculateAverage(array);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
}
