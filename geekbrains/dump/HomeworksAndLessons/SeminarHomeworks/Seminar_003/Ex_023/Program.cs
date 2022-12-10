// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int n = new Random().Next(1, 100);

void CubeDigit(int n)
{
    for (int i =1; i <= n; i++)
    {
        Console.Write($"{i*i*i} ");
    }
}

Console.WriteLine(n);
CubeDigit(n);