using System;
using System.Collections.Generic;
using System.Text;

namespace Missing_Num_list
{
    class MissingNumber
    {
        static void Main(string[] args)
        {
            //MisingDigit();
            //WithMinMaxInBuildFunc();
            WithMinMaxManual();
        }

        static void MisingDigit()
        {
            int[] arr = { 8, 2, 3, 7, 1 };
            int n = arr.Length + 1;
            List<int> newArr = new List<int>();
            // Iterate from 1 to n and check
            // if the current number is present
            for (int i = 1; i <= n; i++)
            {
                bool found = false;
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr[j] == i)
                    {
                        found = true;
                        break;
                    }
                }

                // If the current number is not present
                if (!found)
                    newArr.Add(i);// Console.WriteLine(arr);

            }

            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }


        }

        static void WithMinMaxInBuildFunc()
        {
            int[] arr = { 2, 3, 6, 9 };

            int min = arr.Min();
            int max = arr.Max();

            HashSet<int> set = new HashSet<int>(arr);

            for (int i = min; i <= max; i++)
            {
                if (!set.Contains(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void WithMinMaxManual()
        {
            int[] arr = { 2, 3, 6, 9 };

            int min = arr[0];
            int max = arr[0];
            HashSet<int> set = new HashSet<int>();
            for (int i = 1; i < arr.Length; i++)
            {
                //if (arr[i] > min)
                //    max = arr[i];

                //if (arr[i] < max)
                //    min = arr[i];      // this is my logic 

                if (arr[i] < min)  // 1=3 < 2 , 2=6<2, 3=9<2
                    min = arr[i];

                if (arr[i] > max) // 1=3 > 2,yes, 
                    max = arr[i];
            }
           // HashSet<int> set = new HashSet<int>();

            for (int k = 0; k < arr.Length; k++) 
            {
                set.Add(arr[k]);
            }

            for (int j = min; j <= max; j++) //{ 2, 3, 6, 9 };
            {
                bool isMissing = false;

                foreach (var item in set)
                {
                    if (j == item)
                    {
                        isMissing = true; break; 
                    }
                }
               
                if (!isMissing)
                    Console.WriteLine(j); 
            }
            Console.WriteLine("max :" + max);
            Console.WriteLine("min :" + min);

        }


    }
}
