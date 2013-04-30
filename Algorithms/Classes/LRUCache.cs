using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTest.Classes
{
    public class LRUCache<Key, Value>
    {
        readonly int _capacity;
        public IDictionary<Key, CacheItem<Key, Value>> CacheMap = new Dictionary<Key, CacheItem<Key, Value>>();
        private readonly SortedSet<CacheItem<Key, Value>> _priorityList = new SortedSet<CacheItem<Key, Value>>();

        public LRUCache(int capacity)
        {
            this._capacity = capacity;
        }

        public Value Get(Key key)
        {
            CacheItem<Key, Value> node;
            if (CacheMap.TryGetValue(key, out node))
            {
                //Cache HIT 
                var value = node.value;
                //put the gotten value at the tail so we know that the ones at the top aren't being used that much
                _priorityList.Remove(node);
                //update stamp
                node.stamp = PrecisedDateTime.UtcNow;
                _priorityList.Add(node);
                return value;
            }
            //Cache MISS
            return default(Value);
        }
        public void Set(Key key, Value val)
        {
            if (CacheMap.Count >= _capacity) RemoveFirst();//unshift()

            var cacheItem = new CacheItem<Key, Value>(key, val);
            _priorityList.Add(cacheItem);
            CacheMap.Add(key, cacheItem);
        }


        private void RemoveFirst()
        {
            // Remove eldest from Priority
            var node = _priorityList.Min;
            _priorityList.Remove(node);
            // Remove from cache
            CacheMap.Remove(node.key);
        }


    }


    public class CacheItem<Key, Value> : IComparable<CacheItem<Key, Value>>
    {
        public CacheItem(Key k, Value v)
        {

            key = k;
            value = v;
        }
        public Key key;
        public Value value;
        public DateTime stamp = PrecisedDateTime.UtcNow;

        public int CompareTo(CacheItem<Key, Value> other)
        {
            return DateTime.Compare(this.stamp, other.stamp);
        }
    }
}
