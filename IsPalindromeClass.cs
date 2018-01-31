/*****************************************
 * C# / VS in-class group development exercise
 * Posted on GitHub
 * Bill Nicholson and students
 * nicholdw@ucmail.uc.edu
 * ***************************************/

using System;

namespace GroupDevExercise {
    /// <summary>
    /// Check to see if a number is a palindrome
    /// </summary>
    class IsPalindromeClass : TestBehavior {


        /// <summary>
        /// Test the IsPalindrome method
        /// </summary>
        /// <param name="verbose">True if the method should print test results as they are processed</param>
        /// <returns>true if all tests passed, false otherwise.</returns>
        override public Boolean Test(Boolean verbose) {
            int testCasesPassed = 0, testCasesFailed = 0;
            long[] testCasesArePalindromes = new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11,22,33,111 };
            long[] testCasesAreNotPalindromes = new long[] { 12, 98, 100, 1000, 9998 };
            foreach (long l in testCasesArePalindromes) {
                if (IsPalindrome(l)) { testCasesPassed++; } else { testCasesFailed++; }
            }
            foreach (long l in testCasesAreNotPalindromes) {
                if (!IsPalindrome(l)) { testCasesPassed++; } else { testCasesFailed++; }
            }
            return (testCasesFailed > 0 ? false : true);
        }

        /// <summary>
        /// Check an integer for palindrome-ness
        /// </summary>
        /// <param name="num">number to be checked</param>
        /// <returns>True if num is a palindrome, false otherwise. </returns>
        public static Boolean IsPalindrome(long num) {
            String s = Convert.ToString(num);
            return s.Equals(Reverse(s)) ? true:false;
        }


        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}
