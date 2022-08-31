// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] NewFilledArray()
{
    int[,] arr = new int[4, 4];
    Random randomValue = new Random();
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {arr[i, j] = randomValue.Next(-5, 5);}
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] >= 0) {Console.Write($" {arr[i, j]} ");}
            else {Console.Write($"{arr[i, j]} ");}
        }
        Console.WriteLine();
    }
}

void PrintColArithmeticMean(int[,] arr)
{
    int arMean = 0;
    Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");
    for (int col = 0; col < arr.GetLength(0); col++)
    {
        for (int row = 0; row < arr.GetLength(1); row++)
        {
            arMean = arMean + arr[row, col];
        }
        if (arMean >= 0) {Console.Write($" {arMean} ");}
        else {Console.Write($"{arMean} ");}
        arMean = 0;
    }
}

void Main()
{
    int[,] arr = NewFilledArray();
    PrintArray(arr);
    PrintColArithmeticMean(arr);
}

Main();