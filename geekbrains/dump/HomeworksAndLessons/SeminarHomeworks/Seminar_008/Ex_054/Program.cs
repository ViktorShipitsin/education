// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] NewFilledArray()
{
    
    int[,] arr = new int[2, 5];
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int col = 0; col < arr.GetLength(1); col++)
            {arr[row, col] = Random.Shared.Next(-100, 101);}
    }

    return arr;
}

int[,] ArraySort(int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int curCol = 0; curCol < arr.GetLength(1) - 1; curCol++)
        {
            int minPos = curCol;
            
            for (int nextCol = curCol + 1; nextCol < arr.GetLength(1); nextCol++)
            {
                if (arr[row, nextCol] > arr[row, minPos]) minPos = nextCol;
            }

            int temporary = arr[row, curCol];
            arr[row, curCol] = arr[row, minPos];
            arr[row, minPos] = temporary;
        }
    }
    return arr;
}

void ArrayPrint(int[,] arr, bool hasArr)
{
    if (hasArr == false) {Console.Write("Массив задан:");}
    if (hasArr == true) {Console.Write("Массив отсортирован:");}
    Console.WriteLine();
    
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int col = 0; col < arr.GetLength(1); col++)
        {
            if (arr[row, col] >= 0) {Console.Write($" {arr[row, col]} ");}
            else {Console.Write($"{arr[row, col]} ");}
        }
        Console.WriteLine();
    }
}

void Main()
{
    int[,] arr = NewFilledArray();
    ArrayPrint(arr, false);
    
    arr = ArraySort(arr);
    ArrayPrint(arr, true);
}

Main();