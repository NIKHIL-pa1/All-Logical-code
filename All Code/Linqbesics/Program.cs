List<int> nums = new List<int> { 5, 10, 15, 20, 25, 30, 30, 20, 10 };

var data = nums.Where(n => n % 2 == 0).ToList();

var data1 = nums.Where(n => n >= 10).ToList();

nums.ForEach(x => Console.WriteLine(x));


Console.WriteLine(string.Join(",", data));
Console.WriteLine(data);
Console.WriteLine(string.Join(",", data1));
Console.WriteLine("------------------Start With---------------------");

List<string> names = new List<string>
{

    "Amit",
    "Rohan",
    "Anjali",
    "Suresh",
    "Akash",
    "Meera"

};

var data2 = names.Where(x => x.StartsWith("A")).ToList();
Console.WriteLine(string.Join(",", data2));

Console.WriteLine("------------------Upper---------------------");

var data3 = names.Select(x => x.ToUpper()).ToList();
Console.WriteLine(string.Join(",", data3));

Console.WriteLine("------------------Sorting---------------------");

var ans = nums.OrderByDescending(x => x).ToList();
Console.WriteLine(string.Join(",", ans));

var ans1 = nums.OrderBy(x => x).ToList();
Console.WriteLine(string.Join(",", ans1));


Console.WriteLine("------------------Select Only Names from a List of Objects---------------------");


List<Emp> emps = new List<Emp>
{
      new Emp { Id = 1, Name = "Amit" },
    new Emp { Id = 2, Name = "Nikhil" },
    new Emp { Id = 3, Name = "Rohit" },
    new Emp { Id = 4, Name = "Suman" },
    new Emp { Id = 4, Name = "Suman" },
    new Emp { Id = 4, Name = "Suman" }
};
var ans3 =  emps.Select(x => x.Name).ToList();
Console.WriteLine(string.Join(",",ans3));
ans3.ForEach(x => Console.WriteLine(x));
Console.WriteLine("------------------Take 5---------------------");
var res = nums.Take(3).ToList();
Console.WriteLine(string.Join(",",res));
Console.WriteLine("------------------skip 5---------------------");
var res1 = nums.Skip(4).ToList();
Console.WriteLine(string.Join(",", res1));

Console.WriteLine("------------------group by---------------------");
var res2 = emps.GroupBy(x => x.Name);
//Console.WriteLine(string.Join(",",res2));
foreach(var item in res2)
{
    Console.WriteLine(item.Key);
}
public class Emp
{
    public int Id { get; set; }
    public string? Name { get; set; }
}
