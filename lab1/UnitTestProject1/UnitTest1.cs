using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Line(1, 1);
            var d = new Line(1, 2);
            Assert.AreEqual(null, Operation.intersection(c, d));
        }
        [TestMethod]
        public void TestMethod2()
        {
            var a = new Line(-1, 1);
            var b = new Line(1, 2);
            var c = new Point((double)-0.5, (double)1.5);
            Assert.AreEqual(c.GetType(), Operation.intersection(a, b).GetType());
        }
    }
}
