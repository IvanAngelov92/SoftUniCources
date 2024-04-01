using NUnit.Framework;

using System;
using System.Collections.Generic;
using static NUnit.Framework.Constraints.Tolerance;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        this._exceptions = new();
    }

    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        string input = "world";
        string expected = "dlrow";

        // Act
        string result = _exceptions.ArgumentNullReverse(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
    }

    [TestCase(100, 50, 50)]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice(decimal totalPrice, decimal discount, decimal expectedValue)
    {
        decimal result = _exceptions.ArgumentCalculateDiscount(totalPrice, discount);
        // Assert
        Assert.That(result, Is.EqualTo(expectedValue));
    }

    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        //Assert
        Assert.Throws<ArgumentException>(() =>
        _exceptions.ArgumentCalculateDiscount(80, -10));
    }

    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
        _exceptions.ArgumentCalculateDiscount(80, 101));
    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        // Arrange
        int[] array = { 1, 2, 3, 4, 5 };
        int index = 2;
        int expected = 3;

        // Act
        int result = _exceptions.IndexOutOfRangeGetElement(array, index);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 1, 2, 3 };
        int index = -1;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;

        // Act & Assert
        Assert.Throws<IndexOutOfRangeException>(() =>
        _exceptions.IndexOutOfRangeGetElement(array, index));
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length + 1;

        // Act & Assert
        Assert.Throws<IndexOutOfRangeException>(() =>
        _exceptions.IndexOutOfRangeGetElement(array, index));
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        // Arrange
        bool isLoggedIn = true;

        // Act
        string result = _exceptions.InvalidOperationPerformSecureOperation(isLoggedIn);

        // Assert
        Assert.AreEqual("User logged in.", result);
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        // Arrange
        bool isLoggedIn = false;

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => _exceptions.InvalidOperationPerformSecureOperation(isLoggedIn));
    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        // Arrange
        string input = "123";

        // Act
        int result = _exceptions.FormatExceptionParseInt(input);

        // Assert
        Assert.AreEqual(123, result);
    }

    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        // Arrange
        string input = "abc";

        // Act & Assert
        Assert.Throws<FormatException>(() => _exceptions.FormatExceptionParseInt(input));
    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        // Arrange
        var dictionary = new Dictionary<string, int>
        {
            { "key1", 100 },
            { "key2", 200 },
            { "key3", 300 }
        };
        var key = "key2";

        // Act
        int result = _exceptions.KeyNotFoundFindValueByKey(dictionary, key);

        // Assert
        Assert.AreEqual(200, result);
    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        // Arrange
        var dictionary = new Dictionary<string, int>
        {
            { "key1", 100 },
            { "key2", 200 },
            { "key3", 300 }
        };
        var key = "key4";

        // Act & Assert
        Assert.Throws<KeyNotFoundException>(() => _exceptions.KeyNotFoundFindValueByKey(dictionary, key));
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        // Arrange
        int a = 10;
        int b = 20;

        // Act
        int result = _exceptions.OverflowAddNumbers(a, b);

        // Assert
        Assert.AreEqual(30, result);
    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = int.MaxValue;
        int b = 1;

        // Act & Assert
        Assert.Throws<OverflowException>(() => _exceptions.OverflowAddNumbers(a, b));
    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = int.MinValue;
        int b = -1;

        // Act & Assert
        Assert.Throws<OverflowException>(() => _exceptions.OverflowAddNumbers(a, b));
    }

    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        // Arrange
        int dividend = 10;
        int divisor = 2;

        // Act
        int result = _exceptions.DivideByZeroDivideNumbers(dividend, divisor);

        // Assert
        Assert.AreEqual(5, result);
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        int dividend = 10;
        int divisor = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => _exceptions.DivideByZeroDivideNumbers(dividend, divisor));
    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        // Arrange
        int[] collection = { 1, 2, 3, 4, 5 };
        int index = 2;

        // Act
        int result = _exceptions.SumCollectionElements(collection, index);

        // Assert
        Assert.AreEqual(15, result);
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        // Arrange
        int[] collection = null;
        int index = 2;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => _exceptions.SumCollectionElements(collection, index));
    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] collection = { 1, 2, 3, 4, 5 };
        int index = 10;

        // Act & Assert
        Assert.Throws<IndexOutOfRangeException>(() => _exceptions.SumCollectionElements(collection, index));
    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        // Arrange
        var dictionary = new Dictionary<string, string>
        {
            { "key1", "10" },
            { "key2", "20" },
            { "key3", "30" }
        };
        string key = "key2";

        // Act
        int result = _exceptions.GetElementAsNumber(dictionary, key);

        // Assert
        Assert.AreEqual(20, result);
    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        // Arrange
        var dictionary = new Dictionary<string, string>
        {
            { "key1", "10" },
            { "key2", "20" },
            { "key3", "30" }
        };
        string key = "key4";

        // Act & Assert
        Assert.Throws<KeyNotFoundException>(() => _exceptions.GetElementAsNumber(dictionary, key));
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        // Arrange
        var dictionary = new Dictionary<string, string>
        {
            { "key1", "abc" }
        };
        string key = "key1";

        // Act & Assert
        Assert.Throws<FormatException>(() => _exceptions.GetElementAsNumber(dictionary, key));
    }
}
