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
    /// Build a list of prime numbers
    /// </summary>
    class BuildPrimeNumberListClass : TestBehavior {

        /// <summary>
        /// Test the BuildPrimeNumberList method
        /// </summary>
        /// <param name="verbose">True if the method should print test results as they are processed</param>
        /// <returns>true if all tests passed, false otherwise.</returns>
        override public Boolean Test(Boolean verbose) {
            return false;
        }


        /// <summary>
        /// Build a list of prime numbers.
        /// This method will clear the list before adding anything to it.
        /// </summary>
        /// <param name="primeNumberList">Where to build the list</param>
        /// <param name="length">The number of primes to be added to the list, first number must always be 2</param>
        public static void BuildPrimeNumberList(List<long> primeNumberList, int length) {
            long num = 2;
            for (int i = 0; i < length; i++) {
                if (IsPrimeClass.IsPrime(num)) { primeNumberList.Add(num); }
                num++;
            }
        }
    }
}
