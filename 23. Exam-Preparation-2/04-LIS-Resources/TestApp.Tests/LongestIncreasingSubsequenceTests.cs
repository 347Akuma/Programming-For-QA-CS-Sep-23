using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        // Arrange
        int[] arr = null;

        // Act & Assert (due to exception)
        Assert.That(() => LongestIncreasingSubsequence.GetLis(arr), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        //Arrange
        int[] arr = Array.Empty<int>();

        //Act
        string output = LongestIncreasingSubsequence.GetLis(arr);

        //Assert
        Assert.That(output, Is.Empty);
    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        //Arrange
        int[] arr = new int[] { 1 };

        //Act
        string output = LongestIncreasingSubsequence.GetLis(arr);

        //Assert
        Assert.That(output, Is.EqualTo("1"));
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {

        //Arrange
        int[] arr = new int[] { 1, 3, 4, 6, 2, 1 };

        //Act
        string output = LongestIncreasingSubsequence.GetLis(arr);

        //Assert
        Assert.That(output, Is.EqualTo("1 3 4 6"));
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        //Arrange
        int[] arr = new int[] { 1, 2, 3, 4, 6 };

        //Act
        string output = LongestIncreasingSubsequence.GetLis(arr);

        //Assert
        Assert.That(output, Is.EqualTo("1 2 3 4 6"));
    }
}
