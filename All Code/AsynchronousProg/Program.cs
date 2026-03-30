class Test
{
    static void Main(string[] args)
    {
        //doWork();
         doThreadWork();
        UseAwait();
        GetDataAsync();
    }
    static void doWork()
    {
       
        Console.WriteLine("Program Start");

        Thread.Sleep(5000); // ⛔ 5 seconds BLOCK

        Console.WriteLine("Program End");

    }


    static async Task UseAwait()
    {
        Console.WriteLine("Start");

        await Task.Delay(3000); // 3 sec wait, but NON-BLOCKING

        Console.WriteLine("End");

    }
    static async Task doThreadWork()
    {
        Console.WriteLine("Start");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Second {i}");
            Thread.Sleep(2000);
        }
    }

    static async Task<int> GetDataAsync()
    {
        // await Task.Delay(3000); // non-blocking
        Thread.Sleep(5000);
        return 42;
    }




}
