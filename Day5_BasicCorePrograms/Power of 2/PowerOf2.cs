using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_BasicCorePrograms.Power_of_2
{
    class PowerOf2
    {
        /// <summary>
        /// Powers the specified n.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        public string Power(int n)
        {
            //local variables
            double count = 1;   //counter
            double power;
            double x = 2;
            
            //looping to write the table of the power of two from the user specified power of 2
            while (count <= n)
            {
                power = Math.Pow(x,count);
                count++;
                Console.WriteLine(power);

            }
            return "The above is the table of 2's Powers";
           
        }
    }
}
