namespace StudentSystem.Models.Tests
{
    using StudentSystem.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TagAttributeTests
    {
        [TestMethod]
        public void IsValid_WithValidArgument_ReturnTrue()
        {
            // Arrange
            string argument = "#NoMakeup";
            TagAttribute tag = new TagAttribute();

            // Act
            var result = tag.IsValid(argument);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsValid_WithInvalidArgumentContainBlankSpace_ReturnFalse()
        {
            // Arrange
            string argument = "#No Makeup";
            TagAttribute tag = new TagAttribute();

            // Act
            var result = tag.IsValid(argument);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValid_WithInvalidArgumentNotContainHashSymbol_ReturnFalse()
        {
            // Arrange
            string argument = "NoMakeup";
            TagAttribute tag = new TagAttribute();

            // Act
            var result = tag.IsValid(argument);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValid_WithInvalidArgumentContainMoreThanOneHashSymbol_ReturnFalse()
        {
            // Arrange
            string argument = "#No#Makeup";
            TagAttribute tag = new TagAttribute();

            // Act
            var result = tag.IsValid(argument);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValid_WithInvalidArgumentContainMoreThanTwentySymbols_ReturnFalse()
        {
            // Arrange
            string argument = "#NoMakeupScarlettJohansson";
            TagAttribute tag = new TagAttribute();

            // Act
            var result = tag.IsValid(argument);

            // Assert
            Assert.IsFalse(result);
        }
    }
}