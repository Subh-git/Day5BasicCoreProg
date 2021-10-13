using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_BasicCorePrograms.Vowel_or_Consonent
{
    class VowelChecker
    {
        /// <summary>
        /// Checks the vowel.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        public string CheckVowel(string n)
        {
            //variables
            string s;

            //switching through cases to check the alphabets for any vowels
            switch(n)
            {
                case "a":
                    s = "a is vowel";
                    break;
                case "e":
                    s = "e is vowel";
                    break;

                case "i":
                    s = "i is vowel";
                    break;

                case "o":
                    s = "o is vowel";
                    break;

                case "u":
                    s = "u is vowel";
                    break;

                default:
                    s ="" +n+ " is a consonant";
                    break;
            }
            return s;                             //returning a string value

        }
    }
}
