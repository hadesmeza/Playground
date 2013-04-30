using System;
using System.Collections.Generic;
using System.Linq;
using AlgorithmsTest.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTest
{
    [TestClass]
    public class LRUUnitTest
    {
        [TestMethod]
        public void RemoveLRU_Test()
        {
            var o = new LRUCache<int, string>(5);
            o.Set(1, "one");
            o.Set(2, "two");
            o.Set(3, "three");
            o.Set(4, "four");
            o.Set(5, "five");

            var t = o.Get(5);
            t = o.Get(2);
            t = o.Get(1);
            t = o.Get(5);
            t = o.Get(3);
            o.Set(6, "six"); //should remove 4
            Assert.IsTrue(o.CacheMap.Keys.Any(k => k == 4) == false);

        }

    }
}
