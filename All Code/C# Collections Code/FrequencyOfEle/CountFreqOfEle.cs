using System;
using System.Collections.Generic;
using System.Text;

namespace FrequencyOfEle
{
    public class CountFreqOfEle
    {

        static void Main(string[] args)
        {
            CountFreqOfEle obj = new CountFreqOfEle();
            //obj.CountFrequencyOfElemets();
            CountFrequencyOfElemets2();
        }
        //O(n)^2 time complexity
        public void CountFrequencyOfElemets()
        {
            List<int> list = new() { 1, 2, 2, 3, 1 };
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < list.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        count++;
                    }
                }

                if (dic.ContainsKey(list[i]))
                    continue;
                dic.Add(list[i], count);
                Console.WriteLine($"The count of {list[i]} is {count}");
            }
        }

        //optimize solution O(n)
        static void CountFrequencyOfElemets2()
        {
            List<int> list = new() { 1, 2, 2, 3, 1, 4, 5, 6, 4, 4, 4, 4, };

            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int i in list)
            {
                if (dict.ContainsKey(i))
                    dict[i]++;
                else
                    dict[i] = 1;
            }

            foreach (var dic in dict)
                Console.WriteLine($"The count of {dic.Key} is {dic.Value}");
        }
    }
}
