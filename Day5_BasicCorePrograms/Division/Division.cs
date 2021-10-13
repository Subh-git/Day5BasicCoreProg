using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_BasicCorePrograms.Division
{
    class DivisionOperator
    {
        /// <summary>
        /// Divides the specified n.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public string Divide(int n, int y)
        {
            //variable declaration
            int quotient;
            int remainder;
            string s;

            //Ther below part resembles the operation
            quotient = n / y;
            remainder = n % y;
            string abc = quotient.ToString();         //converting to string type explicitly
            string abc1 = remainder.ToString();

            s = ("The quotient is " + abc + " and the remainder is " + abc1);
            return s;                                 //returning the string
        }
    }
}
