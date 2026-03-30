class MyClass
{
    static void Main(string[] args)
    {
        //TupleInitialization();
        //TupleEqualityOperator();
        var std = TupleReturnTypeMethod("Nikhil");
        if (std.isValid)
            Console.WriteLine($"Message is : {std.name}");
        else Console.WriteLine(std.isValid);
    }
    static void TupleInitialization()
    {
        // first way to create tuples
        Console.WriteLine("first way to create tuples");
        var student = ("Nikhil", 25, 198.23);

        Console.WriteLine(student.Item1);
        Console.WriteLine(student.Item2);
        Console.WriteLine(student.Item3);
        Console.WriteLine();

        //second way to create tuples
        Console.WriteLine("second way to create tuples");

        (string,int,double) students = student;
        Console.WriteLine(students.Item1);
        Console.WriteLine(students.Item2);
        Console.WriteLine(students.Item3);
        Console.WriteLine();

        //third way to create tuples(with item/named tuple fields)
        Console.WriteLine("third way to create tuples");

        (string name, int age, double height) stud = student;

        Console.WriteLine(stud.name);
        Console.WriteLine(stud.age);
        Console.WriteLine(stud.height);

        //Reassigned-changed the value of tuples

        stud.age = 27;
        Console.WriteLine("----"+stud.age);

        //Tuples with equality operator

    }

    static void TupleEqualityOperator()
    {
        //Tuples with equality operator

        (string, int) Equa1 = ("Nikhil", 25);
        (string, int) Equa2 = ("Nikhil", 26);
        Console.WriteLine(Equa1 == Equa2);
    }

    public static (string name ,bool isValid) TupleReturnTypeMethod(string name)
    {
        if (name.Equals("Nikhil"))
            return ("Hello Patil", true);
        else
            return (name,false);
    }
}