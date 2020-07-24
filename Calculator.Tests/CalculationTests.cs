using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculationTests
    {

        public int firstNumber = 10;
        public int secondNumber = 2;

        [TestMethod]
        public void CanAddNumbers()
        { 
            // Arrange
            var expectedSum = 12;

            // Act
            var sum = Calculation.AddNumbers(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expectedSum, sum, "That sum is incorrect");
        }

        [TestMethod]
        public void CanSubtractNumbers()
        { 
            // Arrange
            var expectedSum = 8;

            // Act
            var sum = Calculation.SutractNumbers(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expectedSum, sum, "That sum is incorrect");
        }

        [TestMethod]
        public void CanMultiplyNumbers()
        { 
            // Arrange
            var expectedSum = 20;

            // Act
            var sum = Calculation.MultiplyNumbers(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expectedSum, sum, "That sum is incorrect");
        }

        [TestMethod]
        public void CanDivideNumbers()
        { 
            // Arrange
            var expectedSum = 5;

            // Act
            var sum = Calculation.DivideNumbers(firstNumber, secondNumber);

            // Assert
            Assert.AreEqual(expectedSum, sum, "That sum is incorrect");
        }

    }
}
