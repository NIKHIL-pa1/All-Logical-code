using LinqWithEntity.Models;

//var employee = new List<Employee>
//{
//    new Employee { Id = 1 ,Name = "Nikhil", DeptId = 1},
//    new Employee { Id = 2, Name = "Sagar", DeptId = 1},
//    new Employee { Id = 3, Name = "C S Job", DeptId = 2},
//    new Employee { Id = 4, Name = "Bibe", DeptId = 4}
//};

//var dept = new List<Department>
//{
//    new Department{ Id = 1 , DeptName = "Dot Net"},
//    new Department { Id = 2 , DeptName = "Dot Net" },
//    new Department { Id = 3 , DeptName = "Angular"}
//};


//// inner join
//var res = from e in employee
//          join d in dept
//          on e.DeptId equals d.Id
//          select new
//          {
//              e.Name,
//              d.DeptName
//          };

//var ans = employee.Join(dept, x => x.DeptId, y => y.Id, (x, y) => new { x.Name, y.DeptName });

//foreach (var item in res)
//{
//  //  Console.WriteLine($"{item.Name} : {item.DeptName}");
//}


////Left join

//var leftjoin = from e in employee
//               join d in dept
//               on e.DeptId equals d.Id
//               into leftJoinGrp
//               from f in leftJoinGrp.DefaultIfEmpty()
//               select new
//               {
//                   e.Name,
//                   deptarr = f?.DeptName
//               };

//foreach (var item in leftjoin)
//{
//    Console.WriteLine($"{item.Name} : {item.deptarr}");
//}



#region Select vs selectmany

//List<List<int>> num = new()
//{
//    new (){1,2},
//    new (){3,4}
//};
//var selectlist = num.Select(x => x).ToList();

//foreach (var list in selectlist)
//{
//    foreach (var n in list)
//        Console.Write(n + " ");
//    Console.WriteLine();
//}
//List<List<int>> num1 = new()
//{
//    new (){1,2},
//    new (){3,4}
//};
//Console.WriteLine();
//var selectManylist = num.SelectMany(x => x).ToList();

//foreach (var list in selectManylist)
//{
//    Console.WriteLine(list);
//}

//var students = new List<Students>
//{
//    new Students{name = "Niks",subjects = new(){"Math","Sci"}},
//    new Students{name = "john", subjects =  new(){"Geo","History"}}
//};

//var studres = students.SelectMany(x => x.subjects).ToList();
//foreach (var student in studres)
//    Console.WriteLine(student);

//class Students
//{
//    public string name { get; set; }
//    public List<string> subjects { get; set; }
//}

#endregion

#region Single vs SingleOrDefault

//var Single = new List<int> { 1, 2, 3, 4, 5 ,1};

////var SinglRes = Single.Single(x => x == 6);
//var SinglDefault = Single.SingleOrDefault(x => x == 7);
//Console.WriteLine(SinglDefault);

#endregion

#region First vs FirstOrDefault

//var firstDemo = new List<int> { 1, 2, 3, 4, 5 ,1 };

/////case 1
//var first = firstDemo.First(x => x > 1);
//Console.WriteLine(first);
//Console.WriteLine(firstDemo.IndexOf(first));

/////case 2
//var case2 = firstDemo.First(x => x == 7);
//Console.WriteLine(case2);



var FirstOrDefault = new List<int> { 1, 2, 3, 4, 5, 6 };

///case 1
var FirstOrDefaultAns = FirstOrDefault.FirstOrDefault(x => x > 2);
Console.WriteLine(FirstOrDefaultAns);

///case 2
var FirstOrDefaultBns = FirstOrDefault.FirstOrDefault(y => y == 8);
Console.WriteLine(FirstOrDefaultBns);

#endregion