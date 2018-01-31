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
    /// </summary>
    class IsPrimeClass : TestBehavior {

        /// <summary>
        /// Test the IsPrime method
        /// </summary>
        /// <param name="verbose">True if the method should print test results as they are processed</param>
        /// <returns>true if all tests passed, false otherwise.</returns>
        override public Boolean Test(Boolean verbose) {
            long[] testCasesNotPrime = new long[] { 4, 6, 100, 999, 1000 };
            long[] testCasesPrime = new long[] { 2, 3, 5, 101 };
            int testsFailed = 0, testsPassed = 0;
            // Run the tests of non-prime numbers
            for (int i = 0; i < testCasesNotPrime.Length; i++)
            {
                if (IsPrime(testCasesNotPrime[i]))
                {
                    if (verbose) { Console.WriteLine(testCasesNotPrime[i] + " is not prime but was reported as prime."); }
                    testsFailed++;
                }
                else { testsPassed++; }
            }
            // Run the tests of prime numbers
            for (int i = 0; i < testCasesPrime.Length; i++)
            {
                if (!IsPrime(testCasesPrime[i]))
                {
                    if (verbose) { Console.WriteLine(testCasesPrime[i] + " is prime but was reported as not prime."); }
                    testsFailed++;
                }
                else { testsPassed++; }
            }
            if (verbose)
            {
                Console.WriteLine(testsFailed + " tests failed.");
                Console.WriteLine(testsPassed + " tests passed.");
            }
            return ((testsFailed > 0) ? false : true);
        }

        /// <summary>
        /// Check an integer for primeness.
        /// Notes: 1 is neither prime nor non-prime. 2 is prime.
        /// </summary>
        /// <param name="num">The number to be checked. Assumed to be > 1.</param>
        /// <returns>True if num is prime, false otherwise</returns>
        public static Boolean IsPrime(long num) {
            long limit = ((long) Math.Sqrt(num)) + 1;
            bool result = true;
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            for (long i = 3; i <= limit; i += 2) {
                if (num % i == 0) { result = false;  break; }
            }
            return result;
        }
    }
}
