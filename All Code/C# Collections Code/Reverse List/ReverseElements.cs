using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse_List
{
    public class ReverseElements
    {
        static void Main(string[] args)
        {
            //getRev();
            //ReverseString obj = new ReverseString();
            //obj.getRevString();
            ReversetringWithStack obj1 = new ReversetringWithStack();
            obj1.ReverseStrByStack();


        }
        static void getRev()
        {
            List<int> list = new() { 1, 2, 3, 4 };

            List<int> rev = new();

            for (int i = list.Count - 1; i >= 0; i--)
                rev.Add(list[i]);
            foreach (int i in rev)
                Console.WriteLine(i);
        }
    }
}
