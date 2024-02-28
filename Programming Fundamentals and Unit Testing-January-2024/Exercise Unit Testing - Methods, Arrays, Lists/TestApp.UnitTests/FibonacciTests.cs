using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        //Arrange
        int zero = 0;

        //Act
        int result = Fibonacci.CalculateFibonacci(zero);

        //Assert
        Assert.AreEqual(0, result);
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        //Arrange
        int positive = 6;

        //Act
        int result = Fibonacci.CalculateFibonacci(positive);

        //Assert
        Assert.AreEqual(8, result);
    }
}