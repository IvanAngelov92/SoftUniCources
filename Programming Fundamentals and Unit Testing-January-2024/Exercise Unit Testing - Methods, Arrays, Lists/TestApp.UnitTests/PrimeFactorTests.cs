using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [Test]
    public void Test_FindLargestPrimeFactor_PrimeNumber()
    {
        //Arrange
        long number = 7;
        long expectedResult = 7;

        //Act
        long result = PrimeFactor.FindLargestPrimeFactor(number);

        //Assert
        Assert.AreEqual(expectedResult, result);
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        //Arrange
        long nonPrimeNumber = 100;
        long expectedResult = 5;

        //Act
        long result = PrimeFactor.FindLargestPrimeFactor(nonPrimeNumber);

        //Assert
        Assert.AreEqual(expectedResult, result);
    }
}
