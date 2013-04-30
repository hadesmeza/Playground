using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTest.Classes
{
    public class StringPuzzles
    {

        public string PrintAllPermutations(string value)
        {
            var perms = new List<string>();
            PrintAllPermutations(value.ToCharArray(), 0, ref perms);

            return string.Join(",", perms);
        }

        private void PrintAllPermutations(char[] value, int index, ref List<string> perms)
        {
            if (index == value.Length)

                perms.Add(string.Join("", value));

            else
            {
                for (var i = index; i < value.Length; i++)
                {
                    Swap(value, index, i);
                    PrintAllPermutations(value, index + 1, ref perms);
                    Swap(value, index, i);
                }
            }
        }

        private void Swap(char[] value, int i, int j)
        {
            var temp = value[i];
            value[i] = value[j];
            value[j] = temp;
        }

        public void PirntSubSets(int[] arr, int st, int currentsize, int k, bool[] used)
        {

            if (currentsize == k)
            {
                for (var i = 0; i < arr.Length; i++)
                {
                    if(used[i]) Debug.Write(arr[i] +" ");
                }
                return;
            }

            if(st == arr.Length) return;


            used[st] = true;
            PirntSubSets(arr, st+1, currentsize+1, k, used);
            used[st] = false;
            PirntSubSets(arr, st + 1, currentsize, k, used);
        }

        public bool isSubstring(string a, string b)
        {
            for (var i = 0; i < a.Length; i++)
            {
                if (CheckIfSubs(i, a.Length, a, b)) return true;
                
            }
            return false;
        }

        private static bool CheckIfSubs(int left, int right, string a , string b)
        {
            var j = 0;
            var result = false;

            for (var i = left; (i < right && j < b.Length); i++)
            {
                if (a[i] == b[j])
                {
                    j++;
                    result = true;
                    continue;
                }

                return false;
            }
            return result;
        }
    }
}
