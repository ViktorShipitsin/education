// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] ArrayGenRandom()
{
    int[] arr = new int[8];
    Random randomValue = new Random();
    for (int i = 0; i < arr.Length; i++) {arr[i] = randomValue.Next(100, 1000);}
    return arr;
}

void PrintArray()
{
    int[] arr = ArrayGenRandom();
    int count = 0;
    Console.Write("Создан числовой массив из 8-ми индексов, со следующим содержанием: ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) {count++;}
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
    Console.Write($"Количество чётных чисел в массиве: {count}");
}

PrintArray();