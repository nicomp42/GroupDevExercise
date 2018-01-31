using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
