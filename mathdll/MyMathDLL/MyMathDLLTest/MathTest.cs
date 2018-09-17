using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyMathDLL;

namespace MyMathDLLTest
{
    [TestClass]
    public class MathTest
    {
        MyMathClass m = new MyMathClass();
        [TestMethod]
        public void AddTest()
        {
            
            Assert.IsTrue(m.Add(2,3) == 5);
        }
        [TestMethod]
        public void AddTestNegativeNumbers()
        {
            Assert.AreEqual(m.Add(-2,-3), -5);
        }

        [TestMethod]
        public void SubtractTest()
        {
            Assert.IsTrue(m.Subtract(2,3) == -1);
        }

        [TestMethod]
        public void SubtractNegativeTest()
        {
            Assert.AreEqual(m.Subtract(2,-3), 5);
        }

        [TestMethod]
        public void DivideTest()
        {
            Assert.IsTrue(m.Divide(2,5) == 2);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            Assert.IsTrue(m.Multiply(2,5) == 10);
        }

        [TestMethod]
        public void MultiplyNegativeTest()
        {
            Assert.AreEqual(m.Multiply(2,-5), -10);
        }
    }
}
