using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using static Calculator.Calculation;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculationTests
    {
        //public int firstNumber = 10;
        //public int secondNumber = 2;
        //public int firstNegative = -10;
        //public int secondNegative = -2;

        [TestMethod]
        public void CanAddPositiveNumbers()
        { 
            var expectedSum = 12;
            var sum = Calculation.AddNumbers(8, 4);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanAddNegativeNumbers()
        { 
            var expectedSum = -12;
            var sum = Calculation.AddNumbers(-8, -4);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanAddNegativeAndPositiveNumber()
        {
            var expectedSum = -4;
            var sum = Calculation.AddNumbers(-8, 4);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanAddPositiveAndNegativeNumber()
        {
            var expectedSum = 4;
            var sum = Calculation.AddNumbers(8, -4);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanSubtractNumbers()
        { 
            var expectedSum = 4;
            var sum = Calculation.SubtractNumbers(8, 4);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanSubtractNegativeNumbers()
        {
            var expectedSum = -4;
            var sum = Calculation.SubtractNumbers(-8, -4);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanSubtractNegativeAndPositiveNumber()
        {
            var expectedSum = -12;
            var sum = Calculation.SubtractNumbers(-8, 4);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanSubtractPositiveAndNegativeNumber()

        {
            var expectedSum = 12;
            var sum = Calculation.SubtractNumbers(8, -4);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanMultiplyNumbers()
        { 
            var expectedSum = 32;
            var sum = Calculation.MultiplyNumbers(8, 4);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanMultiplyNegativeNumbers()
        {
            var expectedSum = 32;
            var sum = Calculation.MultiplyNumbers(-8, -4);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanMultiplyNegativeAndPositiveNumber()
        {
            var expectedSum = -32;
            var sum = Calculation.MultiplyNumbers(-8, 4);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanMultiplyPositiveAndNegativeNumber()
        {
            var expectedSum = -32;
            var sum = Calculation.MultiplyNumbers(8, -4);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanDivideNumbers()
        { 
            var expectedSum = 2;
            var sum = Calculation.DivideNumbers(8, 4);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanDivideNegativeNumbers()
        {
            var expectedSum = 2;
            var sum = Calculation.DivideNumbers(-8, -4);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanDivideNegativeAndPositiveNumber()
        {
            var expectedSum = -2;
            var sum = Calculation.DivideNumbers(-8, 4);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanDividePositiveAndNegativeNumber()
        {
            var expectedSum = -2;
            var sum = Calculation.DivideNumbers(8, -4);
            Assert.AreEqual(expectedSum, sum);
        }

    }
}
