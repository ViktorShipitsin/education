// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

double A(double m, double n)
{
    if (n == 0) return m + 1;
    if (m == 0) return A(n - 1, m);
    return A(n - 1, A(n, m - 1));
}

void Main()
{
    Console.Write("Введите число m: ");
    int m = Int32.Parse(Console.ReadLine()!);

    Console.WriteLine();

    Console.Write("Введите число n: ");
    int n = Int32.Parse(Console.ReadLine()!);

    bool DigCorrect = true;
    if (m < 0) {Console.WriteLine("Число m является отрицательным."); DigCorrect = false;}
    if (n < 0) {Console.WriteLine("Число n является отрицательным."); DigCorrect = false;}

    if (DigCorrect) Console.WriteLine(A(m, n));
}

Main();