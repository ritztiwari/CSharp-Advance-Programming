// 15. Validate a Social Security Number (SSN)
// Example Input: "My SSN is 123-45-6789."
// Expected Output:
// ● ✅ "123-45-6789" is valid
// ● ❌ "123456789" is invalid

using System;
using System.Text.RegularExpressions;

namespace CSharp_Advance_Programming.regex
{
    internal class ExtractSSN
    {
        internal static void Extract(string input)
        {
            string pattern = @"(\d{3})-(\d{3})-(\d{4})";

            if (Regex.IsMatch(input, pattern))
            {
                System.Console.WriteLine("Valid SSN number");
            }
            else
            {
                System.Console.WriteLine("Invalid SSN number");
            }
        }
    }
}
