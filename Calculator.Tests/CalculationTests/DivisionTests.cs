using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests.CalculationTests
{
    [TestClass]
    class DivisionTests
    {
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
