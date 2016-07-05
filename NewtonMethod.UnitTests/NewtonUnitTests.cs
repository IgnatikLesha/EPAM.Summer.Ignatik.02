using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NewtonMethod.UnitTests
{
    [TestClass]
    public class NewtonUnitTests
    {
        [TestMethod]
        public void Root_27powerMinus2_Expected3()
        {
            double result = Newton.Root(9, 2);
            Assert.IsTrue(Math.Abs(result - 3) < 0.0001);
        }

        [TestMethod]
        public void Root_100powerMinus5_Expected2AndAHalf()
        {
            double result = Newton.Root(100, 5);
            Assert.IsTrue(Math.Abs(result - 2.511886) < 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Root_NotPositivePower_ArgumentExaptionExpected()
        {
            Newton.Root(10, -10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Root_NotPositiveAccuracy_ArgumentExaptionExpected()
        {
            Newton.Root(10, 3, -5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Root_AccuracyGrateThen1_ArgumentExaptionExpected()
        {
            Newton.Root(10, 3, 3);
        }
    }
}
