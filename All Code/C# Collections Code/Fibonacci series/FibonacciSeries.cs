using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci_series
{
    public class FibonacciSeries
    {
        static void Main(string[] args)
        {
            FibonacciNums();
        }

        static void FibonacciNums()
        {
            int iterate = 0;
            long first = 0;  
            long second = 1;

            Console.Write("Enter the number till want iteration : ");
            int num = Convert.ToInt32(Console.ReadLine());
            while(iterate <= num)
            {
                Console.WriteLine(first);
                long c = first + second;
                first = second;
                second = c;
                iterate++;
            }
        }
    }
}
