// 13. Extract Currency Values from a Text
// Example Text: "The price is $45.99, and the discount is $ 10.50."
// Expected Output:
// ● $45.99, 10.50

using System;
using System.Text.RegularExpressions;

namespace CSharp_Advance_Programming.regex
{
    internal class ExtractCurrencyValue
    {
        internal static void Extract(string input)
        {
            string pattern = @"\$\s*(\d[\d,]*(?:\.\d{1,2})?)";

            MatchCollection matches = Regex.Matches(input, pattern);

            Console.WriteLine("Extracted currency values:");

            foreach (Match m in matches)
            {
                Console.WriteLine(m.Groups[1].Value);
            }
        }
    }
}