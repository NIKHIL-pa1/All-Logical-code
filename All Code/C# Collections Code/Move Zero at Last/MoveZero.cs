using System;
using System.Collections.Generic;
using System.Text;

namespace MoveZeroLast
{
    public class MoveZero
    {
        static void Main(string[] args)
        {
            // ShiftZeroAtLast();
            ShiftZeroAtLastOptimize1();
            //ShiftZeroAtLastOptimize2();
        }

        //TIme complexity O(n)^2
        static void ShiftZeroAtLast()
        {
            int[] arr = { 0, 1, 0, 3, 12 };

            List<int> empty = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                    empty.Add(arr[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    empty.Add(arr[i]);
            }
            foreach (int i in empty)
            {
                Console.WriteLine(i);
            }
        }

        static void ShiftZeroAtLastOptimize1()
        {
            int[] arr = { 0, 1, 0, 2, 12 };

            int position = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    int temp = arr[i];
                    arr[i] = arr[position];
                    arr[position] = temp;
                    position++;

                    //foreach (var item in arr)
                    //{
                    //    Console.WriteLine(item);

                    //}
                    //Console.WriteLine("======="); //for understanding purpose
                }
            }

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        static void ShiftZeroAtLastOptimize2()
        {
            int[] arr = { 0, 1, 0, 3, 12 };

            List<int> list = new();
           
            foreach (int item in arr)
                if (item != 0)
                    list.Add(item);

            while(list.Count < arr.Length)
                list.Add(0);

            foreach (int i in list)
                Console.WriteLine(i);

            

        }
    }
}
