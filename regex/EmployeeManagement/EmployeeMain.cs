using System;

namespace CSharp_Advance_Programming.regex.EmployeeManagement
{
    internal class EmployeeMain
    {
        internal static void Execute()
        {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Amit", Department = "IT",
                Email = "amit@gmail.com", JoiningDate = DateTime.Now.AddMonths(-2) },

            new Employee { Id = 2, Name = "Rahul", Department = "HR",
                Email = "rahul@company.com", JoiningDate = DateTime.Now.AddMonths(-8) },

            new Employee { Id = 3, Name = "Neha", Department = "IT",
                Email = "neha_it@org.com", JoiningDate = DateTime.Now.AddMonths(-5) },

            new Employee { Id = 4, Name = "Priya", Department = "Finance",
                Email = "invalid-email", JoiningDate = DateTime.Now.AddMonths(-3) }
        };

        Console.WriteLine("Validating Emails...\n");

        foreach (var emp in employees)
        {
            if (!Employee.IsValidEmail(emp.Email))
            {
                Console.WriteLine($"Invalid Email Found: {emp.Name} -> {emp.Email}");
            }
        }

        Console.WriteLine("\nEmployees who joined in last 6 months AND belong to IT:\n");

        DateTime sixMonthsAgo = DateTime.Now.AddMonths(-6);

        foreach (var emp in employees)
        {
            if (emp.JoiningDate >= sixMonthsAgo && emp.Department == "IT")
            {
                Console.WriteLine(emp);
            }
        }
        }
    }
}