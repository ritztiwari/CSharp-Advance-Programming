// use of a lambda expression within the LINQ OrderBy method to sort a list of strings based on their length in ascending order. The resulting sorted list is then printed to the console.

using System;

namespace CSharp_Advance_Programming.Lambda_LINQ.NamesManagement
{
    internal class Names
    {
        internal static void Execute()
        {
            List<string> words = new List<string>
        {
            "rishabh",
            "uday",
            "hardik",
            "abhinav singh",
            "harshit sarashwat"
        };

            // Sort strings by length in ascending order using a lambda expression
            IEnumerable<string> sortedWords = words.OrderBy(w => w.Length).ToList();

            Console.WriteLine("sorted names based on lenght is");

            foreach (var item in sortedWords)
            {
                Console.WriteLine(item);
            }

        }

    }
}