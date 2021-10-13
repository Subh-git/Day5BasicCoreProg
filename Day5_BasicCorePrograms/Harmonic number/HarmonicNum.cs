using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_BasicCorePrograms.Harmonic_number
{
    class HarmonicNum
    {
        /// <summary>
        /// Harmonicses the specified n.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        public double Harmonics(double n)
        {
            //variables
            double harmonic = 0;
            double count;

            //loop to iterate and add the oncoming harmonic numbers
            for ( count = 1; count <= n; count++)
            {
                harmonic = harmonic + (1 / count);
            }
            return harmonic;
        }
    }
}
