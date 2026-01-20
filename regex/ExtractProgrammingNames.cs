// 12. Extract Programming Language Names from a Text
// Example Text: "I love Java, Python, and JavaScript, but I haven't tried Go yet."
// Expected Output:
// ● Java, Python, JavaScript, Go

using System;
using System.Text.RegularExpressions;

namespace CSharp_Advance_Programming.regex
{
    internal class ExtractProgrammingNames
    {
        internal static void Extract(string input)
        {
            string pattern = @"\b(Java|Python|JavaScript|Go)\b";

            MatchCollection matches = Regex.Matches(input,pattern);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}