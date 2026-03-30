using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveEvenNo
{
    public class RemoveEvenFromList
    {
        static void Main(string[] args)
        {
            RemoveEvenEle();
        }
        static void RemoveEvenEle()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6 };

            List<int> remove = new List<int>();
    
            foreach (var item in list)
            {
                if (item % 2 != 0)
                    remove.Add(item);
            }
            foreach (var item in remove)
                Console.WriteLine(item);

        }
    }
}
