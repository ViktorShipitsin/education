// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int DigLength(int n)
{
    int length = 1;
    for (int i = n; i > 10; i = i / 10) {length++;}
    return length;
}

void DigitSum(int n)
{
    int x = 0;
    int temporary = n;
    int length = DigLength(n);

    for (int i = 0; i < length; i++)
    {
        x = x + (temporary % 10);
        temporary = temporary / 10;
    }
    Console.WriteLine($"Взято число: {n}, сумма цифр этого числа равна: {x}.");
}

int n = new Random().Next(10, 10000);
DigitSum(n);