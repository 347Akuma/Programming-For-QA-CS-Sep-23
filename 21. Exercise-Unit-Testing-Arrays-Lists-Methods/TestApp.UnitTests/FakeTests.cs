using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    // TODO: finish test
    [Test]
    public void Test_RemoveStringNumbers_NullInput_ThrowsException()
    {
        // Arrange
        char[]? input = null;

        // Act + Assert
        Assert.That(() => Fake.RemoveStringNumbers(input), Throws.ArgumentException);
    }

    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        char[] chars = new char[] { '0', '1', 'a', 'b', 'c' };

        char[] result = Fake.RemoveStringNumbers(chars);

        Assert.That(result, Is.EqualTo(new char[] { 'a', 'b', 'c' }));
    }

    [Test]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray()
    {
        char[] chars = new char[] { 'a', 'b', 'c' };

        char[] result = Fake.RemoveStringNumbers(chars);

        Assert.That(result, Is.EqualTo(new char[] { 'a', 'b', 'c' }));
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        char[] chars = Array.Empty<char>();

        char[] result = Fake.RemoveStringNumbers(chars);

        Assert.That(result, Is.Empty);
    }
}
