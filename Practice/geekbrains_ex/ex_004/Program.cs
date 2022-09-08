// Найти максимальное из трех чисел.

int ValuesCreate()
{
    int value = Random.Shared.Next(10, 100);

    return value;
}

void DigitMaxSearch()
{
    int a = ValuesCreate();
    int b = ValuesCreate();
    int c = ValuesCreate();

    Console.WriteLine($"Получены числа: {a}, {b}, {c}.");
    
    int max = a;
    if (max < b) {max = b;}
    if (max < c) {max = c;}

    Console.Write($"Наибольшим из чисел является {max}.");
}

DigitMaxSearch();