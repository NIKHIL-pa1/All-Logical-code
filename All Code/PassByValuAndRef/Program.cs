class Program
{
    static void Main()
    {
       // PassbyRef();
        PassbyValue();

       // PassRefValue();

    }

    static void PassbyValue()
    {
        int a;
        GetValues(out a);
        Console.WriteLine(a);
    }

    static void GetValues(out int an)
    {
        an = 10;
    }
    static void PassbyRef()
    {
        int a = 10;
        UpdateValue(ref a);
        Console.WriteLine(a);
    }

    static void UpdateValue(ref int a)
    {
        a = 100;
    }
    static void PassRefValue()
    {
        int ByValue;
        int ByReference = 10;
        Console.WriteLine("By reference-------------------");
        Reference(ref ByReference); //pass by reference 
        Console.WriteLine(ByReference);

        Console.WriteLine("By value-------------------");
        Program.Value(out ByValue);
        Console.WriteLine(ByValue);
    }
    static void Reference(ref int b)
    {
        b += 20;
        Console.WriteLine(b);
    }
    static void Value(out int byval)
    {
        byval = 10;
        byval += 20;
        Console.WriteLine(byval);
    }
}


