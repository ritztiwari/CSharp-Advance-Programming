// 11. Validate a Credit Card Number (Visa, MasterCard, etc.)
// ● A Visa card number starts with 4 and has 16 digits.
// ● A MasterCard starts with 5 and has 16 digits.

using System;
using System.Text.RegularExpressions;

namespace CSharp_Advance_Programming.regex
{
    internal class ValidateCard
    {
        internal static void Validate(string card)
        {
            string visaPattern = @"^4\d{15}$";
            string masterPattern = @"^5\d{15}$";

            if (Regex.IsMatch(card, visaPattern))
            {
                Console.WriteLine("Valid Visa Card");
            }
            else if (Regex.IsMatch(card, masterPattern))
            {
                Console.WriteLine("Valid MasterCard");
            }
            else
            {
                Console.WriteLine("Invalid Card");
            }
        }
    }
}