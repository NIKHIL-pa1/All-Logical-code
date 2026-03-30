using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_snippets.QuickQuestion
{
    public class Logical_Snippet1
    {
        public void Get()
        {
            int x = 5;
            int y = x;

            y = 10;

            Console.WriteLine(x);
            Console.WriteLine(y);

            List<int> L1 = new List<int>() { 1, 2 };
            List<int> L2 = L1;
            L2.Add(3);


            Console.WriteLine(string.Join(",",L2));

        }
    }
}
