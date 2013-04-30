using System;
using Algorithms.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTest
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void TestFibonacci()
        {
            var fb = new Fibonacci(2);
            Assert.IsTrue(fb.Series[0] == 0);
            Assert.IsTrue(fb.Series[1] == 1);
            Assert.IsTrue(fb.Series[2] == 1);

            var fb2 = new Fibonacci(6);
            Assert.IsTrue(fb2.Series[0] == 0);
            Assert.IsTrue(fb2.Series[1] == 1);
            Assert.IsTrue(fb2.Series[2] == 1);
            Assert.IsTrue(fb2.Series[3] == 2);
            Assert.IsTrue(fb2.Series[4] == 3);
            Assert.IsTrue(fb2.Series[5] == 5);
            Assert.IsTrue(fb2.Series[6] == 8);
            var fb3 = new Fibonacci(14);
            Assert.IsTrue(fb3.Series[14] == 377);

        }
    }
}
