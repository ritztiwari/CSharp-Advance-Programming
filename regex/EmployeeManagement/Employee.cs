// 1️⃣ OOP + Collections + Filtering + Regex
// Q1: Employee Filtering Without LINQ
// Create an Employee class with:
// Id
// Name
// Department
// Email
// JoiningDate
// Task:
// Validate Email using Regex.
// Store employees in List<Employee>.
// Without using LINQ, filter employees:
// Who joined in the last 6 months
// Whose Department = “IT”
// Display the filtered list.
// Use only loops and conditions.


using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CSharp_Advance_Programming.regex.EmployeeManagement
{
    internal class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public string Email { get; set; }
    public DateTime JoiningDate { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Dept: {Department}, Email: {Email}, Joining: {JoiningDate.ToShortDateString()}";
    }

    public static bool IsValidEmail(string email)
    {
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        if(Regex.IsMatch(email, pattern))
            {
                return true;
            }
        return false;
    }
}
}