using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_BasicCorePrograms.Leap_year
{
    class LeapYear
    {
        /// <summary>
        /// Calculates the leap year.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        public string CalculateLeapYear(int n)
        {
            //variables
            string s;
            
            //main body of the if statement that checks if the year is leap or not
           if ( (n % 4 == 0) && (n%100 != 0) || (n % 400 ==0))
            {
                 s = "The year is a leap year";
            }
           else
            {
                 s = "The entered year is not a leap year";
            }

            return s;                                //returning a string value
        }
    }
}
