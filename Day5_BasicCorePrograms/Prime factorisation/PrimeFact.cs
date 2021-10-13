using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_BasicCorePrograms.Prime_factorisation
{
    class PrimeFact
    {
        /// <summary>
        /// Factorises the specified n.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        public int? Factorise(int n)
        {
            //the brute force application of the logic
            for (int i = 2; i*i <=n; i++)
            {
                while (n%i == 0)
                {
                    n = n / i;
                    Console.WriteLine("" + i);
                }
            }
            // the below case is apllicable if n isn't divisible and n is itself a prime number
            if (n != 1)
            {
                Console.WriteLine("" + n);
            }
            return null;
        }
    }
}
