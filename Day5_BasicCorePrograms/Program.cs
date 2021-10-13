using Day5_BasicCorePrograms.Division;
using Day5_BasicCorePrograms.Even_Odd;
using Day5_BasicCorePrograms.Flip_coin;
using Day5_BasicCorePrograms.Harmonic_number;
using Day5_BasicCorePrograms.Largest_of_three_numbers;
using Day5_BasicCorePrograms.Leap_year;
using Day5_BasicCorePrograms.Power_of_2;
using Day5_BasicCorePrograms.Swap_2_nos;
using Day5_BasicCorePrograms.Vowel_or_Consonent;
using System;

namespace Day5_BasicCorePrograms
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            //variables
            int argument, argument2, argument3;
            string argument4;
            double argument1;

            Console.WriteLine(" ** Welcome to the basic core programs ** ");
            Console.WriteLine();
            Console.WriteLine("Enter the number to select the following programs: 1 -FlipCoinSimulator, 2- Leap year Checker, 3- Power of 2, 4- Harmonic Value, 5- Odd Even checker");
            Console.WriteLine("6- Division  & remaninder checker, 7- Largest threenum, 8- Swapping two numbers, 9- Vowel Checker, 10- Prime Factor");

            //Taking the user input and converting it to int 
            int num = Convert.ToInt32(Console.ReadLine());

            //switching through the various cases
            switch(num)
            {
                case 1:
                    Console.WriteLine("You have selected the flip coin simulator please enter how many times u want to flip the coin");
                    argument = Convert.ToInt32(Console.ReadLine());
                    Flipcoin myobj1 = new Flipcoin();
                    Console.WriteLine(myobj1.FlipCoinSimulator(argument));
                    break;


                case 2:
                    Console.WriteLine("You have selected the Leap Year program. Enter your year");
                    argument = Convert.ToInt32(Console.ReadLine());
                    LeapYear myobj2 = new LeapYear();
                    Console.WriteLine(myobj2.CalculateLeapYear(argument));
                    break;

                case 3:
                    Console.WriteLine("You have selected the Power of two program. Enter your number (Less than 31) to obtain the power of 2's table");
                    argument = Convert.ToInt32(Console.ReadLine());
                    PowerOf2 myobj3 = new PowerOf2();
                    Console.WriteLine(myobj3.Power(argument));
                    break;

                case 4:
                    Console.WriteLine("You have selected the Harmonic program. Enter the Harmonic number N");
                    argument1 = Convert.ToDouble(Console.ReadLine());
                    HarmonicNum myobj4 = new HarmonicNum();
                    Console.WriteLine(myobj4.Harmonics(argument1));
                    break;

                case 5:
                    Console.WriteLine("You have selected the checking Odd and Even program. Enter your number");
                    argument = Convert.ToInt32(Console.ReadLine());
                    OddEven myobj5 = new OddEven();
                    Console.WriteLine(myobj5.CheckOddEven(argument));
                    break;


                case 6:
                    Console.WriteLine("You have selected the remainder and quotient checking program. Enter your dividend and divisor");
                    argument = Convert.ToInt32(Console.ReadLine());
                    argument2 = Convert.ToInt32(Console.ReadLine());
                    DivisionOperator myobj6 = new DivisionOperator();
                    Console.WriteLine(myobj6.Divide(argument,argument2));
                    break;

                case 7:
                    Console.WriteLine("You have selected the checking largest in 3 numbers program. Enter 3 numbers");
                    argument = Convert.ToInt32(Console.ReadLine());
                    argument2 = Convert.ToInt32(Console.ReadLine());
                    argument3 = Convert.ToInt32(Console.ReadLine());
                    LargestThreenum myobj7 = new LargestThreenum();
                    Console.WriteLine(myobj7.CheckLargest(argument, argument2,argument3));
                    break;

                case 8:
                    Console.WriteLine("You have selected the swap 2 numbers program. Enter your first and second numbers");
                    argument = Convert.ToInt32(Console.ReadLine());
                    argument2 = Convert.ToInt32(Console.ReadLine());
                    SwappingTwoNum myobj8 = new SwappingTwoNum();
                    Console.WriteLine(myobj8.Swap(argument, argument2));
                    break;
                
                case 9:
                    Console.WriteLine("You have selected the Alphabet checker program. Please enter the alphabet to check vowel or consonant");
                    VowelChecker myobj9 = new VowelChecker();
                    argument4 = Console.ReadLine();
                    Console.WriteLine(myobj9.CheckVowel(argument4));
                    break;


   
            }

        }
    }
}
