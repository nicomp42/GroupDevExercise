﻿/*****************************************
 * C# / VS in-class group development exercise
 * Posted on GitHub
 * Bill Nicholson and students
 * nicholdw@ucmail.uc.edu
 * ***************************************/

using System;

namespace GroupDevExercise {
    /// <summary>
    /// Check a number to see if it ends in a particular digit
    /// </summary>
    class NumberEndsInClass : TestBehavior {

        /// <summary>
        /// Test the numberEndsIn method
        /// </summary>
        /// <param name="verbose">True if the method should print test results as they are processed</param>
        /// <returns>true if all tests passed, false otherwise.</returns>
        override public Boolean Test(Boolean verbose) {
            return false;
        }

        /// <summary>
        /// Check to see if an integer ends in a particular digit
        /// </summary>
        /// <param name="num">the integer to check</param>
        /// <param name="end">the digit to check for</param>
        /// <returns>True if num ends in digit, false otherwise</returns>
        public static Boolean NumberEndsIn(long num, int digit) {
            int tmpDigit =  (int)(num - ((num / 10) * 10)); 
            return tmpDigit == digit ? true: false;
        }
    }
}
