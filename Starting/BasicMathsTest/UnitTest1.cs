using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Starting;

namespace BasicMathsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddMethod()
        {
            BasicMaths bm = new BasicMaths();
            double result = bm.Add(10, 3);
            Assert.AreEqual(result, 13);
        }

        [TestMethod]
        public void TestSubstractMethod()
        {
            BasicMaths bm = new BasicMaths();
            double result = bm.Substract(10, 3);
            Assert.AreEqual(result, 7);
        }

        [TestMethod]
        public void TestDivideMethod()
        {
            BasicMaths bm = new BasicMaths();
            double result = bm.Divide(10, 2);
            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        public void TestMultiplyMethod()
        {
            BasicMaths bm = new BasicMaths();
            double result = bm.Multiply(10, 3);
            Assert.AreEqual(result, 30);
        }
    }
}
