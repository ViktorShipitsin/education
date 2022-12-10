// 2. Даны два числа. Показать большее и меньшее число.

int value1 = new Random().Next(1, 1000);
int value2 = new Random().Next(1, 1000);

void FindingSuperiorValue(int value1, int value2)
{
    if (value1 > value2)
    {
        Console.Write(" первое число, или " + value1 + ".");
    }
    else
    {
        Console.Write(" второе число, или " + value2 + ".");
    }
}

Console.Write("Из чисел " + value1 + " и " + value2 + " наибольшим является");
FindingSuperiorValue(value1, value2);