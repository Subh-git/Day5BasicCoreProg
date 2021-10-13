using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_BasicCorePrograms.Largest_of_three_numbers
{
    class LargestThreenum
    {
        /// <summary>
        /// Checks the largest.
        /// </summary>
        /// <param name="num1">The num1.</param>
        /// <param name="num2">The num2.</param>
        /// <param name="num3">The num3.</param>
        /// <returns></returns>
        public string CheckLargest(int num1, int num2, int num3)
        {
            //local variable declaration
            string s;
            string abc, abc2, abc3;
            int max;

            //Main comaparision logic
            if((num1 > num2) && (num1 > num3))
            {
                max = num1;
            }
            else if ((num2 > num1) && (num2 > num3))
            {
                max = num2;
            }
            else
            {
                max = num3;
            }

            //conversion of the integer type implicitly to string data types to return in the string method
            abc = num1.ToString();
            abc2 = num2.ToString();
            abc3 = num3.ToString();

            s= ("The largest amongst "+abc+ " "+abc2+ " "+abc3+ " is "+max);
            return s;


        }
    }
}
