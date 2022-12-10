// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

class Program
{
    static public void Main()
    {
        int start = -10;
        int m = ValuesGenerate(start);
        start = m;
        int n = ValuesGenerate(start);

        for (int i = m; i <= n; i++)
        {
            if (i > 0) Console.Write($"{i} ");
        }
    }
    
    static public int ValuesGenerate(int start)
    {
        int x = new Random().Next(start, start + 100);
        return x;
    }
}