#region Generic class


//MyClass<int> obj = new MyClass<int>();
//obj.value = 1;
//Console.WriteLine(obj.value);

//MyClass<string> obj2 = new MyClass<string>();
//obj2.value = "Nikhil";

//Console.WriteLine(obj2.value);


//Gen obk3 = new Gen();
//obk3.value = "karan";
//Console.WriteLine(obk3.value);

//int ans = (int)obk3.value;
//class MyClass<T>
//{
//    public T value;
//}

//class Gen
//{
//    public object value;
//}
#endregion

#region Generic Method

//Print obj =  new Print();

//obj.Data<int>(100);
//obj.Data<string>("Niks");
//obj.Data<bool>(true);

//class Print
//{
//    public void Data<T>(T getData)
//    {
//        Console.WriteLine(getData);
//    }
//}

#endregion

#region Constrains types

#region 1. reference type constraint

//ReferenceType<string> obj = new ReferenceType<string>();
//obj.add("niks");
////obj.value = "str";
////Console.WriteLine(obj.value);
//// ReferenceType<int> obj2 = new ReferenceType<int>();  // compile time error 

//class ReferenceType<T> where T : class
//{

//    //public T value;
//    public void add(T item)
//    {
//        Console.WriteLine(item);
//    }
//}

#endregion

#region 2. Value type constraint

//ValueType<int> obj = new ValueType<int> ();
//obj.value = 20;
////obj.value = "niks"; // compile time error at this line
//Console.WriteLine(obj.value);


//class ValueType<T>  where T : struct
//{
//    public T value;
//}


#endregion


#region 3. Constructor constraint

//ConstructorConstraint<User> obj = new ConstructorConstraint<User>();
//obj.Create();
//class ConstructorConstraint<T> where T : new()
//{
//    public T Create()
//    {
//        return new T();
//    }
//}

//class User
//{
//    public User()
//    {
//        Console.WriteLine("This is private ctor");
//    }
//}



#endregion

#region 4. interface Constraint

FileLogger FILE = new FileLogger();
LoggerService<FileLogger> obj = new LoggerService<FileLogger>();
obj.Write(FILE);

interface ILogger
{
    void Log();
}

class FileLogger : ILogger
{
    public void Log() { Console.WriteLine("hi"); }
}

class LoggerService<T> where T : ILogger
{
    public void Write(T logger)
    {
        logger.Log();
    }
}

#endregion

#endregion

