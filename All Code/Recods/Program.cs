//class Myclass
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("implementation with normal class");
//        A obj1 = new A()
//        {
//            name = "Nikhil",
//            age = 25
//        };
//        A obj2 = new A()
//        {
//            name = "Nikhil",
//            age = 25

//        };
//        Console.WriteLine(obj1);
//        Console.WriteLine(obj1 == obj2);

//        Console.WriteLine("implementation with Record class");

//        B b1 = new B()
//        {
//            name = "Nikhil",
//            age = 25
//        };
//        B b2 = new B()
//        {
//            name = "Nikhil",
//            age = 25

//        };
//        // b1.name = "Patil"; // record is mutable here 

//        Console.WriteLine(b1); //output :  B { name = Patil, age = 25 }
//        Console.WriteLine(b1 == b2);
//    }
//}

//class A
//{
//    public string name { get; set; }
//    public int age { get; set; }
//}

//public record Person(string name, int age);

//public record B
//{
//    public string name;
//    public int age;
//}


class Demo
{
    static void Main(string[] args)
    {
        Console.WriteLine("implementation with normal class");
        Normal obj = new Normal()
        {
            name = "Test",
            age = 5,
        };

        Normal obj2 = new Normal()
        {
            name = "Test",
            age = 5,
        };

        obj.name = "Test2";
        Console.WriteLine(obj.name);

        Console.WriteLine(obj ==  obj2);

        Rec rec1 = new Rec()
        {
            name = "Test",
            age = 5,
        };
        Rec rec2 = new Rec()
        {
            name = "Test",
            age = 5,
        };
        Console.WriteLine(rec2 == rec1);
    }
}

class Normal
{
    public string name { get; set; }
    public int age { get; set; }
}

public record Rec
{
    public int age;
    public string name;
}