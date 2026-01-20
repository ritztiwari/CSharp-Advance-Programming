// 5. Extract All Capitalized Words from a Sentence
// Example Text: "The Eiffel Tower is in Paris and the Statue of Liberty is in New
// York."
// Expected Output:
// ● Eiffel, Tower, Paris, Statue, Liberty, New, York

using System;
using System.Text.RegularExpressions;

namespace CSharp_Advance_Programming.regex
{
    internal class ExtractCapitalWords
    {
        internal static void Extract(string s)
        {
            string pattern = @"[A-Z]+[a-zA-Z]{1,}";

            MatchCollection Matches = Regex.Matches(s,pattern);

            List<string> result = new List<string>();

            foreach(Match item in Matches)
            {
                result.Add(item.Value);
            }

            Console.WriteLine("Capital letters");

            foreach(var items in result)
            {
                Console.Write(items+" ");
            }
        }
    }
}