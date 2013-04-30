using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Classes
{
    public class Node<TData>
    {
        public TData Data { get; private set; }
        public Node<TData> Next { get; set; }

        public Node()
        {
        }

        public Node(TData value)
        {
            Data = value;
            Next = null;
        }

    }
}
