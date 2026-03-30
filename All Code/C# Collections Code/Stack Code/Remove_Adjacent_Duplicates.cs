using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Code
{
    public class Remove_Adjacent_Duplicates
    {
        public void Remove_Adjacent_Duplicate()
        {
            string str = "abbaca";

            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                if (stack.Count > 0 && stack.Peek() == c)
                    stack.Pop();
                else
                {
                    stack.Push(c);
                    // Console.WriteLine(c);
                }
            }

            char[] ch = stack.ToArray();
            StringBuilder strbuild = new StringBuilder();
            for (int i = ch.Length - 1; i >= 0; i--)
            {
                strbuild.Append(ch[i]);

            }
            Console.WriteLine(strbuild.ToString());
        }

        public void Remove_Adjacent_Duplicate_Purelogic()
        {
            string str = "abbaca";

            char[] ch = new char[str.Length];
            int index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if(index > 0 && ch[index -1] == str[i])
                    index--;
                else
                {
                    ch[index] = str[i];
                    index++;
                }
            }
            string finalResult = new string(ch, 0, index);
            Console.WriteLine(finalResult);
        }
    }
}
