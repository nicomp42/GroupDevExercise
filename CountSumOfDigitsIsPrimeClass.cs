/*****************************************
 * C# / VS in-class group development exercise
 * Posted on GitHub
 * Bill Nicholson and students
 * nicholdw@ucmail.uc.edu
 * ***************************************/
using System;
using System.Collections.Generic;

namespace GroupDevExercise
{
    class CountSumOfDigitsIsPrimeClass : TestBehavior
    {
        /// <summary>
        /// Test the CountSumOfDigitsIsPrime method
        /// </summary>
        /// <param name="verbose">True if the method should print test results as they are processed</param>
        /// <returns>true if all tests passed, false otherwise.</returns>
        override public Boolean Test(Boolean verbose)
        {

            List<long> L1 = new List<long>() { 13};
            List<long> L2 = new List<long>() { 822, 737, 298, 234, 19, 1893 };
            List<long> L3 = new List<long>() { 0, 0, 0 };
            List<long> L4 = new List<long>() {};
            List<long> L5 = new List<long>() { 28768376625, 863462783, 82368732, 28768376625, 863462783, 82368732, 28768376625, 863462783, 82368732, 28768376625, 863462783, 82368732, 28768376625, 863462783, 82368732};
            List<long> L6 = new List<long>() { -76, 89, 45 };
            List<long> L7 = new List<long>() { 269, 59, 11 };
            List<long> L8 = new List<long>() { 7, 139, 83};
            List<long> L9 = new List<long>() { 421, 277, 67 };
            List<long> L10 = new List<long>() { 331, 19, 2287 };

            if (CountSumOfDigitsIsPrime(L1) != 0) return false;

            if (CountSumOfDigitsIsPrime(L2) != 2) return false;

            //this line breaks the test because 0 should return as not prime but returns as prime according to isPrime()
            if (CountSumOfDigitsIsPrime(L3) != 0) return false;

            if (CountSumOfDigitsIsPrime(L4) != 0) return false;

            if (CountSumOfDigitsIsPrime(L5) != 5) return false;

            if (CountSumOfDigitsIsPrime(L6) != 1) return false;

            if (CountSumOfDigitsIsPrime(L7) != 2) return false;

            if (CountSumOfDigitsIsPrime(L8) != 3) return false;

            if (CountSumOfDigitsIsPrime(L9) != 2) return false;

            if (CountSumOfDigitsIsPrime(L10) != 2) return false;


            return true;
        }
        /// <summary>
        /// Count the numbers in a list such that the sum of their digits is prime 
        /// </summary>
        /// <param name="list">The list of numbers to process</param>
        /// <returns>the count</returns>
        public static long CountSumOfDigitsIsPrime(List<long> list)
        {

            long result = 0;

            //for each number in list
            foreach (long num in list)
            {
                //if the number is prime, increase the result by 1
                if (SumOfDigitsIsPrimeClass.SumOfDigitsIsPrime(num))
                {
                    result++;
                }
            }

            return result;
        }
    }
}
