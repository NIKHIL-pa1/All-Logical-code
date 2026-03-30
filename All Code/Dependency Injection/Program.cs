#region Without Dependency Injection - Tightky Coupled

//class Dependency
//{
//    static void Main(string[] args)
//    {
//        Account ac= new Account();

//        ac.GetAccDetails();
//    }
//}


//class CurrentAccount
//{
//    public void PrintDetails()
//    {
//        Console.WriteLine("Current Account Details");
//    }
//}

//class SavingAccount
//{
//    public void PrinDetail()
//    {
//        Console.WriteLine("Saving Account Details");
//    }

//}

//class SalaryAccount
//{

//}
//class Account
//{
//    CurrentAccount ca = new CurrentAccount();
//    SavingAccount sa = new SavingAccount();
//    SalaryAccount sal = new SalaryAccount();
    
//    public void GetAccDetails()
//    {
//        ca.PrintDetails();
//        sa.PrinDetail();
//        Console.WriteLine("Account created");
//    }
//}
//class Dependency
//{
//    static void Main(string[] args)
//    {
//        Account ac= new Account();

//        ac.GetAccDetails();
//    }
//}


//class CurrentAccount
//{
//    public void PrintDetails()
//    {
//        Console.WriteLine("Current Account Details");
//    }
//}

//class SavingAccount
//{
//    public void PrinDetail()
//    {
//        Console.WriteLine("Saving Account Details");
//    }

//}

//class SalaryAccount
//{

//}
//class Account
//{
//    CurrentAccount ca = new CurrentAccount();
//    SavingAccount sa = new SavingAccount();
//    SalaryAccount sal = new SalaryAccount();
    
//    public void GetAccDetails()
//    {
//        ca.PrintDetails();
//        sa.PrinDetail();
//        Console.WriteLine("Account created");
//    }
//}
#endregion

#region With Dependecny Injection

//class CtorInjection
//{
//    static void Main(string[] args)
//    {
//        IAccount ac = new SavingAccount();

//        Account act = new Account(ac);

//        act.GetAllDetails();
//    }
//}

//class SavingAccount : IAccount
//{
//    public void PrintDetails()
//    {
//        Console.WriteLine("Saving Acount details");
//    }
//}

//class CurrentAccount : IAccount
//{
//    public void PrintDetails()
//    {
//        Console.WriteLine("Current Account Details");
//    }

    
        
//}

//class Account
//{
//    private readonly IAccount _account;

//    public Account(IAccount Account)
//    {
//        this._account = Account;
//    }

//    public void GetAllDetails()
//    {
//        _account.PrintDetails();
//        Console.WriteLine("Account Created");
//    }
//}

//interface IAccount
//{
//    public void PrintDetails();
//}

class Myclass
{
    static void Main(string[] args)
    {
        IAccount ac = new CurrentAccount();

        Account obj = new Account(ac);
        obj.GetAccountDetails();
    }
}

public interface IAccount
{
    void Getdetails();
}

public class SavingAccount : IAccount
{
    public void Getdetails()
    {
        Console.WriteLine("Saving account is created");
    }
}

public class CurrentAccount : IAccount
{
    public void Getdetails()
    {
        Console.WriteLine("This is method of Current account");
    }
}
public class Account
{
    private readonly IAccount _account;

    public Account(IAccount account)
    {
        this._account = account;
    }

    public void GetAccountDetails()
    {
        _account.Getdetails();
        Console.WriteLine("Account is created");
    }
}
#endregion