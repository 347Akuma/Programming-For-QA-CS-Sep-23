using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void CalculateFactorial_InputZero_ReturnsOne()
    {
        //Arrange
        int n = 0;

        //Act
        int output = Factorial.CalculateFactorial(n);

        //Assert
        Assert.AreEqual(1, output);
    }

    [Test]
    public void CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        //Arrange
        int n = 2;

        //Act
        int output = Factorial.CalculateFactorial(n);

        //Assert
        Assert.AreEqual(2, output);
    }

    [Test]
    public void CalculateFactorial_InputNegativeNumber_ThrowsException()
    {
        //Arrange
        int n = -2;

        //Act + Assert (Assert.Throws<exception>(() => ClassName.MethodName(parameter));
        Assert.Throws<ArgumentOutOfRangeException>(() => Factorial.CalculateFactorial(n));

    }
}

