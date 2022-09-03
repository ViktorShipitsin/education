// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] NewFilledArray()
{
    int[,] arr = new int[3, 6];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Random.Shared.Next(1, 10);
        }
    }
    return arr;
}

string TextWrite(int x)
{
    string s00 = "Массив задан:";
    string s01 = "Вывод нужной строки:";

    string reqStr = String.Empty;
    if (x == 0) {reqStr = s00;}
    if (x == 1) {reqStr = s01;}

    return reqStr;
}

void ArrayConsoleWrite(int[,] arrOld, int[] arrNew)
{
    Console.WriteLine(TextWrite(0));
    BiDimArrayConsoleWrite(arrOld);

    Console.WriteLine(TextWrite(1));
    OneDimArrayConsoleWrite(arrNew);
}

void OneDimArrayConsoleWrite(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {Console.Write($"{arr[i]} ");}
    Console.WriteLine();
}

void BiDimArrayConsoleWrite(int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int col = 0; col < arr.GetLength(1); col++)
        {
        Console.Write($"{arr[row, col]} ");
        }
        Console.WriteLine();
    }
}

int[] RowOut(int[,] arr)
{
    int[] rowTarget = new int[arr.GetLength(1)];
    bool start = true;
    int Sum = 0;
    int newSum = 0;
    int desRow = 0;

    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int col = 0; col < arr.GetLength(1); col++)
        {
            newSum += arr[row, col];
            if (start)
            {
                Sum = newSum;
                start = false;
            }
        }
        if (newSum < Sum)
        {desRow = row;}
    }

    for (int i = 0; i < arr.GetLength(1); i++)
    {rowTarget[i] = arr[desRow, i];}

    return rowTarget;
}

void Main()
{
    int [,] arrOld = NewFilledArray();
    int[] arrNew = RowOut(arrOld);

    ArrayConsoleWrite(arrOld, arrNew);
}

Main();