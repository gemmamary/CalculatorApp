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

        [TestMethod]
        public void CanAddNumbers()
        { 
            var expectedSum = 12;

            var sum = Calculation.AddNumbers(firstNumber, secondNumber);

            Assert.AreEqual(expectedSum, sum, "That sum is incorrect");
        }

        [TestMethod]
        public void CanSubtractNumbers()
        { 
            var expectedSum = 8;

            var sum = Calculation.SubtractNumbers(firstNumber, secondNumber);

            Assert.AreEqual(expectedSum, sum, "That sum is incorrect");
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
