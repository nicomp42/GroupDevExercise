using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupDevExercise
{
    abstract class TestBehavior : ITestBehavior
    {
        // Pass the buck to the derived classes
        abstract public Boolean Test(Boolean verbose);
    }
}
