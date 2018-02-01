/*****************************************
 * C# / VS in-class group development exercise
 * Posted on GitHub
 * Bill Nicholson and students
 * nicholdw@ucmail.uc.edu
 * ***************************************/

using System;
using System.Collections.Generic;


namespace GroupDevExercise {
    /// <summary>
    /// Count palindromes where both are prime
    /// </summary>
    class CountPalindromesWhereBothArePrimeClass : TestBehavior {


        /// <summary>
        /// Test the CountPalindromesWhereBothArePrime method
        /// </summary>
        /// <param name="verbose">True if the method should print test results as they are processed</param>
        /// <returns>true if all tests passed, false otherwise.</returns>
        override public Boolean Test(Boolean verbose) {
            List<long> numList = new List<long>();
            for (int i = 0; i < 1000; i++)
            {
                numList.Add(i);
            }
            if (CountPalindromesWhereBothArePrime(numList) > 0)
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// Count the number of integers in a list that are palindromes and both the original number and the palindrome are prime.
        /// </summary>
        /// <param name="list">The list of integers to process</param>
        /// <returns>the count</returns>
        public static int CountPalindromesWhereBothArePrime(List<long> list)
        {
            int palindromePrimeCount = 0;
            foreach (long num in list)
            {
                if (IsPrimeClass.IsPrime(num) == true && IsPalindromeClass.IsPalindrome(num) == true)
                {
                    palindromePrimeCount++;
                }
            }
            return palindromePrimeCount;
        }
    }
}
