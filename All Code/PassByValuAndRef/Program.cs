class Program
{
    static void Main()
    {
        int ByValue;
        int ByReference = 10;
        Console.WriteLine("By reference-------------------");
        Program.Reference(ref ByReference); //pass by reference 
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


