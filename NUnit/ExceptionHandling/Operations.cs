using System;

namespace CSharp_Advance_Programming.NUnit.ExceptionHandling
{
    internal class Operations
    {
        internal int Division(int a,int b)
        {
            try
            {
                int c = a/b;
                return c;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

            return -1;
        }
    }
}