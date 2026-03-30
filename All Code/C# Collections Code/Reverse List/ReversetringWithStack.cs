using System;
using System.Collections.Generic;
using System.Text;

namespace Reverse_List
{
    public class ReversetringWithStack
    {
      
        public void ReverseStrByStack()
        {
            string str = "Hello";

            string ans = str.ToLower();

            Stack<char> stack =  new Stack<char>();

            foreach (var item in ans)
            {
                stack.Push(item);
            }

            while(stack.Count> 0)
            {
                Console.WriteLine(stack.Pop());
            }
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
