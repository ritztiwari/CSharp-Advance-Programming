
namespace CSharp_Advance_Programming.NUnit.StringUtils
{
    internal class StringUtils
    {
        internal string Reverse(string s)
        {
            if(s == null)
            {
                return null;
            }

            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        internal bool IsPalindrome(string s)
        {
            if(s == null)
            {
                return true;
            }

            int start = 0;
            int end = s.Length - 1;

            while(start < end)
            {
                if(s[start++] != s[end--])
                {
                    return false;
                }
            }

            return true;
        }

        internal string ToUpperCase(string s)
        {
            if(s == null)
            {
                return "";
            }

            return s.ToUpper();
        }
    }
}