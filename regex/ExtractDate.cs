// 6. Extract Dates in dd/mm/yyyy Format
// Example Text: "The events are scheduled for 12/05/2023, 15/08/2024, and
// 29/02/2020."

using System;
using System.Text.RegularExpressions;

namespace CSharp_Advance_Programming.regex
{
    internal class ExtractDate
    {
        internal static void Extract(string input)
        {
            string pattern = @"\b(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\d{4}\b";

            MatchCollection matches = Regex.Matches(input, pattern);

            List<string> dates = new List<string>();

            foreach (Match m in matches)
            {
                dates.Add(m.Value);
            }

            Console.WriteLine("Extracted Dates:");

            if (dates.Count == 0)
            {
                Console.WriteLine("No valid dates found.");
            }
            else
            {
                foreach (var d in dates)
                {
                    Console.WriteLine(d);
                }
            }
        }
    }
}