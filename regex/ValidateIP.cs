// Advanced Problems
// 10. Validate an IP Address
// A valid IPv4 address consists of four groups of numbers (0-255) separated by
// dots.
// 11. Validate a Credit Card Number (Visa, MasterCard, etc.)
// ● A Visa card number starts with 4 and has 16 digits.
// ● A MasterCard starts with 5 and has 16 digits.

using System;
using System.Text.RegularExpressions;

namespace CSharp_Advance_Programming.regex
{
    internal class ValidateIP
    {
        internal static void Validate(string input)
        {
            string pattern = @"^(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\."
                            + @"(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\."
                            + @"(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\."
                            + @"(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)$";

            bool isValid = Regex.IsMatch(input, pattern);

        Console.WriteLine(isValid
            ? "Valid IPv4 Address"
            : "Invalid IPv4 Address");
        }
    }
}