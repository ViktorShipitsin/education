// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] NewArray(int m, int n)
{
    double[,] arr = new double[m, n];
    return arr;
}

double[,] ArrayFilledUp(double[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int col = 0; col < arr.GetLength(1); col++)
            arr[row, col] = Random.Shared.Next(-100, 101);
    }
    return arr;
}

void ArrayConsoleWrite(double[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        Console.Write($"{arr[row, 0]} ");
    }
    Console.WriteLine();
    for (int col = 0; col < arr.GetLength(0); col++)
    {
        Console.Write($"{arr[0, col]} ");
    }
}

string ConsoleText(string strText)
{
    string strError = "Непредвиденная ошибка в методе ConsoleWrite().";
    
    string strStart0 = "Инициализация массива. ";
    string strStart1 = "Введите требуемое число строк массива: ";
    string strStart2 = "Введите требуемое число столбцов массива: ";

    if (strText == "start0") {return strStart0;}
    if (strText == "start1") {return strStart1;}
    if (strText == "start2") {return strStart2;}
    else {return strError;}
}

int ValueEnter()
{
    int a = int.Parse(Console.ReadLine());
    return a;
}

void Main()
{
    string strText = "start0";
    ConsoleText(strText);

    strText = "start1";
    Console.WriteLine(ConsoleText(strText));
    int m = ValueEnter();

    strText = "start2";
    Console.WriteLine(ConsoleText(strText));
    int n = ValueEnter();

    double[,] arr = NewArray(m, n);
    arr = ArrayFilledUp(arr);
    ArrayConsoleWrite(arr);
}

Main();