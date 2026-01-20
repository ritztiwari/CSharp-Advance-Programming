using System;
using System.Threading.Tasks;

namespace CSharp_Advance_Programming.NUnit.PerformanceTest
{
    internal class Performance
    {
        internal string TimeDelay()
        {
            Thread.Sleep(3000);

            return "Done";
        }
    }
}