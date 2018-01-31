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
    /// The test rig for all our processing 
    /// </summary>
    class Program {
        static void Main(string[] args) {
            /************************* Test the methods ****************************/
            Console.WriteLine("isPrime method "                           + (IsPrimeClass.Test(false) == true                           ? " passed all tests" : " DID NOT pass all tests"));
            Console.WriteLine("CountPalindromesWhereBothArePrime method " + (CountPalindromesWhereBothArePrimeClass.Test(false) == true ? " passed all tests" : " DID NOT pass all tests"));
            Console.WriteLine("BuildPrimeNumberList method "              + (BuildPrimeNumberListClass.Test(false) == true              ? " passed all tests" : " DID NOT pass all tests"));
            Console.WriteLine("CountEndsIn method "                       + (CountEndsInClass.Test(false) == true                       ? " passed all tests" : " DID NOT pass all tests"));
            Console.WriteLine("CountPalindromes method "                  + (CountPalindromesClass.Test(false) == true                  ? " passed all tests" : " DID NOT pass all tests"));
            Console.WriteLine("CountPalindromesWhereBothArePrime method " + (CountPalindromesWhereBothArePrimeClass.Test(false) == true ? " passed all tests" : " DID NOT pass all tests"));
            /***********************************************************************/

            int count = 1000;   // The number of prime numbers we will work with in this method

            List<long> primeNumberList;
            primeNumberList = new List<long>();

            BuildPrimeNumberListClass.BuildPrimeNumberList(primeNumberList, count);

            Console.WriteLine("In the first " + count + " prime numbers...");
            Console.WriteLine(CountEndsInClass.CountEndsIn(primeNumberList, 1) + " end in 1");
            Console.WriteLine(CountEndsInClass.CountEndsIn(primeNumberList, 3) + " end in 3");
            Console.WriteLine(CountEndsInClass.CountEndsIn(primeNumberList, 7) + " end in 7");

            Console.WriteLine(CountPalindromesClass.CountPalindromes(primeNumberList) + " are palindromes.");

            Console.WriteLine(CountPalindromesWhereBothArePrimeClass.CountPalindromesWhereBothArePrime(primeNumberList) + " are palindromes and the palindrome is also prime");



        }
    }
}
