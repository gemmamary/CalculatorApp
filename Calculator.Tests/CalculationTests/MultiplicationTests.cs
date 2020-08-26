using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests.CalculationTests
{
    [TestClass]
    public class MultiplicationTests
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

        [TestMethod]
        public void CanMultiplyDecimalNumbers()
        {
            var expectedSum = 10.668000000000001;
            var sum = Calculation.MultiplyNumbers(2.54, 4.2);
            Assert.AreEqual(expectedSum, sum);
        }
    }
}
