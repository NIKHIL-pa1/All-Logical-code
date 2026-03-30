
//int[] arr = { 5, 1, 2, 5, 3, 2 };
//List<int> unique = new List<int>();

//foreach (int num in arr)
//{
//    if (!unique.Contains(num))
//        unique.Add(num);
//}

//int[] result = unique.ToArray();
//// result = [5, 1, 2, 3]
///
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        int i = 0, j = 0;
//        int[] arr1 = { 5, 1, 2, 5, 3, 2};
//        for (i = 0; i < arr1.Length; i++)
//        {
//            for (j = 0; j < arr1.Length; j++)
//            {
//                if (i == j)
//                    continue;
//                if (arr1[j] == arr1[i])
//                    break;
//            }
//            if (arr1.Length == j)
//            {
//                Console.Write(arr1[i] + " ");
//            }
//        }
//    }
//}

int[] arr1 = { 5, 1, 2, 5, 3, 2 };
int j = 0;
for (int i = 0; i < arr1.Length; i++)
{
    for (j = 0 ; j < arr1.Length; j++)
    {
        if (i == j)
            continue;
        if (arr1[i] == arr1[j])
        {
            break;
        }

    }

    if (arr1.Length == j)
    {
        Console.WriteLine(arr1[i] + " ");
    }
}
