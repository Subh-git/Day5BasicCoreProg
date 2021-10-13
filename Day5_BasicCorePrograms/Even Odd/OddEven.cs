using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_BasicCorePrograms.Even_Odd
{
    class OddEven
    {
        /// <summary>
        /// Checks the odd even.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        public string CheckOddEven(int n)
        {
            string s;
            if (n%2 == 0)           // if the remainder is 0 upon divided by 2
            {
                s = "The entered number is an even number";
            }
            else
            {
                s = "The entered number is an odd number";
            }
            return s;
        }


    }
}
