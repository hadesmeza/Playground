using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Classes
{
    public class BinTree<TData>
    {
        public BinTreeNode<TData> Root { get; private set; }
        public BinTree(TData data)
        {
            Root = new BinTreeNode<TData>(data) { IsRoot = true };
        }

        public void AddLeft(TData data)
        {
            Root.AddLeft(Root, new BinTreeNode<TData>(data));
        }

        public void AddRight(TData data)
        {
            Root.AddRight(Root, new BinTreeNode<TData>(data));
        }

        public int GettreeDepth()
        {
            return Root.GetMaxTreeDepth(Root);
        }

        public int GettreeHeigth()
        {
            return Root.GetMaxTreeHeigth(Root);
        }

        public static BinTreeNode<T> BuildBST<T>(List<T> arr, int st, int end )
        {
            if (st > end) return null;

            var idx = (st + end)/2;
            var root = arr[idx];
            var node = new BinTreeNode<T>(root);


            if (st == end) return node;
            node.Left = BuildBST(arr, st, idx - 1);
            node.Right =  BuildBST(arr, idx + 1, end);

            return node;
        }



        public static BinTreeNode<T> BuildBST<T>(Node<T> node, int start, int end)
        {
            if (start > end) return null;

            var slow = node;
            var i = 0;

            for (; i < (start + end) / 2; i++)
            {
                slow = slow.Next;
            }

            var root = new BinTreeNode<T>(slow.Data);

            if (start ==  end) return root;
            root.Left = BuildBST(node, start, i - 1);
            root.Right = BuildBST(node, i + 1, end);

            return root;
        }
    }
}
