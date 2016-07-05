using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NewtonMethod.UnitTests
{
    [TestClass]
    public class NewtonUnitTests
    {
        [TestMethod]
        public void Root_27powerMinus3_Expected3()
        {
            double result = Newton.Root(9, 2);
            Assert.IsTrue(result - 3 < 0.0001);
        }

        public void Root_
    }
}
