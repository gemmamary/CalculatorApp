using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculationTests
    {
        [TestMethod]
        public void CanAddNumbers()
        { 
            // Arrange
            var firstNumber = 2;
            var secondNumber = 5;
            var expectedSum = 7;

            // Act
            var sum = Calculation.AddNumbers(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expectedSum, sum, "That sum is incorrect");
        }

        [TestMethod]
        public void CanSubtractNumbers()
        { 
            // Arrange
            var firstNumber = 13;
            var secondNumber = 8;
            var expectedSum = 5;

            // Act
            var sum = Calculation.SutractNumbers(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expectedSum, sum, "That sum is incorrect");
        }

        [TestMethod]
        public void CanMultiplyNumbers()
        { 
            // Arrange
            var firstNumber = 5;
            var secondNumber = 2;
            var expectedSum = 10;

            // Act
            var sum = Calculation.MultiplyNumbers(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expectedSum, sum, "That sum is incorrect");
        }

        [TestMethod]
        public void CanDivideNumbers()
        { 
            // Arrange
            var firstNumber = 10;
            var secondNumber = 2;
            var expectedSum = 5;

            // Act
            var sum = Calculation.DivideNumbers(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expectedSum, sum, "That sum is incorrect");
        }

    }
}
