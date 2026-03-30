using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse_List
{
    public class ReverseString
    {
        public void getRevString()
        {
            string str = "Hellow";

            string ans = string.Empty;
            string res = str.ToLower();
           
            for (int i = str.Length-1; i >= 0; i--)
            {
                ans += res[i];
            }
            Console.WriteLine(ans);
        }
    }
}
