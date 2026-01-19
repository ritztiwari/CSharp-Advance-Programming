using System;

namespace CSharp_Advance_Programming.Lambda_LINQ.EmployeeManagement
{
    internal class EmployeeMain
    {
        internal static void Exexute()
        {
            Employee e = new Employee();

            List<Employee> employees = new List<Employee>{
                new Employee("rishabh","IT",DateTime.Now),
                new Employee("hardik","IT",DateTime.Now.AddMonths(-8)),
                new Employee("uday","HR",DateTime.Now.AddMonths(-7))
                };

                string targetDept = "IT";
                DateTime currentDate = DateTime.Now.AddMonths(-6);

                var experienced = employees.
                                Where(e => e.date >= currentDate && e.dept == targetDept)
                                .ToList();

                foreach (var item in experienced)
                {
                    e.Display(item);
                }
        }
    }
}