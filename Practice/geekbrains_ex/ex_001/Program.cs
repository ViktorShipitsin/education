// 1. По двум заданным числам проверять является ли первое квадратом второго.

void SqrtCompare(int x, int y)
{
    if (y == x*x)
    {
        Console.Write(" Да, является.");
    }
    else
    {
        Console.Write(" Нет, не является.");
    }
}

void TextConclusion(int x, int y)
{
    Console.Write("Является ли число ");
    Console.Write(y);
    Console.Write(" корнем числа ");
    Console.Write(x);
    Console.Write("?");
}

int x = new Random().Next(1, 10);
int y = new Random().Next(1, 101);

TextConclusion(x, y);
SqrtCompare(x, y);