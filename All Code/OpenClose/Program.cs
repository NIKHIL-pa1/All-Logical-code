class Demo
{
    static void Main(string[] args)
    {
        Invoice obj = new Invoice();

        IInterface obj2 = new RegularCust();

        double discount = obj.Discount(obj2);
        Console.WriteLine(discount);



        Cust cust = new Cust();
        Customer ob = new EmpPrimium();

        Console.WriteLine(ob.GetDiscount()); 


    }
}
#region Below example with inheritance

interface IInterface
{
    double GetDiscount();
}




class RegularCust : IInterface
{
    public double GetDiscount() => 0.3;
}

class PremiumCust : IInterface
{
    public double GetDiscount() => 0.5;
}

class EliteCust : IInterface
{
    public double GetDiscount() => 0.7;
}

class Invoice
{
    public double Discount(IInterface dics)
    {
       return dics.GetDiscount();
    }
}
// Above example with inheritance
#endregion

#region Below example with inheritance 

public abstract class Customer
{
    public abstract double GetDiscount();
}

public class EmpRegular : Customer
{
    public override double GetDiscount() => 0.3;
}

public class EmpPrimium : Customer
{
    public override double GetDiscount() => 0.5;
}

public class EmpElite : Customer
{
    public override double GetDiscount() => 0.7;
}

public class Cust
{
    public double GetDisc(Customer customer)
    {
       return customer.GetDiscount();
    }
}
#endregion