using NUnit.Framework;

namespace TestApp.Tests
{
    public class HashTagCheckerTests
    {
        [Test]
        public void Test_GetHashTags_ValidTextWithOneHashTag_ReturnMessageForOneHashTags()
        {
            //Arrange
            string result = HashTagChecker.GetHashTags("This is a text with #oneTag");

            //Act&Assert
            Assert.AreEqual("Only one! You know exactly what you #tag.", result);
        }

        [Test]
        public void Test_GetHashTags_ValidText_ReturnMessageForEvenHashTags()
        {
            //Arrange
            string result = HashTagChecker.GetHashTags("This is a text with #even #number #of #tags");

            //Act&Assert
            Assert.AreEqual("The text contains an even number of #tags (4 in total).", result);
        }

        [Test]
        public void Test_GetHashTags_ValidText_ReturnMessageForOddHashTags()
        {
            //Arrange
            string result = HashTagChecker.GetHashTags("This is a text with #odd #number #of #tags #included");

            //Act&Assert
            Assert.AreEqual("The text contains an odd number of #tags (5 in total).", result);
        }

        [Test]
        public void Test_GetHashTags_NullOrEmptyText_ReturnsErrorMessage()
        {
            //Arrange
            string result = HashTagChecker.GetHashTags(null);

            //Act&Assert
            Assert.AreEqual("No content...", result);
        }

        [Test]
        public void Test_GetHashTags_TestWithoutHashTags_ReturnsErrorMessage()
        {
            //Arrange
            string result = HashTagChecker.GetHashTags("This is a text without any hash tags");

            //Act&Assert
            Assert.AreEqual("The text does not contain #tags.", result);
        }
    }
}

