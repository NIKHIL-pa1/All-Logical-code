
////Demo obj =  new Demo();
////obj.balance = -1100;

////Console.WriteLine(obj.balance);
////class Demo
////{
////    public int balance;


//} // this is real problem that why we use encapsulation

AllPolicies obj = new AllPolicies();
//obj.WidrawAmt(200); // = -200;
//Console.WriteLine(obj.WidrawAmt(200));
//Console.WriteLine(obj.Deposit(300));

obj.Deposit(500);
obj.WidrawAmt(200);

Console.WriteLine(obj.CheckBalance());

//for get set method
obj.balance = 500;


class AllPolicies
{
    private int _balance;

    //Using het set method
    //public int MyProperty { 
    //    get { return _balance; } 
    //    set
    //    {
    //        if (value > 0)
    //            _balance = value;
    //        else
    //            Console.WriteLine("balance could not less than 0");
    //    }
    //}

    public void WidrawAmt(int amt)
    {
        if (amt > 0 && _balance > amt)
        {
            _balance -= amt;
        }
        //return _balance;
    }
 
    public void Deposit(int amt)
    {
        if (amt > 0)
        {
            _balance += amt;
        }
        // return _balance;
    }

    public int CheckBalance()
    {
        return _balance;
    }


    public int balance
    {
        get { return _balance; }
        set { 
            if(_balance > 0)
                _balance = value;
        }
    }
}

//BankAccount acc = new BankAccount();
//acc.Deposit(500);
//acc.Withdraw(200);

//Console.WriteLine(acc.CheckBalance());

//class BankAccount
//{
//    private int _balance;

//    public void Deposit(int amount)
//    {
//        if (amount > 0)
//        {
//            _balance += amount;
//        }
//    }

//    public void Withdraw(int amount)
//    {
//        if (amount > 0 && amount <= _balance)
//        {
//            _balance -= amount;
//        }
//    }

//    public int CheckBalance()
//    {
//        return _balance;
//    }
//}

