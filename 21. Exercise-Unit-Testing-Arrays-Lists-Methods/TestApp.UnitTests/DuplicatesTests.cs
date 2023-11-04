using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] numbers = new int[] { 1, 2, 3 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(new int[] { 1, 2, 3 }));
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        // Arrange
        int[] numbers = new int[] { 1, 2, 3, 4, 4, 5, 6, 6 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(new int[] { 1, 2, 3, 4, 5, 6 }));
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        // Arrange
        int[] numbers = new int[] { 1, 1, 1, 1, 1, 1, 1, 1 };

        // Act
        int[] result = Duplicates.RemoveDuplicates(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(new int[] { 1 }));
    }
}
