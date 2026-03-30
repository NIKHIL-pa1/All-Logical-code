////static void get(params int[] numbers)
//static void get(params object[] numbers)
//{
//    foreach (object n in numbers)
//    {
//        if (n is int[] arr)
//        {
//            Console.WriteLine(string.Join(",", arr.Cast<object>()));
//        }
//        else
//            Console.WriteLine(n);
//    }
//}
////get(  1, 2, 3, 4, 5 );
//get(2, "Hello", new int[] { 1, 2, 3, 4, 5 }, 2.5);


static void Main()
{
    Calculate();
    Console.ReadLine();
}

static void Calculate()
{
    int Add(int a, int b)
    {
        return a + b;
    }

    int result = Add(10, 20);
    Console.WriteLine(result);
}
