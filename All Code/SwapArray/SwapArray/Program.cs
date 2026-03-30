
int[] numbers = { 4, 2, 7, 1, 3 };

// Step 2: Get the length of the array
int n = numbers.Length;

// Step 3: Outer loop controls the number of passes
for (int i = 0; i < n - 1; i++) //
{
    // Step 4: Inner loop compares adjacent elements
    for (int j = 0; j < n - 1 - i; j++)
    {
        // Step 5: If left element is bigger, swap them
        if (numbers[j] > numbers[j + 1])
        {
            // Swap logic
            int temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
        }
    }
}

// Step 6: Print the sorted array
Console.WriteLine("Sorted array:");
foreach (int num in numbers)
{
    Console.Write(num + " ");
}