using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_BasicCorePrograms.Swap_2_nos
{
    class SwappingTwoNum
    {
        /// <summary>
        /// Swaps the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">The b.</param>
        /// <returns></returns>
        public int? Swap(int a, int b)          //using the int? instead of int to return nullable values
        {
            Console.WriteLine("Before swapping the numbers are First num: " + a + " And Second num: " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After swapping the numbers are First num: " + a + " And Second num: " + b);

            return null;                      // returning nullable values
        }
    }
}
