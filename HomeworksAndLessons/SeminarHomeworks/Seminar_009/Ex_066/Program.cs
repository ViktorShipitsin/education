// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int IntSumOfArithmeticProgr(int m, int n)
{
    int sum = ((n / 2) + (n % 2)) * (2 * m + 1 * (n - 1));
    return sum;
}

void Main()
{
    Console.Write("Введите число m: ");
    int m = Int32.Parse(Console.ReadLine()!);

    Console.WriteLine();

    Console.Write("Введите число n: ");
    int n = Int32.Parse(Console.ReadLine()!);

    Console.WriteLine($"Сумма всех элементов: {IntSumOfArithmeticProgr(m, n)}");
}

Main();