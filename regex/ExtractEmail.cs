// 4. Extract All Email Addresses from a Text
// Example Text: "Contact us at support@example.com and info@company.org"
// Expected Output:
// ● support@example.com
// ● info@company.org

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CSharp_Advance_Programming.regex
{
    internal class ExtractEmail
    {
        internal static void Validate(string s)
        {
            string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";

            MatchCollection matches  = Regex.Matches(s, pattern);

            List<string> emails = new List<string>();

            foreach (Match match in matches)
            {
                emails.Add(match.Value);
            }

            Console.WriteLine("Extracted Emails:");

            if (emails.Count == 0)
            {
                Console.WriteLine("No emails found in the string.");
            }
            else
            {
                foreach (var email in emails)
                {
                    Console.WriteLine(email);
                }
            }
        }
    }
}