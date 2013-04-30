using System;
using System.Collections.Generic;
using AlgorithmsTest.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTest
{
    [TestClass]
    public class SortingTests
    {
 
        [TestMethod]
        public void TestArrayWithLKargestNumber()
        {
            var r = LexicoComparer<object>.Rsutl(new int[] { 8, 86, 89 }) == "89886";
            Assert.IsTrue(LexicoComparer<object>.Rsutl(new int[] { 1, 3, 2, 4 }) == "4321");
            Assert.IsTrue(LexicoComparer<object>.Rsutl(new int[] { 59, 58, 5, 1, 2 }) == "5958521");
            Assert.IsTrue(LexicoComparer<object>.Rsutl(new int[] { 54, 5, 55, 6, 7, 56, 120, 560, 540, 505, 9, 57, 0, 1, 45, 65 }) == "976655756560555545405054512010");

        }

        [TestMethod]
        public void TestQuickSort()
        {
            var arr = new int[] { 5, 9, 5, 8, 5, 2, 1 };
            var expected = new int[] {5, 9, 5, 8, 5, 2, 1};
            Array.Sort(expected);
            var srtr = new Sorting();
            srtr.QuickSort(arr);
            Assert.AreEqual(string.Join("", expected), string.Join("", arr));

        }

        [TestMethod]
        public void TestQuickSort2()
        {
            var arr = new int[] { 5, 9, 5, 8, 5, 2, 1 };
            var expected = new int[] { 5, 9, 5, 8, 5, 2, 1 };
            Array.Sort(expected);
            var srtr = new Sorting();
            srtr.QuickSort2(arr, 0, arr.Length -1);
            Assert.AreEqual(string.Join("", expected), string.Join("", arr));

        }

        [TestMethod]
        public void TestPrintAllPermutations()
        {
            var t = new StringPuzzles();
            var all = t.PrintAllPermutations("abc");

            Assert.IsTrue(all.Replace(" ", "") == "abc,acb,bac,bca,cba,cab");
        }


        [TestMethod]
        public void TestPrintSubsets()
        {
            var t = new StringPuzzles();
            var arr = new [] {1, 2, 3/*,4*/};
            var used = new bool[arr.Length];

            t.PirntSubSets(arr,0,0,2,used );
        }




        [TestMethod]
        public void TestChecIfSubstring()
        {
            var t = new StringPuzzles();
            var a = "afrtabcrrrr";
            var b = "rrrr";


             Assert.IsTrue(t.isSubstring(a, b));

             a = "afrtabcrrrr";
             b = "abc";
            
             Assert.IsTrue(t.isSubstring(a, b));

             a = "afrtabcrrrr";
             b = "tab";
            
             Assert.IsTrue(t.isSubstring(a, b));
             a = "afrtabcrrrr";
             b = "126";
             Assert.IsFalse(t.isSubstring(a, b));
        }
    }
}
