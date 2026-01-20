// 3. Validate a Hex Color Code
// A valid hex color:
// ● Starts with a #
// ● Followed by 6 hexadecimal characters (0-9, A-F, a-f).
// Example Inputs & Outputs:

// ● ✅ "#FFA500" → Valid
// ● ✅ "#ff4500" → Valid
// ● ❌ "#123" → Invalid (too short)

using System;
using System.Text.RegularExpressions;

namespace CSharp_Advance_Programming.regex
{
    internal class HexColorCode
    {
        internal static bool Validate(string s)
        {
            string pattern = @"[#][a-zA-Z0-9]{6}";

            if (Regex.IsMatch(s,pattern))
            {
                return true;
            }

            return false;
        }
    }
}