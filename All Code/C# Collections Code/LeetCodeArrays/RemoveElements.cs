using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeArrays
{
    public class RemoveElements
    {
        public void RemovEle()
        {
            int[] nums = { 3, 2, 2, 3 };
            int val = 3;
            int k = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            Console.WriteLine("new length is " + k);

            foreach (var item in nums)
                Console.WriteLine(item);

            Console.WriteLine("Array is : ");

            for (int i = 0; i < k; i++)
                Console.Write(nums[i] + " ");

        }
    }
}
