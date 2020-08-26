using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests.CalculationTests
{
    [TestClass]
    class MultiplicationTests
    {
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
    }
}
