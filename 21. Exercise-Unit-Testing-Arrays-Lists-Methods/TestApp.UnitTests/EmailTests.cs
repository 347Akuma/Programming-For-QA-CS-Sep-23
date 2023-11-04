using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [Test]
    public void Test_IsValidEmail_ValidEmail()
    {
        // Arrange
        string validEmail = "test@example.com";

        // Act
        bool result = Email.IsValidEmail(validEmail);

        // Assert
        Assert.That(result, Is.True);
    }

    [Test]
    public void Test_IsValidEmail_InvalidEmail()
    {
        // Arrange
        string nullEmail = "absolutelyinvalid.com";

        // Act
        bool result = Email.IsValidEmail(nullEmail);

        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arrange
        string nullEmail = string.Empty;

        // Act
        bool result = Email.IsValidEmail(nullEmail);

        // Assert
        Assert.That(result, Is.False);
    }
}
