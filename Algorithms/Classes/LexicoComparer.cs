using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmsTest
{
    public class LexicoComparer<T> : IComparer<T>
    {


        public int Compare(T x, T y)
        {
            string s1 = x.ToString(), s2 = y.ToString();
            int i;
            var minLength = Math.Min(s1.Length, s2.Length);

            for (i = 0; i < minLength; i++)
            {
                char c1 = s1[i], c2 = s2[i];
                if (c1 != c2) return (c1 > c2 ? -1 : 1);
            }

            if (i == s1.Length)
            {
                for (var i1 = 0; i < s2.Length; i1++, i++)
                {
                    char c1 = s2[i1], c2 = s2[i];
                    if (c1 != c2) return (c1 > c2 ? -1 : 1);
                }
            }
            else if (i == s2.Length)
            {
                for (var i2 = 0; i < s1.Length; i++, i2++)
                {
                    char c1 = s1[i], c2 = s1[i2];
                    if (c1 != c2) return (c1 > c2 ? -1 : 1);
                }
            }

            return 0;
        }

        public static string Rsutl(IEnumerable<int> arr)
        {
            var t = arr.OrderByDescending(x => x, new LexicoComparer<int>()).ToArray();
            var rsutl = string.Empty;
            for (var i = t.Length - 1; i >= 0; i--)
            {

                rsutl += t[i].ToString();

            }
            return rsutl;
        }
    }
}
