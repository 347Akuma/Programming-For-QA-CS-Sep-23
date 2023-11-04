using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class GaussTrickTests
{
    [Test]
    public void Test_SumPairs_InputIsEmptyList_ShouldReturnEmptyList()
    {
        // Arrange
        List<int> emptyList = new();

        // Act
        List<int> result = GaussTrick.SumPairs(emptyList);

        // Assert
        CollectionAssert.AreEqual(emptyList, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasSingleElement_ShouldReturnSameElement()
    {
        // Arrange
        List<int> singleElement = new List<int>(1);

        // Act
        List<int> result = GaussTrick.SumPairs(singleElement);

        // Assert
        CollectionAssert.AreEqual(singleElement, result);
    }

    // TODO: finish the test
    [Test]
    public void Test_SumPairs_InputHasEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> list = new List<int> { 1, 2, 3, 4 };

        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        CollectionAssert.AreEqual(result, new List<int> { 5, 5 });
    }

    [Test]
    public void Test_SumPairs_InputHasOddCountElements_ShouldReturnWithMiddleElement()
    {
        // Arrange
        List<int> list = new List<int> { 1, 2, 3, };

        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        CollectionAssert.AreEqual(result, new List<int> { 4, 2 });
    }

    [Test]
    public void Test_SumPairs_InputHasLargeEvenCountElements_ShouldReturnSumPairs()
    {
        // Arrange
        List<int> list = new List<int> { 1250, 2056, 3044, 4150 };

        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        CollectionAssert.AreEqual(result, new List<int> { 5400, 5100 });
    }

    [Test]
    public void Test_SumPairs_InputHasLargeOddCountElements_ShouldReturnWithMiddleElement()
    {

        // Arrange
        List<int> list = new List<int> { 1250, 2056, 3044, };

        // Act
        List<int> result = GaussTrick.SumPairs(list);

        // Assert
        CollectionAssert.AreEqual(result, new List<int> { 4294, 2056 });
    }
}
