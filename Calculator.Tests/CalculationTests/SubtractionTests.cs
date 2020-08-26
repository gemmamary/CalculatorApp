using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests.CalculationTests
{
    [TestClass]
    class SubtractionTests
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
    }
}
