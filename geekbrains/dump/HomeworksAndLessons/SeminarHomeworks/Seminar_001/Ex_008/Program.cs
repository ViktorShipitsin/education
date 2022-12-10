// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Условно взятое число.
int N = 5;

int count = N;
int remain = 0;

while (count > 1)
    {remain = count % 2;
        if (remain == 0)
            Console.WriteLine(count);
    count = count - 1;}
