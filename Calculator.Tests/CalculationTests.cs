using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using static Calculator.Calculation;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculationTests
    {
        public int firstNumber = 10;
        public int secondNumber = 2;
        public int firstNegative = -10;
        public int secondNegative = -2;

        [TestMethod]
        public void CanAddPositiveNumbers()
        { 
            var expectedSum = 12;
            var sum = Calculation.AddNumbers(firstNumber, secondNumber);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanAddNegativeNumbers()
        { 
            var expectedSum = -12;
            var sum = Calculation.AddNumbers(firstNegative, secondNegative);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanAddNegativeAndPositiveNumber()
        {
            var expectedSum = 0;
            var sum = Calculation.AddNumbers(secondNegative, secondNumber);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanAddPositiveAndNegativeNumber()
        {
            var expectedSum = -8;
            var sum = Calculation.AddNumbers(secondNumber, firstNegative);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanSubtractNumbers()
        { 
            var expectedSum = 8;
            var sum = Calculation.SubtractNumbers(firstNumber, secondNumber);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanSubtractNegativeNumbers()
        {
            var expectedSum = -8;
            var sum = Calculation.SubtractNumbers(firstNegative, secondNegative);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanSubtractNegativeAndPositiveNumber()
        {
            var expectedSum = -4;
            var sum = Calculation.SubtractNumbers(secondNegative, secondNumber);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanSubtractPositiveAndNegativeNumber()
        {
            var expectedSum = 12;
            var sum = Calculation.SubtractNumbers(secondNumber, firstNegative);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanMultiplyNumbers()
        { 
            var expectedSum = 20;
            var sum = Calculation.MultiplyNumbers(firstNumber, secondNumber);
            Assert.AreEqual(expectedSum, sum, "That sum is incorrect");
        }

        [TestMethod]
        public void CanDivideNumbers()
        { 
            var expectedSum = 5;
            var sum = Calculation.DivideNumbers(firstNumber, secondNumber);
            Assert.AreEqual(expectedSum, sum, "That sum is incorrect");
        }

    }
}
