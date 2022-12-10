// Упорядочить массив
int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < arr.Length; j++)
        { if (arr[j] < arr[minPosition]) minPosition = j; }

        int temporary = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);