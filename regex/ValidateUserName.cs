// 1. Validate a Username
// A valid username:
// ● Can only contain letters (a-z, A-Z), numbers (0-9), and underscores (_)
// ● Must start with a letter
// ● Must be between 5 to 15 characters long

using System;
using System.Text.RegularExpressions;

namespace CSharp_Advance_Programming.regex
{
    internal class ValidateUserName
    {
        internal static bool Validate(string s)
        {
            string pattern = @"[a-z][A-Z][0-9]{5-15}";

            if(Regex.IsMatch(s, pattern)){
                return true;
            }
            
            return false;
        }
    }
}