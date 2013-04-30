using System;
using System.Collections.Generic;
using System.Text;
using Algorithms.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTest
{
    /// <summary>
    /// Summary description for TreesTests
    /// </summary>
    [TestClass]
    public class TreesTests
    {
       
        [TestMethod]
        public void TestBinTreeAddLeft()
        {
            var bintree = new BinTree<int>(8);
            bintree.AddLeft(5);
            bintree.AddLeft(6);
            bintree.AddLeft(7);
            bintree.AddLeft(8);
            bintree.AddLeft(9);
            Assert.IsTrue(bintree.Root.Left.Data == 5);
            Assert.IsTrue(bintree.Root.Left.Left.Data == 6);
            Assert.IsTrue(bintree.Root.Left.Left.Left.Data == 7);
            Assert.IsTrue(bintree.Root.Left.Left.Left.Left.Data == 8);
            Assert.IsTrue(bintree.Root.Left.Left.Left.Left.Left.Data == 9);

        }

        [TestMethod]
        public void TestBinTreeAddRight()
        {
            var bintree = new BinTree<int>(8);
            bintree.AddRight(5);
            bintree.AddRight(6);
            bintree.AddRight(7);
            bintree.AddRight(8);
            bintree.AddRight(9);
            Assert.IsTrue(bintree.Root.Right.Data == 5);
            Assert.IsTrue(bintree.Root.Right.Right.Data == 6);
            Assert.IsTrue(bintree.Root.Right.Right.Right.Data == 7);
            Assert.IsTrue(bintree.Root.Right.Right.Right.Right.Data == 8);
            Assert.IsTrue(bintree.Root.Right.Right.Right.Right.Right.Data == 9);
            var d = bintree.GettreeDepth();
            var h = bintree.GettreeHeigth();
            
            Assert.IsTrue(d == 6);
            Assert.IsTrue(h == 5);

        }

        [TestMethod]
        public void TestBinTreeHeigthDepth()
        {
            var bintree = new BinTree<int>(1);
            bintree.AddLeft(2);
            bintree.AddRight(3);
            bintree.AddLeft(4);
            bintree.AddRight(7);
            bintree.Root.Left.AddRight(bintree.Root.Left, new BinTreeNode<int>(5));
            bintree.Root.Right.AddLeft(bintree.Root.Right, new BinTreeNode<int>(6));
            
            var d = bintree.GettreeDepth();
            var h = bintree.GettreeHeigth();

            Assert.IsTrue(d == 3);
            Assert.IsTrue(h == 2);

        }

        [TestMethod]
        public void TestBST()
        {
            var arr = new List<int>();
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            arr.Add(5);
            arr.Add(6);
            arr.Add(7);

            var bst = BinTree<object>.BuildBST(arr, 0, arr.Count -1);
        }


        [TestMethod]
        public void TestLinkedlistBST()
        {
            var arr = new Algorithms.Classes.Node<int>(1);
            arr.Next = new Node<int>(2);
            arr.Next.Next = new Node<int>(3);
            arr.Next.Next.Next = new Node<int>(4);
            arr.Next.Next.Next.Next = new Node<int>(5);
            arr.Next.Next.Next.Next.Next = new Node<int>(6);
            arr.Next.Next.Next.Next.Next.Next = new Node<int>(7);

            var bst = BinTree<object>.BuildBST(arr,0, 7-1);
        }
    }
}
