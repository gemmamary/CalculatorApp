using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace Calculator.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void GreetingContainsUsername()
        { 
            // Arrange
            var expected = "Greetings Mark! I am a calculator, here to solve all your numeric needs!";
            // Act
            var greeting = User.GreetUser("Mark");

            // Assert
            Assert.AreEqual(expected, greeting, false, "The greeting does not contain the username");
        }

        [TestMethod]
        public void BlankUsernameReturnsGenericGreeting()
        { 
            // Arrange
            var expected = "Greetings ! I am a calculator, here to solve all your numeric needs!";
            // Act
            var greeting = User.GreetUser("");

            // Assert
            Assert.AreEqual(expected, greeting, false, "The greeting message is incorrect");
        }
    }
}
