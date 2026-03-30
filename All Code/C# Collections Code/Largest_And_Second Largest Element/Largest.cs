using System;
using System.Collections.Generic;
using System.Text;

namespace Largest_And_Second_Largest_Element
{
    public class Largest
    {
        public void LagrstEle()
        {
            List<int> list = new() { 10, 5, 20, 8, 23, -1000, 239 };

            //int largest = int.MinValue;
            int largest = list.Min();

            for (int i = 0; i < list.Count; i++)
            {
                //int current = list[i];
                if (list[i] > largest)
                    largest = list[i];
                else
                    continue;
                    
            }
            Console.WriteLine(largest);

            int second = list.Min();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > largest)
                {
                    second = largest;
                    largest = list[i];
                }
                else if(list[i] > second && list[i] != largest)
                    second = list[i];
            }
            Console.WriteLine("Second largest is "+second);
        }
    }
}
