using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_NumberLowerThanTwo()
    {
        //Arrange
        long belowTwo = 1;

        //Act & Assert
        Assert.That(() => PrimeFactor.FindLargestPrimeFactor(belowTwo), Throws.ArgumentException);
        
    }

    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        //Arrange
        long primeNum = 5;

        //Act
        long result = PrimeFactor.FindLargestPrimeFactor(primeNum);

        //Assert
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        //Arrange
        long primeNum = 5555;

        //Act
        long result = PrimeFactor.FindLargestPrimeFactor(primeNum);

        //Assert
        Assert.That(result, Is.EqualTo(101));
    }
}
