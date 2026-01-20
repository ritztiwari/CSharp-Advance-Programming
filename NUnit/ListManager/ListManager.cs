using System;

namespace CSharp_Advance_Programming.NUnit.ListManager
{
    internal class ListManager
    {
        internal void AddElement(List<int> list,int element)
        {
            list.Add(element);
        }
        internal void RemoveElement(List<int> list,int element)
        {
            list.Remove(element);
        }
        internal int GetSize(List<int> list)
        {
            return list.Count();
        }
    }
}