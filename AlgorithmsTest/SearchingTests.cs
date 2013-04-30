using System;
using System.Text;
using System.Collections.Generic;
using Algorithms.Classes;
using AlgorithmsTest.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTest
{
    /// <summary>
    /// Summary description for SearchingTests
    /// </summary>
    [TestClass]
    public class SearchingTests
    {
       
        [TestMethod]
        public void TestFindKthEl_Test()
        {
            var arr = new int[] {41,84,31,89,31,74,23,43,86,24,4,64,73,23,7,56,49,75,66};
            const int kth = 10;
            var result = Searching.FindKthEl(arr, 0, arr.Length -1, kth);
            Assert.IsTrue(result == 49);

        }

        [TestMethod]
        public void CountBlanks_Test()
        {
            var input = "  t  p ".ToCharArray();
            var result = Searching.CountBlanks(input, 0, input.Length -1 );
            Assert.IsTrue(result[0] == 2);
            Assert.IsTrue(result[1] == 2);
            Assert.IsTrue(result[2] == 1);
        }
    }
}
