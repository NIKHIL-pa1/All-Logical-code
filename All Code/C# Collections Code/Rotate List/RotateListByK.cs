using System;
using System.Collections.Generic;
using System.Text;

namespace Rotate_List
{
    public class RotateListByK
    {
        static void Main(string[] args)
        {
            Rotatelist();
        }

        static void Rotatelist()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            List<int> emptList = new();
            int k = 9;
            int n = list.Count;

            k = k % n;

            for (int i = n - k; i < n; i++)
                emptList.Add(list[i]);

            for (int i = 0; i < n - k; i++)
                emptList.Add(list[i]);

            foreach (int i in emptList)
                Console.WriteLine(i);

        }
    }
}
