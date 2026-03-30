using System;
using System.Collections.Generic;
using System.Text;

namespace Frequency_of_Charecter
{
    internal class FreqOfChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string name = Console.ReadLine();

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (var item in name)
            {
                if (dict.ContainsKey(item))
                    dict[item]++;
                else
                    dict[item] = 1;
            }

            foreach(var item in dict)
                Console.WriteLine($"{item.Key},{item.Value}");
        }
    }
}
