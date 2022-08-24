// 0. Вывести квадрат числа.

double SqrtMethod(double x, double y)
    {
        return Math.Pow(x, y);
    }

int x = new Random().Next(1,10);
int y = 2;

Console.WriteLine(SqrtMethod(x, y));