using LinQ_Practice;

public class MyClass
{
    static void Main(string[] args)
    {
        var employees = new List<Employee>
        {
            new Employee { Id=1, Name="Nikhil", Department="IT", Salary=60000, Age=25 },
            new Employee { Id=2, Name="Rahul", Department="HR", Salary=45000, Age=28 },
            new Employee { Id=3, Name="Amit", Department="IT", Salary=89000, Age=30 },
            new Employee { Id=4, Name="Sneha", Department="Finance", Salary=45000, Age=27 },
            new Employee { Id=5, Name="Pooja", Department="HR", Salary=50000, Age=26 },
            new Employee { Id=6, Name="Karan", Department="IT", Salary=90000, Age=30 }
        };



        //FilterRec(employees);

        //SecoHighestSal(employees);

        //AvgSalOfItDept(employees);

        //DuplicateSal(employees);
        AvgSalOfItDept2(employees);


    }

    static void FilterRec(List<Employee> emp)
    {
        var ans1 = emp.Where(x => x.Id == 1).ToList();

        var ans2 = emp.Where(x => x.Department == "IT").Select(x => new
        {
            x.Name,
            x.Salary
        });

        foreach (var item in ans2)
            Console.WriteLine(item.Name + " " + item.Salary);


    }

    static void SecoHighestSal(List<Employee> emp)
    {
        var maxSal = emp.Max(x => x.Salary);
        //Select ke baad jo return hota hai, wahi next variable ka type hota ha
        var res = emp.Select(x => new { x.Salary, x.Name }).Distinct().OrderByDescending(x => x.Salary).Skip(1).FirstOrDefault();
        Console.WriteLine(res);
    }

    static void AvgSalOfItDept(List<Employee> emp)
    {
        var resp = emp.Where(x => x.Department == "IT").Average(x => x.Salary);
        Console.WriteLine(resp);
    }

    static void DuplicateSal(List<Employee> emp)
    {
        var sal = emp.GroupBy(x => x.Salary).Where(y => y.Count() > 1).Select(x => x.Key).ToList();
    }


    static void AvgSalOfItDept2(List<Employee> emp)
    {
        Console.WriteLine(resp);
    }
}

