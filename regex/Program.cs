using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using CSharp_Advance_Programming.regex.EmployeeManagement;

namespace CSharp_Advance_Programming.regex
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            // EmployeeMain.Execute();

            // string s = Console.ReadLine() ?? "";

            // Console.WriteLine(ValidateUserName.Validate(s));

            // string s = Console.ReadLine() ?? "";

            // Console.WriteLine(LicensePlate.Validate(s));

            // string s = Console.ReadLine() ?? "";

            // Console.WriteLine(HexColorCode.Validate(s));

            // string s = "contact us at support@example.cs and info@company.org";

            // ExtractEmail.Validate(s);
            
            // string s = "This is Rishabh Kumar Tiwari son Of Bipin Tiwari";

            // ExtractCapitalWords.Extract(s);

            // string input = 
            // "The event is on 12/05/2024 and the deadline is 30/11/2023. " +
            // "Invalid dates like 99/99/2022 or 12-05-2024 should not match.";

            // ExtractDate.Extract(input);

            // string input = 
            // "Visit https://www.google.com and http://example.com. " +
            // "Also check https://github.com/rishabh and www.microsoft.com for more info.";

            // ExtractLinks.Extract(input);

            // string input = "    hello   world!  ";

            // RemoveSpaces.Remove(input);

            // string input = "This is an damn bad example with some stupid words.";

            // CensorBadWord.Execute(input);

            // string ip = "255.125.145.120";

            // ValidateIP.Validate(ip);

            // string input = Console.ReadLine() ?? "";

            // ValidateCard.Validate(input);

            // string s = "I love Java,Python and JavaScript,but i haven't tried Go Yet.";

            // ExtractProgrammingNames.Extract(s);

            // string s = "i do own $50.12 and $ 54.15.";

            // ExtractCurrencyValue.Extract(s);

            // string s = Console.ReadLine() ?? "";

            // ExtractSSN.Extract(s);

            string input = "This is is a repeated repeated word test.";

            RemoveRepeatingWords.Execute(input);
        }
    }
}