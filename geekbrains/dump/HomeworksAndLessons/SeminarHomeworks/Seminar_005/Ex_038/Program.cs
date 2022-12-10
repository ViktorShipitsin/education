// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] ArrayGenRandom()
{
    double[] arr = new double[3];
    Random randomValue = new Random();
    for (int i = 0; i < arr.Length; i++) {arr[i] = randomValue.Next(-100, 101);}
    return arr;
}

double DifMaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) {max = arr[i];}
        if (arr[i] < min) {min = arr[i];}
    }
    double dif = max - min;
    return dif;
}

void Main()
{
    double[] arr = ArrayGenRandom();
    double dif = DifMaxMin(arr);
    Console.Write("Создан массив из элементов:");
    for (int i = 0; i < arr.Length; i++) {Console.Write($" {arr[i]}");}
    Console.WriteLine();
    Console.Write($"Найдена разность между наибольшим и наименьшим элементом массива, которая составляет: {dif}");
}

Main();