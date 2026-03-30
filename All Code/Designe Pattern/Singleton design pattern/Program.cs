using Singleton_design_pattern;

class Program
{
    static void Main(string[] args)
    {
        MyClass obj =  MyClass.GetInstance();
        MyClass obj2 =  MyClass.GetInstance();

        Console.WriteLine(obj.GetType());
        Console.WriteLine(obj2);
    }
}