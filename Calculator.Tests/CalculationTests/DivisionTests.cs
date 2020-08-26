using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Tests.CalculationTests
{
    [TestClass]
    public class DivisionTests
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

        [TestMethod]
        public void CanDivideDecimalNumbers()
        {
            var expectedSum = 9.372;
            var sum = Calculation.DivideNumbers(23.43, 2.5);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanDivideByZero()
        {
            var expectedSum = 10;
            var sum = Calculation.DivideNumbers(10, 0);
            Assert.AreEqual(expectedSum, sum);
        }

        [TestMethod]
        public void CanDivideZeroByNumber()
        {
            var expectedSum = 0;
            var sum = Calculation.DivideNumbers(0, 10);
            Assert.AreEqual(expectedSum, sum);
        }
    }
}
