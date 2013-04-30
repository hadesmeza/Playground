using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTest.Classes
{
    public class Sorting
    {
        /// <summary>
        /// This function finds an integer in a rotating sorted array by identifying ranges
        /// based on leftmost mid and rightMost.
        /// The given approach should yield O(logn) complexity of it is based on a binarySearch algorithm;
        /// however if duplicate it might yield O(n)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="st">start of the array</param>
        /// <param name="end">last index of array</param>
        /// <param name="k">the integer to be found</param>
        /// <returns> the index at which the sought values is placed in the array</returns>
        public static int FindK(int[] array, int st, int end, int k)
        {
            if (st > end) return -1;

            var mid = (st + end) / 2;

            if (array[mid] == k) return mid;


            if (array[st] < array[mid]) // check if left side is ordered normally
            {
                if (k >= array[st] && k <= array[mid]) //check if betwen the range on the left 
                {
                    return FindK(array, st, mid - 1, k);
                }
                return FindK(array, mid + 1, end, k);//if we make it here then go to the right 
            }
            if (array[end] > array[mid]) // check if rigth side is ordered normally
            {
                if (k >= array[mid] && k <= array[end])//check if betwen the range on the right
                {
                    return FindK(array, mid + 1, end, k);
                }
                return FindK(array, st, mid - 1, k);//if we make it here then go to the left 
            }
            if (array[st] == array[mid])//check if we got dups on the left
            {
                if (array[mid] < array[end])//check if right is ordered normally
                {
                    return FindK(array, mid + 1, end, k);
                }
                //if we make it here we need to search both
                var result = FindK(array, st, mid - 1, k); //check on the left
                return result == -1 ? FindK(array, mid + 1, end, k) : result; //if not found then go to the rigth
            }

            return -1; //default if none of the above cases applied
        }

        public void DutchFlagSort(int[] arr, int lo, int hi)
        {
            throw new NotImplementedException();
        }

        public void QuickSort(int[] arr)
        {
            QS(arr, 0, arr.Length - 1);
        }

        private static void QS(int[] arr, int low, int hi)
        {
            if (low < hi)
            {
                var pivotIdx = (low + hi) / 2;
                var pivot = arr[pivotIdx];
                arr[pivotIdx] = arr[hi];
                arr[hi] = pivot;

                int i = low - 1, j = hi;

                do
                {
                    do
                    {
                        i++;
                    } while (arr[i] < pivot);
                    do
                    {
                        j--;
                    } while (arr[j] > pivot && j > low);

                    if (i < j)
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                    }
                } while (i < j);

                arr[hi] = arr[i];
                arr[i] = pivot;

                QS(arr, low, i - 1);
                QS(arr, i + 1, hi);

            }
        }

        public void QuickSort2(int[] arr, int low, int hi)
        {
            var pivotIdx = (low + hi) / 2;
            var pivot = arr[pivotIdx];
            int i = low, j = hi;
            while (i <= j)
            {
                while (arr[i] < pivot)
                {
                    i++;
                }

                while (j > low && arr[j] > pivot)
                {
                    j--;
                }

                if (i < j)
                {
                    var temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;

                }
            }

            if (j > low)
                QuickSort2(arr, low, j);
            else if (i < hi)
                QuickSort2(arr, i, hi);
        }

    }



}
