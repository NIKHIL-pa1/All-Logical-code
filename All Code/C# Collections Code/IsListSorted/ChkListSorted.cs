using System;
using System.Collections.Generic;
using System.Text;

namespace IsListSorted
{
    public class ChkListSorted
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 4,3 };
            Console.WriteLine(IsListSorted(list)); 
        }
        static bool IsListSorted(List<int> list)
        {

            for (int i = 0; i < list.Count-1; i++)
            {
                if (list[i] > list[i + 1])
                    return false;
            }
            return true;
        }
    }
}
