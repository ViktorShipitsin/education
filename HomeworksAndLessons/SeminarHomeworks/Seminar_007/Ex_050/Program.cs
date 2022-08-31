// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] NewFilledArray()
{
    int[,] arr = new int[5, 5];
    return arr;
}

int ArgumentEnter()
{
    int arg = int.Parse(Console.ReadLine());
    return arg;
}

void ArrayCheck(int[,] arr, int x, int y)
{
    if (x > arr.GetLength(0) || y > arr.GetLength(1) || (x < 0 || y < 0))
    {Console.WriteLine("Нет элемента с таким индексом.");}
    else {Console.WriteLine($"Значение элемента: {arr[x, y]}");}
}

void Main()
{
    int[,] arr = NewFilledArray();
    Console.Write("Введите адрес строки: ");
    int x = ArgumentEnter();
    Console.Write("Введите адрес столбца: ");
    int y = ArgumentEnter();
    ArrayCheck(arr, x, y);
}

Main();