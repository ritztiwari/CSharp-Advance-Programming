using System;
using System.Text.RegularExpressions;

namespace CSharp_Advance_Programming.NUnit.PasswordValidator
{
    internal class PasswordChecker
    {
    public bool IsStrongPassword(string password)
    {
        if (string.IsNullOrEmpty(password))
            return false;

        // At least 8 characters
        if (password.Length < 8)
            return false;

        // At least one uppercase letter
        bool hasUpper = Regex.IsMatch(password, "[A-Z]");

        // At least one digit
        bool hasDigit = Regex.IsMatch(password, "[0-9]");

        return hasUpper && hasDigit;
    }
    }
}