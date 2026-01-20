// Replace and Modify Strings
// 8. Replace Multiple Spaces with a Single Space
// Example Input: "This is an example with multiple spaces."
// Expected Output: "This is an example with multiple spaces."

using System;
using System.Text.RegularExpressions;

namespace CSharp_Advance_Programming.regex
{
    internal class RemoveSpaces
    {
        internal static void Remove(string input)
        {
            string result = Regex.Replace(input, @"\s+", " ");

            Console.WriteLine(result);
        }
    }
}