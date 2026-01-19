// . Given a collection of objects representing employees with properties like Name, Department, and JoiningDate, use a lambda expression to filter employees who joined in the last six months and are from a specific department.

using System;

namespace CSharp_Advance_Programming.Lambda_LINQ.EmployeeManagement
{
    internal class Employee
    {
        internal string name{get; set;}
        internal string dept{get; set;}

        internal DateTime date{get; set;}

        public Employee()
        {
        }

        public Employee(string name,string dept,DateTime date)
        {
            this.name = name;
            this.date = date;
            this.dept = dept;
        }
        
        internal void Display(Employee item)
        {
            Console.WriteLine($"employee name is: {item.name}\ndepartment name is: {item.dept}\ndate of joining is: {item.date}");
        }
    }
}