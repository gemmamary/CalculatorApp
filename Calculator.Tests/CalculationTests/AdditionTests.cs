using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests.CalculationTests
{
    [TestClass]
    class AdditionTests
    {
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
    }
}
