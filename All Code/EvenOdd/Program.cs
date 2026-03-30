int[] arr = { 2, 5, 6, 7, 8 };


for (int i = 0; i < arr.Length; i++)
{
	if (arr[i] % 2 != 0)
	{
		Console.WriteLine("the " + arr[i] + " is odd number");
	}
	else 
        Console.WriteLine("the " + arr[i] +" is even number");
}

int num = 15;

if (num%3 == 0 && num % 5 == 0)
{
    Console.WriteLine(true);
}else
	Console.WriteLine(false);