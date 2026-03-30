
#region Example of single inheritace

//Dog obj = new Dog();
//obj.Bark();
//obj.Eat();
//class Animal
//{
//    public void Eat()
//    {
//        Console.WriteLine("Animal is eating");
//    }
//}

//class Dog: Animal
//{
//    public void Bark()
//    {
//        Console.WriteLine("Dog is barking");
//    }
//}
#endregion

#region Example of virtual and overiding keywords means method overriding

//Father obj = new Son();
//Console.WriteLine(obj.GetType());
//obj.speak();



//class Father
//{
//    public virtual void speak()
//    {
//        Console.WriteLine("Father speak hindi");
//    }
//}

//class Son : Father
//{
//    public override void speak()
//    {
//        Console.WriteLine("Son speak english");
//    }
//}


#endregion

#region Abstract class + inheritance
//Son obj = new Son();
//obj.Responsibility();

//abstract class Father
//{
//    public abstract void Responsibility();
//}

//class Son : Father
//{
//    public override void Responsibility()
//    {
//        Console.WriteLine("this is abstract method implementation in child class");
//    }
//}
#endregion

#region inheritance Parameterized constructor with base


//Father obj = new Son();

//class Father
//{
//    public Father(string name)
//    {
//        Console.WriteLine("Father name is  : " + name);
//    }
//}

//class Son : Father
//{
//    public Son() : base("Nikhil")
//    {
//        Console.WriteLine("Son constructor is called");
//    }
//}

#endregion

#region Method Hiding (new keyword)

//Vehicles obj = new Bike();
//obj.Start();

//Father f = new Son();
//f.Work();

//class Vehicles
//{
//    public void Start()
//    {
//        Console.WriteLine("Start engine");
//    }
//}

//class Bike : Vehicles
//{
//    public new void Start()
//    {
//        Console.WriteLine("Bike has started by kicking");
//    }
//}

//class Father
//{
//    public void Work()
//    {
//        Console.WriteLine("Father works hard");
//    }
//}

//class Son : Father
//{
//    public new void Work()
//    {
//        Console.WriteLine("Son works smart");
//    }
//}

#endregion

#region Interface + Inheritance (Multiple inheritance style)

//Son ovbj = new Son();
//ovbj.Earn();
//ovbj.Study();
//interface IFather
//{
//   void Earn();
//}

//interface ISon
//{
//    void Study();
//}

//class Son : IFather, ISon
//{
//    public void Earn()
//    {
//        Console.WriteLine("Son earns money");
//    }

//    public void Study()
//    {
//        Console.WriteLine("Son Studies");
//    }
//}
#endregion

#region multilevel inheritance

Son s = new Son();
s.property();
s.Business();
s.Skills();

Console.WriteLine("-------------------------------------");

Father obj = new Son();
obj.property();
obj.Business();
//obj.Skills();

class Granfather
{
    public virtual void property()
    {
        Console.WriteLine("Grandfather has a land");
    }
}

class Father : Granfather
{
    public override void property()
    {
        Console.WriteLine("Father manages the land");
    }

    public virtual void Business()
    {
        Console.WriteLine("Father runs business");
    }
}

class Son : Father
{
    public override void Business()
    {
        Console.WriteLine("Son checks stock of business");
    }
    public void Skills()
    {
        Console.WriteLine("Son knows coding");
    }
}
#endregion