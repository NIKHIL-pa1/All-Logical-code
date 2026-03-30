using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeArrays
{
    public class SearchInsertElement
    {
        public void SearchByBinary()
        {
            int[] nums = { 1, 3, 5, 6 ,8};

            int target = Convert.ToInt32(Console.ReadLine());

            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (nums[mid] == target)
                { 
                    Console.WriteLine("Insert Position: "+ mid);
                    return;
                }
                else if (nums[mid] < target)
                    left = mid + 1;

                else
                    right = mid - 1;

            }
            Console.WriteLine("Not Found");
        }
    }
}
