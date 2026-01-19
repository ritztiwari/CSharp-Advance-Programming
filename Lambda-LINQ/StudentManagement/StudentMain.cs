using System;

namespace CSharp_Advance_Programming.Lambda_LINQ.StudentManagement
{
    internal class StudentMain
    {
        internal static void Execute()
        {
             List<Student> students = new List<Student>
        {
            new Student(1 ,"Amit", 85 ),
            new Student(2 ,"Rahul", 92),
            new Student(3 ,"Neha", 85 ),
            new Student(4 ,"Priya", 92 ),
            new Student(5 ,"Karan", 70)
        };

        // Sort using custom comparer
        students.Sort(new StudentComparer());

        Console.WriteLine("Sorted Students:\n");

        foreach (var s in students)
        {
            Console.WriteLine(s);
        }
        }
    }
}