using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    // TODO: finish test
    [Test]
    public void Test_SortInPattern_NullInput_ThrowsException()
    {
        // Arrange
        int[]? inputArray = null;

        // Act + Assert
        Assert.That(() => Pattern.SortInPattern(inputArray), Throws.ArgumentException);
    }

    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        int[] numbers = new int[] { 1, 2, 2, 3, 5, 6 };

        int[] result = Pattern.SortInPattern(numbers);

        Assert.That(result, Is.EqualTo(new int[] { 1, 6, 2, 5, 3 }));
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        int[] numbers = Array.Empty<int>();

        int[] result = Pattern.SortInPattern(numbers);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        int[] numbers = new int[1] { 1 };

        int[] result = Pattern.SortInPattern(numbers);

        Assert.That(result, Is.EqualTo(new int[] { 1 }));
    }
}
