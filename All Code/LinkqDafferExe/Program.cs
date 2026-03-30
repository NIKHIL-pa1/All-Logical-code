List<int> list = new List<int> { 3, 4, 5 };

var query = list.Where(x => x > 3).ToList(); // ✅ immediately execute

list.Add(6); // this will work with var query = list.Where(x => x > 3)

foreach (var item in query)
{
    Console.WriteLine(item);
}