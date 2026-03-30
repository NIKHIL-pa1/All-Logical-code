using System;
using System.Collections.Generic;
using System.Text;

namespace CountVowels
{
    public class CountVowel
    {
        //static void Main(string[] args)
        //{
        //    CountVowels();
        //}

        static void CountVowels()
        {
            string str = "Hello World";

            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] ==  'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
