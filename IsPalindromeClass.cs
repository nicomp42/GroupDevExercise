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
            return false;
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
