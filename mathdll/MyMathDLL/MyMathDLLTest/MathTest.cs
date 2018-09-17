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
            Assert.AreEqual(m.Add(-1,-3), -5);
        }
    }
}
