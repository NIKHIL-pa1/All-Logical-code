//List<Employee> emp = new List<Employee>();
//emp.Add(new Employee() { name = "Max"});
//emp.Add(new Employee() { name = "Niks"});


//Console.WriteLine(emp.Count);

//foreach (Employee item in emp)
//{
//    Console.WriteLine(item.name);
//}

//class Employee
//{
//    public string? name { get; set; }
//}

#region Generic collections

#region ArrayList

using System.Collections;
using System.Collections.Generic;

//ArrayList list = new ArrayList();
//list.Add("Niks");
//list.Add(20);
//list.Add(2.3);
//list.Add(true);

////int a = (int)list[0]; // runtime error 
//int b = (int)list[1];
//Console.WriteLine(b);

#endregion

#region hashTable
//Hashtable ht = new Hashtable();
//ht.Add(1, "Nikhil");
//ht.Add("age", 25);

//Console.WriteLine(ht["age"]);


#endregion


#endregion

#region Non Generic Collections

#region 1. List<T>


//List<int> list = new List<int>();
//list.Add(10);
//list.Add(20);
//list.Add(30);

//int a = list[0];
//Console.WriteLine(a);
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}



#endregion

#region  2. Dictionary<TKey, TValue>

//Dictionary<int,string> dict = new Dictionary<int,string>();
//dict.Add(10, "nikhil");
//dict.Add(20, "John");
//Console.WriteLine(dict[10]);

//foreach (var item in dict)
//{
//    Console.WriteLine(item.Value);
//}
//#endregion

//#region 3. Stack<T> LIFO

//Stack<int> stack = new(); 
//stack.Push(10);
//stack.Push(20);
//stack.Push(30);

//Console.WriteLine(stack.Pop());

//foreach (var item in stack)
//{
//    Console.WriteLine(item);
//}
#endregion

#region 4. Queue<T> (FIFO)

//Queue<int> queue = new Queue<int>();
//queue.Enqueue(10);
//queue.Enqueue(20);
//queue.Enqueue(30);



//Console.WriteLine(queue.Peek());
//Console.WriteLine("hi"+queue.Dequeue());

//foreach (var item in queue)
//{
//    Console.WriteLine(item);
//}

#endregion

#region 5. LinkedList<T>

//LinkedList<int> ints = new LinkedList<int>();

//ints.AddFirst(10);
//ints.AddAfter(ints.First,11);
//ints.AddAfter(ints.Last,12);
//ints.AddAfter(ints.Last,14);
//ints.AddAfter(ints.Last,15);
//ints.AddAfter(ints.Last,16);

//LinkedListNode<int> find = ints.Find(12);

//ints.AddBefore(find,12);




////ints.AddAfter(ints.)

//foreach (var item in ints)
//{
//    Console.WriteLine(item);
//}

#endregion

#region 6. hashSet

HashSet<int> set = new HashSet<int>();
set.Add(1);
set.Add(2);
set.Add(1);

foreach (var item in set)
{
    Console.WriteLine(item);
}



#endregion

#region 7. Sortedlist

SortedList<int,string> sortedlist = new();

sortedlist.Add(1, "Niks");
sortedlist.Add(2, "Sam");

foreach (var item in sortedlist)
{
    Console.WriteLine(item.Key);
}

#endregion



#endregion