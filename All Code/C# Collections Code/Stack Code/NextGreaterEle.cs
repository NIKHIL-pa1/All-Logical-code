using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Code
{
    public class NextGreaterEle
    {
        public void NextGreaterElement()
        {
            int[] arr = { 2, 1, 2, 4, 3 };

            int[] result = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = -1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        result[i] = arr[j];
                        break;
                    }    
                }
            }

            Console.WriteLine(string.Join(",",result));
        }

        public void NextGreaterElementWithStack()
        {
            int[] arr = { 2, 1, 2, 4, 3 };
            int size = arr.Length;
            int[] result = new int[size];

            Stack<int> ch = new Stack<int>();

            for (int i = size-1; i >= 0; i--)
            {
                while(ch.Count>0 && ch.Peek() < arr[i])
                {
                    ch.Pop();
                }

                result[i] = ch.Count == 0 ? -1 : ch.Peek();

                ch.Push(arr[i]);
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
