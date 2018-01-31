/*****************************************
 * C# / VS in-class group development exercise
 * Posted on GitHub
 * Bill Nicholson and students
 * nicholdw@ucmail.uc.edu
 * ***************************************/

using System;

namespace GroupDevExercise
{
    /// <summary>
    /// Test the method
    /// </summary>
    /// <param name="verbose">True if the method should print test results as they are processed</param>
    /// <returns>true if all tests passed, false otherwise.</returns>
    interface ITestBehavior
    {
        Boolean Test(Boolean verbose);
    }
}
