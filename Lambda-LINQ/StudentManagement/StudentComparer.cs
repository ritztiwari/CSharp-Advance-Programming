using System;

namespace CSharp_Advance_Programming.Lambda_LINQ.StudentManagement
{
    internal class StudentComparer : IComparer<Student>
    {
        public int Compare(Student s1, Student s2)
        {
            // 1️⃣ Sort by marks (Descending)
            int markComparison = s2.marks.CompareTo(s1.marks);

            if (markComparison != 0)
                return markComparison;

            // 2️⃣ If marks are equal → Sort by Name (Ascending)
            return s1.name.CompareTo(s2.name);
        }
    }
}
