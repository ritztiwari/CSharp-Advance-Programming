// 2. Validate a License Plate Number
// License plate format: Starts with two uppercase letters, followed by four digits.
// Example: "AB1234" is valid, but "A12345" is invalid.

using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace CSharp_Advance_Programming.regex
{
    internal class LicensePlate
    {
        internal static bool Validate(string s)
        {
            string pattern = @"[A-Z]{2}[0-9]{4}";

            if (Regex.IsMatch(s, pattern))
            {
                return true;
            }

            return false;
        }
    }
}