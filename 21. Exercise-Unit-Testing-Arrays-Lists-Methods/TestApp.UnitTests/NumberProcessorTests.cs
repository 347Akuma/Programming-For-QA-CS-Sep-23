using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class NumberProcessorTests
{
    [Test]
    public void Test_ProcessNumbers_SquareEvenNumbers()
    {
        // Arrange
        List<int> input = new() { 2, 4, 6 };
        List<double> expected = new() { 4, 16, 36 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    // TODO: finish test
    [Test]
    public void Test_ProcessNumbers_SquareRootOddNumbers()
    {
        // Arrange
        List<int> input = new() { 1, 3, 5 };
        List<double> expected = new() { 1, 1.7320508075688772d, 2.2360679774997898d };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    // TODO: finish test
    [Test]
    public void Test_ProcessNumbers_HandleZero()
    {
        // Arrange
        List<int> input = new() { 0 };
        List<int> expected = new() { 0 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ProcessNumbers_HandleNegativeNumbers()
    {
        List<int> nullList = new() { -1 };

        Assert.That(() => NumberProcessor.ProcessNumbers(nullList), Throws.ArgumentException);
    }

    [Test]
    public void Test_ProcessNumbers_EmptyInput()
    {
        // Arrange      
        List<int> expected = new ();

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(expected);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }
}
