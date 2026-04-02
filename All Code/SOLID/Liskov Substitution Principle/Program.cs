class MyClass
{
    static void Main(string[] args)
    {
        //For bad
        Bird bird = new Ostrich();

       // bird.Fly();

        //For Good
        AllBirds b1 = new Sparrows();
        b1.Eat();
        AllBirds b2 = new Ostriches();
        b2.Eat();
        FlyingBirds b3 = new Sparrows();
        b3.Flys();

    }
}

#region Bad Example of LSP


public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("Bird is flying");
    }
}

public class Sparrow : Bird
{
    public override void Fly()
    {
        Console.WriteLine("Sparrow is flying");
    }
}
public class Ostrich : Bird
{
    public override void Fly()
    {
        throw new Exception("Ostrich cannot fly");

    }
}
#endregion

#region Good Example of LSP

public class AllBirds
{
    public virtual void Eat()
    {
        Console.WriteLine("Birds are eats");
    }
    //public virtual void Flys()
    //{
    //    Console.WriteLine("Birds are eats");
    //}
}

public class FlyingBirds : AllBirds
{
    public virtual void Flys()
    {
        Console.WriteLine("flying birds");
    }
}

public class Sparrows : FlyingBirds
{
    public override void Flys()
    {
        Console.WriteLine("Sparrow is flying");
    }
}

public class Ostriches : AllBirds
{
    public override void Eat()
    {
        Console.WriteLine("Ostrich is eating");

    }
}

#endregion