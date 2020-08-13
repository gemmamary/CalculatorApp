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
            var expected = "Greetings Mark! I am a calculator, here to solve all your numeric needs!";
            
            var greeting = User.GreetUser("Mark");
            
            Assert.AreEqual(expected, greeting, false, "The greeting does not contain the username");
        }

        [TestMethod]
        public void BlankUsernameReturnsGenericGreeting()
        { 
            var expected = "Greetings ! I am a calculator, here to solve all your numeric needs!";
            
            var greeting = User.GreetUser("");

            Assert.AreEqual(expected, greeting, false, "The greeting message is incorrect");
        }
    }
}
