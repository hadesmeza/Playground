using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Classes
{
    public class Searching
    {
       
        public static int FindKthEl(int[] arr, int low, int hi, int kth)
        {
            var pivotIdx = (low + hi)/2;
            var pivot = arr[pivotIdx];
            int i = low, j = hi;

            while (i < j)
            {
                while (arr[i] < pivot) i++;
                while (j >  low && arr[j] > pivot) j--;

                if (i < j)
                {
                    var tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                }
            }
            var t = arr[pivotIdx];
            arr[pivotIdx] = arr[j];
            arr[j] = t;

            if (kth == j + 1)
                return arr[j];
             if (kth > j + 1)
                return FindKthEl(arr, j + 1, hi, kth);
            
                return FindKthEl(arr, low, j - 1, kth);

        }

        public static int[] CountBlanks(char[] arr, int low, int hi)
        {
            int bef = 0, mid = 0, aft = 0, i = low, j = hi;
            var onlyInner = false;

            while (i < j)
            {
                if (arr[i] == ' ' && onlyInner == false)
                {
                    bef++;
                    i++;
                }
                else if (arr[j] == ' ' && onlyInner == false)
                {
                    aft++;
                    j--;
                }
                else if (i >= low && i <= hi)
                {
                    onlyInner = true;
                    if (arr[i] == ' ') mid++;
                    i++;
                }

            }

            return new int[] { bef, mid, aft };

        }
    }
}

