using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class FindDuplicates
    {
        static void Main(string[] args)
        {
            //RemoveDuplicatesWithLinQ();
            //DuplicatesEle();
            RemoveDuplicates();
        }

        static public void DuplicatesEle()
        {
            int[] arr = { 1, 2, 3, 2, 4, 1 };

            List<int> list = new List<int>();
            HashSet<int> set = new HashSet<int>();

            foreach (int i in arr)
            {
                if (set.Add(i))
                    list.Add(i);
            }
            Console.WriteLine(list);
        }

        static public void RemoveDuplicatesWithLinQ()
        {
            int[] arr = { 1, 2, 3, 2, 4, 1 };
            // int[] EmptyIntArray = Array.Empty<int>();
            //int[] emptyInt = new int[0];
            //int cout = 1;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {

            //    }
            //}

            var ans = arr.Distinct().ToList();

            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }

        }

        static void RemoveDuplicates()
        {
            int[] arr = { 1, 2, 3, 2, 4, 1 };
            List<int> temp = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    temp.Add(arr[i]);
                }


            }
            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }


        }
    }
}
