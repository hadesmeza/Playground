using System;
using Algorithms.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTest
{
    [TestClass]
    public class LinkedListTests
    {
        [TestMethod]
        public void TestCurrent()
        {
            var ll = new LinkedList<int>(1);
            ll.Insert(new Node<int>(2));
            ll.Insert(new Node<int>(5));
            ll.Insert(new Node<int>(9));
            Assert.IsTrue(ll.Last.Data == 9);
        }

        [TestMethod]
        public void TestFindAt()
        {
            var ll = new LinkedList<int>(1);
            ll.Insert(new Node<int>(2));
            ll.Insert(new Node<int>(5));
            ll.Insert(new Node<int>(9));

            var node = ll.FindAt(2);
            var node2 = ll.FindAt(2-1);

            Assert.IsTrue(node2.Data == 2);
            Assert.IsTrue(node.Data == 5);
        }

        [TestMethod]
        public void TestInsertAt()
        {
            var ll = new LinkedList<int>(1);
            ll.Insert(new Node<int>(2));
            ll.Insert(new Node<int>(5)); 
            ll.Insert(new Node<int>(9));

            ll.InsertAt(new Node<int>(10), 2);
            Assert.IsTrue(ll.Last.Data == 9);
            Assert.IsTrue(ll.First.Next.Next.Data == 10);
            Assert.IsTrue(ll.Count == 5);
        }


        [TestMethod]
        public void TestInsertAtIndexOutOfRangeException()
        {
            var ll = new LinkedList<int>(1);
            ll.Insert(new Node<int>(2));
            ll.Insert(new Node<int>(5));
            ll.Insert(new Node<int>(9));

            var ct = ll.Count;
            ll.InsertAt(new Node<int>(10), ct);
            Assert.IsTrue(ll.Count == 5);
            Assert.IsTrue(ll.Last.Data == 10 );
        }



        [TestMethod]
        public void TestRemove()
        {
            var ll = new LinkedList<int>(1);
            ll.Insert(new Node<int>(2));
            ll.Insert(new Node<int>(5));
            ll.Insert(new Node<int>(9));

            var node = ll.FindAt(2);
            ll.Remove(node);
            var after = ll.FindAt(2);
            Assert.IsTrue(after.Data == 9);
        }

        [TestMethod]
        public void TestFindIntersection()
        {
            /*
                      1-2-5-9
                             \
                              11-12-15-18
                             /
             26-29-30-8-6-7-3
             
             
             */
            var ll = new LinkedList<int>
                                   (1);   
            ll.Insert(new Node<int>(2));  
            ll.Insert(new Node<int>(5));  
            ll.Insert(new Node<int>(9));  
            ll.Insert(new Node<int>(11)); 
            ll.Insert(new Node<int>(12)); 
            ll.Insert(new Node<int>(15)); 
            ll.Insert(new Node<int>(18));

            var l2 = new LinkedList<int>
                                   (26);
            l2.Insert(new Node<int>(29));
            l2.Insert(new Node<int>(30));
            l2.Insert(new Node<int>(8));
            l2.Insert(new Node<int>(6));
            l2.Insert(new Node<int>(7));
            l2.Insert(new Node<int>(3));
            l2.Insert(ll.FindAt(4));

            var node = ll.FindIntersection(ll, l2);
            Assert.IsTrue(node.Data == 11);

        }

        [TestMethod]
        public void TestFindBeginOfLoop()
        {
            /*
                           1-2-5-9
                         /       8 
             11-12-15-18-        6
                         \       7
                          26-29-30             
            */

            var ll = new LinkedList<int>
                                   (11);
            ll.Insert(new Node<int>(12));
            ll.Insert(new Node<int>(15));
            ll.Insert(new Node<int>(18));
            ll.Insert(new Node<int>(1));
            ll.Insert(new Node<int>(2));
            ll.Insert(new Node<int>(5));
            ll.Insert(new Node<int>(9));
            ll.Insert(new Node<int>(8));
            ll.Insert(new Node<int>(7));
            ll.Insert(new Node<int>(30));
            ll.Insert(new Node<int>(29));
            ll.Insert(new Node<int>(26));
            var node = ll.FindAt(3);
            ll.Last.Next = node;
            var found = ll.FindBeginingOfLoop(ll.First);
            Assert.IsTrue(found.Data == 18);


        }


        [TestMethod]
        public void TestReverseLinkedList()
        {
            var ll = new LinkedList<int>
                                 (1);
            ll.Insert(new Node<int>(2));
            ll.Insert(new Node<int>(5));
            ll.Insert(new Node<int>(9));  

            ll.Reverse();

            Assert.IsTrue(ll.First.Data == 9 );
            Assert.IsTrue(ll.Last.Data == 1);


            var ll2 = new LinkedList<int>(1);
            ll2.Insert(new Node<int>(2));
            ll2.Insert(new Node<int>(3));
            ll2.Insert(new Node<int>(4));

            var t = ll2.Reverse(ll2.First);
        }

        [TestMethod]
        public void T()
        {
            Assert.IsTrue((2170444777 & 0x80000000) != 0);
            Assert.IsFalse((2147444777 & 0x80000000) != 0);
        }

    }
}
