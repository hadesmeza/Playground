using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Classes
{
    public class BinTreeNode<TData>
    {
        public TData Data { get; private set; }
        public BinTreeNode<TData> Left { get; set; }
        public BinTreeNode<TData> Right { get; set; }
        public bool IsRoot { get; set; }
        public bool IsHalfFull
        {
            get { return Left == null || Right == null; }
        }

        public BinTreeNode()
        {
        }

        public BinTreeNode(TData value)
        {
            Data = value;
        }

        public bool IsLeaf
        {
            get { return Left == null && Right == null; }
        }

        public void AddLeft(BinTreeNode<TData> root, BinTreeNode<TData> node)
        {

            if (root.Left == null) root.Left = node;
            else if(root.Left != null)
                AddLeft(root.Left, node);
        }

        public void AddRight(BinTreeNode<TData> root, BinTreeNode<TData> node)
        {
            if (root.Right == null) root.Right = node;
            else if (root.Right != null)
                AddRight(root.Right, node);
        }

        public int GetMaxTreeHeigth(BinTreeNode<TData> root)
        {
            int l = 0, r = 0;
            var curr = root;

            while(curr.Left != null)
            {
                l++;
                curr = curr.Left;
            }

            curr = root;

            while (curr.Right != null)
            {
                r++;
                curr = curr.Right;
            }

            return l > r ? l : r;

        }

        public int GetMaxTreeDepth(BinTreeNode<TData> root)
        {
            if (root == null) return 0;

            var ld = GetMaxTreeDepth(root.Left);
            var rd = GetMaxTreeDepth(root.Right);
            return (ld > rd ? ld : rd) + 1;

        }
    }
}
