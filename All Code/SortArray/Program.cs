int[] arr = { 5, 2, 8, 1, 3 };
// Sort in ascending order manually

//int[] res = Array.Empty<int>();
int ans = 0;

for (int j = 0; j < arr.Length - 1; j++)
{

    for (int i = 0; i < arr.Length - j - 1; i++)
    {
        if (arr[i] > arr[i + 1])
        {
            ans = arr[i];
            arr[i] = arr[i + 1];
            arr[i + 1] = ans;
        }
       
    }
}

foreach(int i in arr)
{
    Console.Write(i + " ");
}