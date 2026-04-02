

using System;
using System.Collections.Generic;

public class HelloWorld
{
    // Delegate declaration
    public delegate void DeliverPizza(string address);

    public delegate int AddDelegate(int x, int y);

    // Dispatcher class that accepts delegate as parameter
    public class Dispatcher
    {
        public void AssignDelivery(string location, DeliverPizza deliveryMethod)
        {
            Console.WriteLine("Assigning delivery...");
            deliveryMethod(location); // Method called via delegate
        }
    }

    // DeliveryTeam class with matching methods
    public class DeliveryTeam
    {
        public void Rahul(string address)
        {
            Console.WriteLine($"Rahul delivering to {address}");
        }

        public void Priya(string address)
        {
            Console.WriteLine($"Priya delivering to {address}");
        }
    }

    // Main method
    public static void Main(string[] args)
    {
        DeliveryTeam team = new DeliveryTeam();
        Dispatcher dispatcher = new Dispatcher();

        // Pass method as parameter using delegate
        dispatcher.AssignDelivery("Kothrud, Pune", team.Rahul);
        dispatcher.AssignDelivery("Wakad, Pune", team.Priya);


        Console.WriteLine("-----------");

        AddDelegate del = Add;
        
        Console.WriteLine(del(10, 20));
    }

    public static int Add(int a, int b) => a + b;
}
