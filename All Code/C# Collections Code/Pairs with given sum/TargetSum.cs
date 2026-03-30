using System;
using System.Collections.Generic;
using System.Text;

namespace Pairs_with_given_sum
{
    public class TargetSum
    {
        static void Main(string[] args)
        {
            FindSumPair();
            WithoptimizeSol();
        }
        static void FindSumPair()
        {

            List<int> list = new() { 1, 5, 7, -1, 5, 2, 3, 4 };

            //int[] arr = { 1, 5, 7, -1, 5 };

            int target  = 6;

            for(int i = 0; i < list.Count; i++)
            {
                for(int j = i+1; j < list.Count; j++)
                {
                    if(list[i] + list[j] == target)
                        Console.WriteLine($"{list[i]},{list[j]}");
                }
            }
            Console.WriteLine("====================");

            for(int i = 0; i < list.Count; i++)
            {
                for(int j = 1; j < list.Count; j++)
                {
                    if(list[i] + list[j] == target)
                        Console.WriteLine($"{list[i]},{list[j]}");
                }
            }
            Console.WriteLine("====================");
        }

        static void WithoptimizeSol()
        {
            int[] arr = { 1, 5, 7, -1, 5, 2, 3, 4 };

            int Target = 6;

            HashSet<int> set = new HashSet<int>();

            foreach(int item in arr)
            {
                int need = Target - item;

                if(set.Contains(need))
                    Console.WriteLine($"({need},{item})");

                set.Add(item);

            }

          
        }
    }
}
