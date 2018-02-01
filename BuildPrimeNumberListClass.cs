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
        /// <remarks>Matt and Ryan</remarks>
        override public Boolean Test(Boolean verbose) {

            Boolean testbool = false;
            int count = 1000;
            List<long> primeNumberList;
            primeNumberList = new List<long>();

            BuildPrimeNumberList(primeNumberList, count);

            if (primeNumberList[0] == 2 && primeNumberList[1] == 3 && primeNumberList[2] == 5 && 
                primeNumberList[3] == 7 && primeNumberList[4] == 11 && primeNumberList[4] == 176) {
                testbool = true;
            }
            else {
                testbool = false;
            }


            if (primeNumberList.Count > 10) {
                testbool = true;
            }

            else {
                testbool = false;
            }


            return testbool;
        }

    /// <summary>
    /// Build a list of prime numbers.
    /// This method will clear the list before adding anything to it.
    /// </summary>
    /// <param name="primeNumberList">Where to build the list</param>
    /// <param name="length">The number of primes to be added to the list, first number must always be 2</param>
    /// <remarks>Matt and Ryan</remarks>
    public static void BuildPrimeNumberList(List<long> primeNumberList, int length) {
            long num = 2;
            int count = 0;
            for (int i = 0; i < length; i++) {
                if (IsPrimeClass.IsPrime(num) == true) {

                    primeNumberList.Add(num);

                    //Console.WriteLine(primeNumberList[count]);
                    count++;

                }

                num++;

            }
        }
    }
}
