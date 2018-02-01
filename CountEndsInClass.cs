/*****************************************
 * C# / VS in-class group development exercise
 * Posted on GitHub
 * Bill Nicholson and students
 * nicholdw@ucmail.uc.edu
 * ***************************************/
using System;
using System.Collections.Generic;

namespace GroupDevExercise {
    class CountEndsInClass : TestBehavior {




        /// <summary>
        /// Test the CountEndsIn method
        /// </summary>
        /// <param name="verbose">True if the method should print test results as they are processed</param>
        /// <returns>true if all tests passed, false otherwise.</returns>
        override public Boolean Test(Boolean verbose) {
            List<long> numberList = new List<long>();
            numberList.Add(524);
            numberList.Add(2440);
            numberList.Add(53646343474363663);
            numberList.Add(0);
            numberList.Add(1);
            numberList.Add(53623733643535);
            numberList.Add(99);
            numberList.Add(-53646343474363663);
            numberList.Add(11);
            numberList.Add(234);
            numberList.Add(9223372036854775807);
            numberList.Add(-9223372036854775808);

            List<bool> testResults = new List<bool>();

            testResults.Add(CountEndsIn(numberList, 4) == 2);
            testResults.Add(CountEndsIn(numberList, 3) == 2);
            testResults.Add(CountEndsIn(numberList, 0) == 2);
            testResults.Add(CountEndsIn(numberList, 1) == 2);
            testResults.Add(CountEndsIn(numberList, 5) == 1);
            testResults.Add(CountEndsIn(numberList, 9) == 1);
            testResults.Add(CountEndsIn(numberList, 2) == 0);
            testResults.Add(CountEndsIn(numberList, 7) == 1);
            testResults.Add(CountEndsIn(numberList, 8) == 1);

            return !testResults.Contains(false);
        }


        /// <summary>
        /// Count the number of integers in a list that end in a particular digit
        /// </summary>
        /// <param name="list">the list of numbers</param>
        /// <param name="digit">the digit to check for</param>
        /// <returns>the count of numbers in list that end in digit</returns>
        public static long CountEndsIn(List<long> list, int digit) {
            int count = 0;
            foreach (long num in list)
            {
                if (NumberEndsInClass.NumberEndsIn(num, digit))
                    count++;
            }
            return count;
        }
    }
}
