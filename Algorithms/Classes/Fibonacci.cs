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



        public static int GetFibonacci(int number)
        {
            int prev = 0;
            int current = 1;


            for (var i = 0; i < number; i++)
            {
                var temp =current;
                current = prev + current;
                prev = temp;

                
            }
            return prev;
        }

    }
}
