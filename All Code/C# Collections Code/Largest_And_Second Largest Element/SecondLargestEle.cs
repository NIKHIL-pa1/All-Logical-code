using Largest_And_Second_Largest_Element;
using System;
using System.Collections.Generic;
using System.Text;

namespace Second_Largest_Element
{
    public class SecondLargestEle
    {
        static void Main(string[] args)
        {
            SecondLargestEle obj = new SecondLargestEle();
             obj.SecondLarge();
            Largest obj1 = new Largest();
            //obj1.LagrstEle();
        }

        void SecondLarge()
        {
            List<int> list = new() { 10, 5, 20, 8,23 };

            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            for (int i = 0; i < list.Count; i++)
            {
                int current = list[i];

                if (current > largest)
                {
                    secondLargest = largest;
                    largest = current;
                }
                else if (current > secondLargest && current != largest)
                {
                    secondLargest = current;
                }
            }
            Console.WriteLine(secondLargest);
        }
    }
}
