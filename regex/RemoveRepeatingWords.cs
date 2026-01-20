// 14. Find Repeating Words in a Sentence
// Example Input: "This is is a repeated repeated word test."
// Expected Output:
// ● is, repeated

using System;

namespace CSharp_Advance_Programming.regex
{
    internal class RemoveRepeatingWords
    {
        internal static void Execute(string input)
        {
            string pattern = @"\b(\w+)\b(?=.*\b\1\b)";

            MatchCollection matches =
                Regex.Matches(input, pattern, RegexOptions.IgnoreCase);

            HashSet<string> repeatingWords = new HashSet<string>();

            foreach (Match m in matches)
            {
                repeatingWords.Add(m.Value.ToLower());
            }

            Console.WriteLine("Repeating words:");

            foreach (var word in repeatingWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}