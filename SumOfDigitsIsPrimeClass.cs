/*****************************************
 * C# / VS in-class group development exercise
 * Posted on GitHub
 * Bill Nicholson and students
 * nicholdw@ucmail.uc.edu
 * ***************************************/

using System;

namespace GroupDevExercise
{
    class SumOfDigitsIsPrimeClass : TestBehavior
    {
        /// <summary>
        /// Test the SumOfDigitsIsPrime method
        /// </summary>
        /// <param name="verbose">True if the method should print test results as they are processed</param>
        /// <returns>true if all tests passed, false otherwise.</returns>
        override public Boolean Test(Boolean verbose)
        {
            if (!SumOfDigitsIsPrime(25)) return false;//return 7

            if (!SumOfDigitsIsPrime(30)) return false;//return 3

            if (!SumOfDigitsIsPrime(65)) return false;//return 11

            if (!SumOfDigitsIsPrime(2999)) return false;//return 29

            if (!SumOfDigitsIsPrime(887)) return false;//return 25

            if (!SumOfDigitsIsPrime(999999999994)) return false;//return 103

            if (SumOfDigitsIsPrime(44)) return false;//return 8

            if (SumOfDigitsIsPrime(99)) return false;//return 18

            if (SumOfDigitsIsPrime(12829)) return false;//return

            if (SumOfDigitsIsPrime(1289)) return false;//return


            return true;
        }
        /// <summary>
        /// Sum the digits in an integer and check that number for primeness
        /// </summary>
        /// <param name="num">The number to process</param>
        /// <returns>true if the sum of digits is prime, false otherwise</returns>
        public static bool SumOfDigitsIsPrime(long num)
        {
            string StringNum = num.ToString();
            long Sum = 0;
            foreach (char c in StringNum){
           
                Sum += (long)char.GetNumericValue(c);

            }//end foreach

            return IsPrimeClass.IsPrime(Sum);
    
        }
    }
}

