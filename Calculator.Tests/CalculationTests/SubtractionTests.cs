using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests.CalculationTests
{
    [TestClass]
    public class SubtractionTests
    {
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
        public void CanSubtractDecimalNumbers()

        {
            var expectedSum = 20.78;
            var sum = Calculation.SubtractNumbers(43.32, 22.54);
            Assert.AreEqual(expectedSum, sum);
        }
    }
}
