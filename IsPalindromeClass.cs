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
            if (IsPalindrome(20 * 10 + 2) == true && IsPalindrome(20 * 10 - 2) == false &&
                IsPalindrome(10 ^ 11 + 1) == true && IsPalindrome(10 ^ 11 - 1) == true &&
                IsPalindrome(0) == true && IsPalindrome(-1) == false &&
                IsPalindrome(-74201210247) == false && IsPalindrome(4282018102824 * 2) == false
                )
            {
                return true;
            }
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
