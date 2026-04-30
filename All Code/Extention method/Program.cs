public class MyClass
{
    public void Func1()
    {
        Console.WriteLine("This is Function 1");
    }
    public void Func2()
    {
        Console.WriteLine("This is Function 2");
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        obj.Func1();
        obj.Func2();
        obj.Func3();
        obj.Func4();
       

    }
}

public static class ExtentionClass
{
    public static void Func3(this MyClass p)
    {
        Console.WriteLine("This is function 3");
    }
}



public static class Ext
{
    public static void Func4(this MyClass para)
    {
        Console.WriteLine("this method from Func4");
    }
}