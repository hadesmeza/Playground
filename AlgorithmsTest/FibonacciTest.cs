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
         
            Assert.IsTrue(Fibonacci.GetFibonacci(0) == 0);
            Assert.IsTrue(Fibonacci.GetFibonacci(1) == 1);
            Assert.IsTrue(Fibonacci.GetFibonacci(2) == 1);
            Assert.IsTrue(Fibonacci.GetFibonacci(3) == 2);
            Assert.IsTrue(Fibonacci.GetFibonacci(4) == 3);
            Assert.IsTrue(Fibonacci.GetFibonacci(5) == 5);
            Assert.IsTrue(Fibonacci.GetFibonacci(6) == 8);

            Assert.IsTrue(Fibonacci.GetFibonacci(14) == 377);

        }
    }
}
