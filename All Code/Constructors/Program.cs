public class Myclass
{
    public static void Main(string[] args)
    {
        Parent obj = new Parent();
        Child obj1 = new Child("Nikhil", 25);
        CopyConstr obj2 =  new CopyConstr("kiris",89);
        obj2.GetData();
        
        CopyConstr obj3 =  new CopyConstr(obj2);
        obj3.GetData();

        PrivateConstr.GetDate();
        //PrivateConstr obj2 = new PrivateConstr();
    }
}
//1 default constructor
class Parent 
{
    public int Childno;
    public Parent()
    {
        Console.WriteLine("this is default constructor");
    }
}

//2 parametrize constructor
class Child : StaticCtor
{
    string name;
    int age;
    public Child(string Name, int Age)
    {
        this.name = Name;
        this.age = Age;
        Console.WriteLine("This is parameterize constructor"+name+age);
    }
}

//3 Static constructor
class StaticCtor 
{
    public static string logpath;
    static StaticCtor()
    {
        logpath = "C://test.txt";
        Console.WriteLine("This is static constructor"+logpath);
    }
}

//4 Private constructor
class PrivateConstr
{
    private PrivateConstr()
    {
        Console.WriteLine("This is private contructor");  
    }

    public static void GetDate()
    {
        Console.WriteLine(DateTime.Now);
    }
}

//5 copy constructor
class CopyConstr
{
    string name;
    int marks;
    public CopyConstr(string name, int marks)
    {
        this.name = name;
        this.marks = marks;
    }

    public void GetData() => Console.WriteLine("name is " + name + " and " + "marks are " + marks);
    public CopyConstr(CopyConstr data)
    {
        Console.WriteLine("this is copy constructor");
        this.name = data.name;
        this.marks = data.marks;
    }

}


// MyClass obj = new MyClass();
// MyClass obj2 = new MyClass("Nikhil",25);
// MyClass obj3 = new MyClass("Nikhil", 25, "male");


//class MyClass
//{
//    public string name;
//    public string age;
//    public string gender;

//    public MyClass() //: this("Nikhil", 25)
//    {
//        Console.WriteLine("This is default constructor");
//    }
//    public MyClass(string name, int age) : this()
//    {
//        Console.WriteLine("This is parameterise constructor with two argumets with " + name + " " + age);
//    }
//    public MyClass(string name, int age, string Gender)
//    {
//        Console.WriteLine("This is parameterise constructor with three argumets with " + name + " " + age + " " + Gender);
//    }


//}






//MyClass obj = new MyClass();


//MyClass obj2 = new MyClass();
//obj2.name = "Test";
//obj2.age = 23;


//MyClass obj3 = new MyClass();
//obj3.age = 27;
//obj3.name = "Test2";
//obj3.gender = "None";

//class MyClass
//{
//    public string name;
//    public int age;
//    public string gender;


//}


//public class Program
//{
//    private static void Main(string[] args)
//    {
//        B obj = new B();
//    }
//}

//class A
//{
//    static A()
//    {
//        Console.WriteLine("this is static constructor");
//    }

//    private A()
//    {
//        Console.WriteLine("this is Private constructor");
//    }
//}

//class B : A
//{

//}