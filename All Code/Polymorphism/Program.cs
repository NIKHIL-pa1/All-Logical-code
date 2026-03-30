MyClass obj = new MyClass();
//obj.Add(12, 23);
Console.WriteLine(obj.Add("12", 23));
class MyClass
{
    public int Add(string a, int b) => Convert.ToInt32(a)+b;

    public int Add(int a, int b) => a + b;

    // public int Add(int b, string a) => //a + b;
}