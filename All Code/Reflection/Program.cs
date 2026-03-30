using System;
using System.Reflection;

public class Person
{
    public string Name { get; set; }

    public void SayHello()
    {
        Console.WriteLine("Hello");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(Person);

        Console.WriteLine("Methods:");

        foreach (var method in type.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}