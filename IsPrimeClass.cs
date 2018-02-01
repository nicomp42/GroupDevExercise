/*****************************************
 * C# / VS in-class group development exercise
 * Posted on GitHub
 * Bill Nicholson and students
 * nicholdw@ucmail.uc.edu
 * ***************************************/

using System;

namespace GroupDevExercise {
    /// <summary>
    /// Check to see if a number is prime
    /// Ryand and Matt did this.
    /// </summary>
    class IsPrimeClass : TestBehavior {

        /// <summary>
        /// Test the IsPrime method
        /// </summary>
        /// <param name="verbose">True if the method should print test results as they are processed</param>
        /// <returns>true if all tests passed, false otherwise.</returns>
        override public Boolean Test(Boolean verbose) {

            if (IsPrime(15485863) == true && IsPrime(2) == true && IsPrime(130) == false) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Check an integer for primeness.
        /// Notes: 1 is neither prime nor non-prime. 2 is prime.
        /// </summary>
        /// <param name="num">The number to be checked. Assumed to be > 1.</param>
        /// <returns>True if num is prime, false otherwise</returns>
        public static Boolean IsPrime(long num) {

            Boolean primeStatus = true;
            for (int i = 2; i <= Math.Sqrt(num); i++) {

                if (num == 1 || num == 0 || num < 0) { return false;  }
                if ((num % i) == 0) { return false; }

            }

            return primeStatus;
        }
    }
}
