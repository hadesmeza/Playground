using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Classes
{
    public class Fibonacci
    {
        public static Dictionary<int, int> Cache = new Dictionary<int, int> {{0, 0}, {1, 1}};

        public List<int> Series { get; private set; }

        public Fibonacci(int number)
        {
            Series = new List<int>();
            for (var i = 0; i <= number; i++)
            {
                Series.Add(Compute(i));
            }
        }

        private int Compute(int number)
        {
            if (number == 0 || number == 1) return Cache[number];
            if (Cache.ContainsKey(number))
            {
                return Cache[number];
            }
            
            var val = Cache[number - 1] + Cache[number - 2];
            Cache.Add(number, val);
            return val;
        }

    }
}
