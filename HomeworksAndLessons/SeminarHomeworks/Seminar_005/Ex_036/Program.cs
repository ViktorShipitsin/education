// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] ArrayGenRandom()
{
    int[] arr = new int[10];
    Random randomValue = new Random();
    for (int i = 0; i < arr.Length; i++) {arr[i] = randomValue.Next(1, 11);}
    return arr;
}

int SumUnevenPosition(int[] arr)
{
    int sum = 0;
    int temporary = 0;
    int position = 0;       // Ввёл переменную posirion, поскольку в задании говорилось о позиции, а не индексе или элементе.
    for (int i = 0; i < arr.Length; i++)
    {
        temporary = arr[i];
        position = i + 1;
        if (position % 2 != 0) {sum = sum + temporary;}
    }
    return sum;
}

void PrintResults(int[] arr, int sum)
{
    Console.Write($"Взят массив из десяти чисел:");
    for (int i = 0; i < arr.Length; i++) {Console.Write($" {arr[i]}");}
    Console.WriteLine();
    Console.Write($"Сумма всех чисел, стоящих на нечётных позициях: {sum}");
}

int[] arr = ArrayGenRandom();
int sum = SumUnevenPosition(arr);
PrintResults(arr, sum);