using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Classes
{
    public interface ICollectionNodes<TValue>
    {
        void Insert(Node<TValue> node);

        void InsertAt(Node<TValue> node, int idx);

        void Remove(Node<TValue> node);

        void RemoveAt(int idx);

        Node<TValue> FindAt(int idx);

    }
}
