using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_BasicCorePrograms.Flip_coin
{
   public class Flipcoin
    {
        /// <summary>
        /// Flips the coin simulator.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        public string FlipCoinSimulator(int n)
        {
            //Local variables Declaration
            int count = 0; int heads=0; int tails = 0;
            double headsPercent;
            double tailsPercent;

            //looping the number of times for the no. of user defined trials
            while (count < n)
            {
                Random random = new Random();
                double flip = random.NextDouble();                 //the .NextDouble() method returns a double value in the range 0-1

                if (flip < 0.5)
                {
                    tails++;
                }
                else
                {
                    heads++;
                }
                count++;
            }

            //conversion to percentage
            headsPercent = ((heads) * 100/n);
            tailsPercent = ((tails) * 100/n);
            string abc = headsPercent.ToString();
            string abc1 = tailsPercent.ToString();

            string s = ("The percentage of HEADS is "+ abc + " and the percentage of TAILS is " + abc1);
            return s;

        }

        
    
    }
}
