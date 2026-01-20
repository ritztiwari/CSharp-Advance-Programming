// 9. Censor Bad Words in a Sentence
// Given a list of bad words, replace them with ****.
// Example Input: "This is a damn bad example with some stupid words."
// Expected Output: "This is a **** bad example with some **** words."

using System;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace CSharp_Advance_Programming.regex
{
    internal class CensorBadWord
    {
        internal static void Execute(string input)
        {
            string pattern = @"\b(bad|damn|stupid|idiot)\b";

            string result = Regex.Replace(input, pattern, "****",
                                    RegexOptions.IgnoreCase);

            Console.WriteLine(result);
        }
    }
}