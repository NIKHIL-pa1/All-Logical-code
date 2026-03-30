
#region Single-Cast Delegate


//MyClass obj = new MyClass();


//AddDelegate del = obj.add;

//int res = del(10, 20);
//Console.WriteLine(res);
//delegate int AddDelegate(int a, int b);

//class MyClass
//{

//    public int add(int a, int b) => a + b;
//}


#endregion

#region MultiCast Delegate


//MyClass obj = new MyClass();


//AddDelegate del = obj.add;
//del += obj.sub;

//int res = del(40, 20);
//int neg = del(50, 20);
//Console.WriteLine(res);
//Console.WriteLine(neg);
//delegate int AddDelegate(int a, int b);

//class MyClass
//{
//    public int add(int a, int b) => a + b;

//    public int sub(int a, int b) => a - b;
//}

#endregion

                  

#region Generic Delegates

// Type 1 Func

Func<int, int, int> sum = (a, b) => a + b;

int res = sum(10, 20);
Console.WriteLine(res);


//Func in Collections (REAL PROJECT)
List<int> list = new List<int>() { 1,2,3,4,5,6,7};

List<int> sq =  list.Select(x => x * x).ToList();

Console.WriteLine(Convert.ToInt32(sq));

//Type 2 Action


#endregion