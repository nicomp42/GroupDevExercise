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
            Console.WriteLine("IsPrime method "                           + (new IsPrimeClass().Test(false) == true                           ? "passed all tests" : "DID NOT pass all tests"));
            Console.WriteLine("IsPalindrome method "                      + (new IsPalindromeClass().Test(false) == true                      ? "passed all tests" : "DID NOT pass all tests"));
            Console.WriteLine("NumberEndsIn method "                      + (new NumberEndsInClass().Test(false) == true                      ? "passed all tests" : "DID NOT pass all tests"));
            Console.WriteLine("CountPalindromesWhereBothArePrime method " + (new CountPalindromesWhereBothArePrimeClass().Test(false) == true ? "passed all tests" : "DID NOT pass all tests"));
            Console.WriteLine("CountSumOfDigitsIsPrime method "           + (new CountSumOfDigitsIsPrimeClass().Test(false) == true           ? "passed all tests" : "DID NOT pass all tests"));
            Console.WriteLine("BuildPrimeNumberList method "              + (new BuildPrimeNumberListClass().Test(false) == true              ? "passed all tests" : "DID NOT pass all tests"));
            Console.WriteLine("CountEndsIn method "                       + (new CountEndsInClass().Test(false) == true                       ? "passed all tests" : "DID NOT pass all tests"));
            Console.WriteLine("CountPalindromes method "                  + (new CountPalindromesClass().Test(false) == true                  ? "passed all tests" : "DID NOT pass all tests"));
            Console.WriteLine("CountPalindromesWhereBothArePrime method " + (new CountPalindromesWhereBothArePrimeClass().Test(false) == true ? "passed all tests" : "DID NOT pass all tests"));
            /***********************************************************************/

            int count = 1000;   // The number of prime numbers we will work with in this method

            List<long> primeNumberList;
            primeNumberList = new List<long>();

            BuildPrimeNumberListClass.BuildPrimeNumberList(primeNumberList, count);

            Console.WriteLine("In the first " + count + " prime numbers...");
            Console.WriteLine(CountEndsInClass.CountEndsIn(primeNumberList, 1) + " end in 1");
            Console.WriteLine(CountEndsInClass.CountEndsIn(primeNumberList, 3) + " end in 3");
            Console.WriteLine(CountEndsInClass.CountEndsIn(primeNumberList, 7) + " end in 7");
            Console.WriteLine(CountEndsInClass.CountEndsIn(primeNumberList, 9) + " end in 9");
            Console.WriteLine(CountPalindromesClass.CountPalindromes(primeNumberList) + " are palindromes.");
            Console.WriteLine(CountPalindromesWhereBothArePrimeClass.CountPalindromesWhereBothArePrime(primeNumberList) + " are palindromes and the palindrome is also prime");
            Console.WriteLine(CountSumOfDigitsIsPrimeClass.CountSumOfDigitsIsPrime(primeNumberList) + " result in a prime when their digits are summed.");
        }
    }
}
