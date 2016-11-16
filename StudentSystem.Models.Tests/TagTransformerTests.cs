namespace StudentSystem.Models.Tests
{
    using StudentSystem.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TagTransformerTests
    {
        [TestMethod]
        public void Transform_WithCorrectlyFormattedArgument_ReturnStringSameAsArgument()
        {
            // Arrange
            string argument = "#NoMakeup";

            // Act
            string formattedString = TagTransofrmer.Transform(argument);

            // Assert
            Assert.AreEqual(argument, formattedString);
        }

        [TestMethod]
        public void Transform_WithIncorrectlyFormattedArgument_ReturnFormattedString()
        {
            // Arrange
            string argument = " #  No Makeup# Scarlett   Johansson ";

            // Act
            string formattedString = TagTransofrmer.Transform(argument);

            // Assert
            Assert.AreEqual("#NoMakeupScarlettJoh", formattedString);
        }
    }
}