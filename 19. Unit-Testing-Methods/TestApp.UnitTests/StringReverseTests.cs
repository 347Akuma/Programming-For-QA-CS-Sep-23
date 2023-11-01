using NUnit.Framework;
using System.Linq;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";

        // Act
       string actual = StringReverse.Reverse(input);

        // Assert
       Assert.AreEqual("", actual);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        //Arrange
        string input = "a";

       //Act
       string actual = StringReverse.Reverse(input);

       //Assert
       Assert.That(actual, Is.EqualTo(input));
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        //Arrange
        string input = "ABCD";

        //Act
        string actual = StringReverse.Reverse(input);

        //Assert
        Assert.That(actual, Is.EqualTo(input.Reverse()));
    }
}
