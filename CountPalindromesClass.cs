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
    /// Count the palimdromes in a List
    /// </summary>
    class CountPalindromesClass : TestBehavior {

        /// <summary>
        /// Test the CountPalindromes method
        /// </summary>
        /// <param name="verbose">True if the method should print test results as they are processed</param>
        /// <returns>true if all tests passed, false otherwise.</returns>
        override public Boolean Test(Boolean verbose) {

            List<long> L1 = new List<long>() { 13 };
            List<long> L2 = new List<long>() { 8228, 737, 298, 234, 19, 1893 };
            List<long> L3 = new List<long>() { 0, 0, 0 };
            List<long> L4 = new List<long>() { };
            List<long> L5 = new List<long>() { 333444333, 28407958, 9999900099999, 874320563298576, 24978529478532187, 777707777 };
            List<long> L6 = new List<long>() { -767, 898, 45 };
            List<long> L7 = new List<long>() { -269, 59, 11 };
            List<long> L8 = new List<long>() { 7, 93139, 83 };


            if (CountPalindromes(L1) != 0) return false;

            if (CountPalindromes(L2) != 2) return false;

            if (CountPalindromes(L3) != 3) return false;

            if (CountPalindromes(L4) != 0) return false;

            if (CountPalindromes(L5) != 3) return false;

            //this will fail
            if (CountPalindromes(L6) != 2) return false;

            if (CountPalindromes(L7) != 1) return false;

            if (CountPalindromes(L8) != 2) return false;

            return true;

        }
        /// <summary>
        /// Count the palindromes in a list of integers
        /// </summary>
        /// <param name="list">The list of numbers to process</param>
        /// <returns>The count of integers in list that are palindromws</returns>
        public static long  CountPalindromes(List<long> list)  {

            long result = 0;

            //for each number in list
            foreach (long num in list)
            {
                //if the number is prime, increase the result by 1
                if (IsPalindromeClass.IsPalindrome(num))
                {
                    result++;
                }
            }

            return result;
        }
    }
}
