// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void MethodExample(int a, int b)
{
    double c = a;
    for (int i = 1; i < b; i++)
    {
        c = c * a;
    }
    Console.Write($"Число {a} возведено в степень {b}, результатом возведения является: {c}.");
}

int a = new Random().Next(1, 10);
int b = new Random().Next(2, 10);

MethodExample(a, b);