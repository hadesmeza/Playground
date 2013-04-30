using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Classes
{
    public class LinkedList<TValue> : ICollectionNodes<TValue>
    {
        public Node<TValue> First { get; private set; }
        public Node<TValue> Last { get; private set; }
        public int Count { get; private set; }

        public LinkedList(TValue value)
        {
            First = new Node<TValue>(value);
            Last = First;
            Count++;
        }

        public void Insert(Node<TValue> node)
        {
            Last.Next = node;
            Last = node;
            Count++;
            var temp = node;
            while (temp.Next != null)
            {
                Count++;
                temp = temp.Next;

            }
        }

        public void InsertAt(Node<TValue> node, int idx)
        {
            if (idx < 0 || idx > (Count + 1)) throw new IndexOutOfRangeException();
            var current = FindAt(idx);
            var previous = FindAt(idx - 1);
            previous.Next = node;
            node.Next = current;
            //check if the idx passed in is the last
            if (Count == idx) Last = node;
            Count++;


        }

        public void Remove(Node<TValue> node)
        {
            var next = First.Next;
            var previous = First;

            while (next != null)
            {
                if (node.Data.Equals(next.Data)) break;
                previous = next;
                next = next.Next;

            }

            previous.Next = next == null ? null : next.Next;

        }

        public void RemoveAt(int idx)
        {
            var tobeDel = FindAt(idx);
            Remove(tobeDel);
        }

        public Node<TValue> FindAt(int idx)
        {
            if (idx < 0) throw new IndexOutOfRangeException();
            var temp = First;
            int pos = 0;
            if (idx == pos) return temp;
            while (temp != null && pos < idx)
            {
                pos++;
                temp = temp.Next;
            }
            return temp;
        }

        /// <summary>
        /// Find the intersectiong node on the following shape 
        /// 
        ///    []-[]-[] \
        ///               []-[]-[]-[]     
        ///       []-[] /
        ///    
        /// </summary>
        /// <param name="nodeX"></param>
        /// <param name="nodeY"></param>
        /// <returns></returns>
        public Node<TValue> FindIntersection(LinkedList<TValue> LListX, LinkedList<TValue> LListY)
        {
            int lengthX = LListX.Count,
                lengthY = LListY.Count,
                delta = 0;
            Node<TValue> x, y;

            if (lengthX > lengthY)
            {
                delta = lengthX - lengthY;
                x = LListX.FindAt(delta);
                y = LListY.First;

            }
            else
            {
                delta = lengthY - lengthX;
                y = LListY.FindAt(delta);
                x = LListX.First;
            }

            while (x != null && y != null)
            {
                if (x.Data.Equals(y.Data)) break;
                x = x.Next;
                y = y.Next;
            }

            return x;
        }

        /// <summary>
        /// Finds the begining of a loop in a structure like below   
        /// 
        ///                  1-2-5-9
        ///                 /       8 
        ///     11-12-15-18-        |
        ///                 \       7
        ///                  26-29-30     
        /// </summary>
        /// <returns> 18 is the begining of the loop </returns>
        public Node<TValue> FindBeginingOfLoop(Node<TValue> head)
        {
            Node<TValue> node = head, slow = head;

            if (IsCircularLinkedList(out node))
            {
                while (node !=  slow)
                {
                    slow = slow.Next;
                    node = node.Next;
                }

                return node;
            }
            return null;

        }

        public bool IsCircularLinkedList(out Node<TValue> node)
        {
            var fast = First;
            var slow = First;
            node = null;
            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                if (slow == fast){node = fast; return true;}
            }

            return false;
        }


        public Node<int> Reverse(Node<int> node)
        {
            if (node == null || node.Next == null) return node;

            var nextItem = node.Next;
            node.Next = null;
            var reverseRest = Reverse(nextItem);
            nextItem.Next = node;
            return reverseRest;


        }
        public void Reverse()
        {
            var current = First;
            Node<TValue> reversed = null;

            while (current.Next != null)
            {
                var temp = reversed;
                reversed = new Node<TValue>(current.Data) {Next = temp};
                current = current.Next;

            }
            
            Last = First;
            Last.Next = null;

            First = current;
            First.Next = reversed;



        }
    }
}
