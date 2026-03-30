public class Program
{
    static void Main(string[] args)
    {
        Program obj = new Program();
        obj.func1();
        obj.func2();
    }
    public void func1()
    {
        Console.WriteLine("Method of funct 1");
    }

    public void func2()
    {
        Console.WriteLine("Method of funct 2");
    }
}

public static class MyClass
{
    
    public static void Method3(this Program para)
    {
        Console.WriteLine("this is Method is");
    }
    public static void Method4()
    {
        Console.WriteLine("this is Method is");
    }

    
}

public class TestExtentionMethod
{
    static void Main(string[] args)
    {
        Program para = new Program();
        para.Method3();
    }
}