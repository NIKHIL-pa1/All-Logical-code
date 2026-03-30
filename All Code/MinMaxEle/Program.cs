
int[] arr = { 12, 2, 6  3, 4, 6 };

int max = arr[0];
int min = arr[0];
for (int i = 0; i < arr.Length; i++)
{

    if (arr[i] > max)
    {
        max = arr[i];
        
    }

    if (arr[i] < min)
    {
        min = arr[i]; 
    }


}
Console.WriteLine("max ele is " + max);
Console.WriteLine("min ele is " + min);