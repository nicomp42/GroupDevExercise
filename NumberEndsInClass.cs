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
    /// <summary>
    /// Check a number to see if it ends in a particular digit
    /// </summary>
    class NumberEndsInClass : TestBehavior
    {

        /// <summary>
        /// Test the numberEndsIn method
        /// </summary>
        /// <param name="verbose">True if the method should print test results as they are processed</param>
        /// <returns>true if all tests passed, false otherwise.</returns>
        override public Boolean Test(Boolean verbose)
        {
            List<bool> testResults = new List<bool>();

            testResults.Add(NumberEndsIn(56325, 4) == false);
            testResults.Add(NumberEndsIn(753224, 4) == true);
            testResults.Add(NumberEndsIn(1, 4) == false);
            testResults.Add(NumberEndsIn(0, 0) == true);
            testResults.Add(NumberEndsIn(9223372036854775807, 7));
            testResults.Add(NumberEndsIn(-9223372036854775808, 8));
            testResults.Add(NumberEndsIn(-56325, 5) == true);
            testResults.Add(NumberEndsIn(2350, 0) == true);
            testResults.Add(NumberEndsIn(84, 4) == true);

            return !testResults.Contains(false);
        }

        /// <summary>
        /// Check to see if an integer ends in a particular digit
        /// </summary>
        /// <param name="num">the integer to check</param>
        /// <param name="end">the digit to check for</param>
        /// <returns>True if num ends in digit, false otherwise</returns>
        public static Boolean NumberEndsIn(long num, int digit)
        {
            if(num == long.MinValue)
            {
                if (digit == 8)
                    return true;
                else
                    return false;
            }
            num = Math.Abs(num);
            return num % 10 == digit;
        }
    }
}
