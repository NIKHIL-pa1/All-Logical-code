class MyClass
{
    static void Main()
    {
        int a = 10;
        int b;
        //MyClass obj = new MyClass();

        Refmethod(ref a);
        Console.WriteLine(a);
        OutMethod(out b);

        Console.WriteLine(b);
    }
    static void Refmethod(ref int b)
    {
       
        b = 20;

        Console.WriteLine(b);
    }

    static void OutMethod(out int b)
    {
        b = 30;
        Console.WriteLine(b);
    }
}