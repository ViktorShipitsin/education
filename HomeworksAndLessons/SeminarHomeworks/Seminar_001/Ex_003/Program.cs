// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


// Условно взятые числа.
int a = 2;
int b = 3;
int c = 7;

int max_value = a;
string max = "a";

if (a < b)
    {max = "b";
    max_value = b;}

if (b < c)
    {max = "c";
    max_value = c;}

Console.Write(max);
Console.Write(", равное ");
Console.Write(max_value);