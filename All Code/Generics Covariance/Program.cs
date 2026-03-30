

#region ✅ Example 1.1 – IEnumerable<T> (MOST COMMON)

//Animal obj = new Dog();
//IEnumerable<Dog> dog = new List<Dog>
//{
//    new Dog {Name = "Kim"},
//    new Dog {Name = "Sam"},

//};

//IEnumerable<Animal> animals = dog;
////Animal obj = new Dog();
////List<Dog> dog1 = new List<Dog>();
////List<Animal> animals = dog1; // it is not suported in c#

//IEnumerable<Dog> dogy = new List<Dog>();

//IEnumerable<Animal> animal = dogy;

//foreach (Animal item in animals)
//{
//    //if (item is Dog d)
//    //{
//    //    d.Bark();
//    //}
//    Console.WriteLine(item.Name);
//}

//class Animal
//{
//    public string Name { get; set; }
//}

//class Dog : Animal
//{
//    public void Bark() => Console.WriteLine("Barking");

//}
#endregion

#region ✅ Example 2: Method return type (very interview-friendly)

//IEnumerable<Animal> animals = GetAnimals();

//foreach (Animal animal in animals)
//{
//    Console.WriteLine(animal.Name);
//}
//static IEnumerable<Animal> GetAnimals()
//{
//    List<Dog> dogs = new()
//    {
//        new Dog { Name = "Max" }
//    };

//    return dogs; // ✅ covariance
//}

//class Animal
//{
//    public string Name { get; set; }
//}

//class Dog : Animal
//{
//    public void Bark() => Console.WriteLine("Barking");

//}


#endregion

#region ✅ Example 3: Custom interface with out (VERY IMPORTANT)
//IProducer<Dog> dogProducer = new DogProducer();

//// COVARIANCE
//IProducer<Animal> animalProducer = dogProducer;

//Animal a = animalProducer.Get();
//Console.WriteLine(a.Name);

//interface IProducer<out T>
//{
//    T Get();
//}
//class DogProducer : IProducer<Dog>
//{
//    public Dog Get()
//    {
//        return new Dog { Name = "Buddy" };
//    }
//}
//class Dog :Animal
//{
//    public void Bark() => Console.WriteLine("Barking");

//}
//class Animal
//{
//    public string Name { get; set; }
//}

#endregion

#region ✅ Example 5: Delegate covariance (return type)
AnimalDelegate del = GetDog; // ✅ covariance
Animal a = del();
Console.WriteLine(a.Name);
static Dog GetDog()
{
    return new Dog { Name = "Bruno" };
}
class Dog : Animal
{
    public void Bark() => Console.WriteLine("Barking");
}
class Animal
{
    public string Name { get; set; }
}


delegate Animal AnimalDelegate();


#endregion
