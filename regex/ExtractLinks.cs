// 7. Extract Links from a Web Page
// Example Text: "Visit https://www.google.com and http://example.org for more
// info."

// Expected Output:
// ● https://www.google.com, http://example.org

using System;
using System.Text.RegularExpressions;

namespace CSharp_Advance_Programming.regex
{
    internal class ExtractLinks
    {
        internal static void Extract(string input)
        {
            string pattern =
            @"\b(?:https?://|www\.)[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}(?:/[^\s]*)?";

        MatchCollection matches = Regex.Matches(input, pattern);

        List<string> links = new List<string>();

        foreach (Match m in matches)
        {
            links.Add(m.Value);
        }

        Console.WriteLine("Extracted Links:");

        if (links.Count == 0)
        {
            Console.WriteLine("No links found.");
        }
        else
        {
            foreach (var link in links)
            {
                Console.WriteLine(link);
            }
        }
        }
    }
}