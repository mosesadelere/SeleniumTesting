using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SearchFrameWork
{
    [TestClass]
    public class BasicMathsTest
    {
        [TestMethod]
        public void TestAdd()
        {
            BasicMath bm = new BasicMath();
            double actual = bm.Add(10, 10);
            Assert.AreEqual(20, actual);
        }

        [TestMethod]
        public void TestSubstract()
        {
            BasicMath bm = new BasicMath();
            double actual = bm.Substract(10, 10);
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void TestDivide()
        {
            BasicMath bm = new BasicMath();
            double actual = bm.Divide(10, 10);
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void TestMultiply()
        {
            BasicMath bm = new BasicMath();
            double actual = bm.Multiply(10, 10);
            Assert.AreEqual(100, actual);
        }
    }
}
