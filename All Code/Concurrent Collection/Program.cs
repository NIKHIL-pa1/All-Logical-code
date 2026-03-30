//using System.Collections.Concurrent;

//List<int> list = new List<int>();

//Parallel.For(0, 100000, i =>
//{
//    list.Add(i);   // ❌ Problem
//});

////{
//Console.WriteLine(list.Count);
////}

//ConcurrentBag<int> bag = new();

//Parallel.For(0, 1000, i =>
//{
//    bag.Add(i);
//});

////foreach (var item in bag)
//    Console.WriteLine(bag.Count);

////}

#region example with normal dictionary generic collection


//namespace ConcurrentCollections
//{
//    class Program
//    {
//        static Dictionary<int, string> dictionary = new Dictionary<int, string>();

//        static void Main(string[] args)
//        {
//            Thread t1 = new Thread(Method1);
//            Thread t2 = new Thread(Method2);
//            t1.Start();
//            t2.Start();

//            Console.ReadKey();
//        }

//        public static void Method1()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                dictionary.Add(i, "Added By Method1 " + i);
//                Thread.Sleep(100);
//            }
//        }

//        public static void Method2()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                dictionary.Add(i, "Added By Method2 " + i);
//                Thread.Sleep(100);
//            }
//        }
//    }
//}
#endregion

#region Example with concurrent collection with concurrentDictionary

using System.Collections.Concurrent;

///
namespace ConcurrentCollections
{
    class Program
    {
        static ConcurrentDictionary <int, string> dictionary = new ConcurrentDictionary<int, string>();

        static void Main(string[] args)
        {
            Thread t1 = new Thread(Method1);
            Thread t2 = new Thread(Method2);
            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
            }
        }

        public static void Method1()
        {
            for (int i = 0; i < 10; i++)
            {
                dictionary.TryAdd(i, "Added By Method1 " + i);
                Thread.Sleep(100);
            }
        }

        public static void Method2()
        {
            for (int i = 0; i < 10; i++)
            {
                dictionary.TryAdd(i, "Added By Method2 " + i);
                Thread.Sleep(100);
            }
        }
    }
}

#endregion