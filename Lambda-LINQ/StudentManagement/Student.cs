// 7️⃣ Sorting + Comparer + OOP
// Q7: Student Sorting Without LINQ
// Create a Student class:
// RollNo
// Name
// Marks
// Task:
// Store students in a List<Student>.
// Sort:
// First by marks (descending)
// If tie → Name (ascending)
// Print sorted list.
// Use IComparer<Student> or lambda.

using System;

namespace CSharp_Advance_Programming.Lambda_LINQ.StudentManagement
{
    internal class Student
    {
        public int rollNo { get; set; }

        public string name { get; set; }

        public int marks { get; set; }

        public Student(int rollNo, string name, int marks)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.marks = marks;
        }

        public override string ToString()
        {
            return $"RollNo: {rollNo}, Name: {name}, Marks: {marks}";
        }
    }

}