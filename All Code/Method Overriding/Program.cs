
Dog obj = new Dog();
obj.speak();


class Animal
{
    public virtual void speak()
    {
        Console.WriteLine("Animal Makes songs");
    }
}

class Dog : Animal
{
    public override void speak()
    {
        Animal ob
            = new Animal();
        ob.speak();
        Console.WriteLine("Dog barking");
    }
}

