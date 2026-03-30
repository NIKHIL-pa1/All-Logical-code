Console.WriteLine("-------------------------------1️.Filtering MethodsRegion Start-------------------------------");
#region 1️. Filtering MethodsRegion
#region  Where() – Filter by Condition 
var list = new List<int> { 1, 2, 3, 5, 7, 9, 20, 90, 45, 66, 78 };

var res = list.Where(x => x > 10).OrderByDescending(x => x);

var evenNo = list.Where(x => x % 2 == 0);

var res1 = from i in list orderby i where i is > 10 select i;


foreach (var item in evenNo)
{
    Console.WriteLine(item);
}

Console.WriteLine("-------------------------------Where() – Filter by Condition end-------------------------------");

#endregion

#region OfType() – Filter by Type 

var mylist = new List<object> { 1, "Nikhil", "Sagar", 2,3,5,"karan"};

var ans = mylist.OfType<string>();

//Console.WriteLine(string.Join(",", ans));

foreach (var item in ans)
{
    Console.WriteLine(item);
}

Console.WriteLine("-------------------------------OfType() – Filter by Type end-------------------------------");
Console.WriteLine("-------------------------------1️. Filtering MethodsRegion end-------------------------------");
Console.WriteLine();
#endregion

#endregion

Console.WriteLine("-------------------------------2. Projection Methods Start-------------------------------");
#region 2. Projection Methods 

#region  Select() – Transform Elements
Console.WriteLine("-------------------------------Select() – Transform Elements Start-------------------------------");
var nums =  new List<int>() { 1,3,5,6};

var sq = nums.Select(x => x * x);

Console.WriteLine(string.Join(",",sq));
Console.WriteLine("-------------------------------Select() – Transform Elements end-------------------------------");
Console.WriteLine();

#endregion  SelectMany() – Flatten Nested Collections


#region SelectMany()

Console.WriteLine("-------------------------------SelectMany() – Flatten Nested Collections Start-------------------------------");
var namelist = new List<string>() {"Hello","Nikhil" };
var ansName = namelist.SelectMany(x => x);
Console.WriteLine(string.Join(",",ansName));
Console.WriteLine("-------------------------------SelectMany() – Flatten Nested Collections End-------------------------------");
Console.WriteLine("-------------------------------2. Projection Methods  End-------------------------------");
Console.WriteLine();
#endregion
#endregion

Console.WriteLine("-------------------------------3️. Ordering Methods Start-------------------------------");
#region 3️. Ordering Methods 

#region  OrderBy() – Ascending Order 
Console.WriteLine("------------------------------- OrderBy(), OrderByDescending() – Ascending, Descending Order Start-------------------------------");

var intlist = new List<int>() {23,56,78,65,34,1,3,89 };

var ListAns =  intlist.OrderByDescending(x => x);
Console.WriteLine(string.Join(",",ListAns));
Console.WriteLine("------------------------------- OrderBy(), OrderByDescending() – Ascending, Descending Order end-------------------------------");
Console.WriteLine();
#endregion

#region  ThenBy() 

Console.WriteLine("------------------------------- ThenBy()  Start-------------------------------");

var people = new List<(string name,int age)>()
{
    ("Nikhil",25 ),
    ("Sagar" ,24),
    ("Bibe",26 ),
    ("Nikhil",24 ),
    ("foxx",35 ),
    ("James",54 ),
    ("James",44 ),
};

var GrpByPeople = people.OrderBy(x => x.name).ThenBy(p => p.age);
var GrpByPeoples = people.OrderBy(x => x.name).ThenByDescending(p => p.age);

foreach (var item in GrpByPeoples)
{
    Console.WriteLine($"{item.name} : { item.age}");
}
 
//Console.WriteLine(string.Join(",",GrpByPeople));

Console.WriteLine("------------------------------- ThenBy()  End-------------------------------");

#endregion

#region  Reverse() – Reverse Order

var num = new List<int>() { 45,5,787,2,5,6,23,67};

var reversed = num.AsEnumerable().Reverse();
Console.WriteLine(string.Join(", ", reversed));
#endregion

Console.WriteLine("-------------------------------3️. Ordering Methods End-------------------------------");
#endregion

Console.WriteLine("-------------------------------4️. Grouping Methods Start-------------------------------");
#region 4️. Grouping Methods 

#region  GroupBy() – Group Elements 

var peopleGrp = new List<string>() { "James", "Bibe", "Sagar", "Nikhil", "Bibe", "Sagar" };

var grpres = peopleGrp.GroupBy(x => x[0]);
//Console.WriteLine(string.Join(",",grpres));
foreach (var grp in grpres)
{
    Console.WriteLine($"{grp.Key}: {string.Join(", ", grp)}");
    //Console.WriteLine(grp.Key);
}

#endregion

Console.WriteLine("-------------------------------4️. Grouping Methods End-------------------------------");
#endregion


Console.WriteLine("-------------------------------5 Set Operations Start-------------------------------");
Console.WriteLine();
#region 5 Set Operations 

#region  Distinct() – Remove Duplicates 

var uniq =  new List<int>() { 2,3,4,2,3,4,5};

var UniqAns = uniq.Distinct();
Console.WriteLine(string.Join(",",UniqAns));
#endregion

#region  Except() – Elements in First but Not Second

var list1 = new List<int> { 1, 2, 3 ,4, 6, 7, 8};
var list2 = new List<int> { 2, 3, 4, 5, 8, 9, 10 };
var Distinct = list1.Except(list2);
Console.WriteLine(string.Join(", ", Distinct));

#endregion

#region  Intersect() – Common Elements 
var listInter1 = new List<int> { 1, 2, 3, 4, 6, 7, 8 };
var listInter2 = new List<int> { 2, 3, 4, 5, 8, 9, 10 };
var InterSect = listInter1.Intersect(listInter2);
Console.WriteLine(string.Join(", ", InterSect));

#endregion

#region MyRegion

#endregion

Console.WriteLine("-------------------------------5 Set Operations End-------------------------------");
#endregion

Console.WriteLine("-------------------------------6️. Element Access Methods Start-------------------------------");
#region 6️. Element Access Methods 

#region First()

var First = new List<int> { 1, 2, 3, 4, 5, 6 };
var firstlist =  First.First();
Console.WriteLine(firstlist);
#endregion

#region FirstOrDefault()
var FirstOrDefaultList = new List<int>();
Console.WriteLine(FirstOrDefaultList.FirstOrDefault());
#endregion

#region Last
Console.WriteLine(First.Last());
#endregion

#region LastOrDefault
Console.WriteLine(FirstOrDefaultList.LastOrDefault());
#endregion

#region Single
var singlelist = new List<int> { 1 };
Console.WriteLine(singlelist.Single());
#endregion

#region SingleOrDefault
Console.WriteLine(FirstOrDefaultList.SingleOrDefault());
#endregion



Console.WriteLine("-------------------------------6️. Element Access Methods End-------------------------------");
#endregion
