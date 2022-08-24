// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double x1 = new Random().Next(1, 100);
double y1 = new Random().Next(1, 100);
double z1 = new Random().Next(1, 100);

double x2 = new Random().Next(1, 100);
double y2 = new Random().Next(1, 100);
double z2 = new Random().Next(1, 100);

double result = 0;

double PifagorMethod(double x1, double y1, double z1, double x2, double y2, double z2)
{
    result = Math.Sqrt(Math.Sqrt(Math.Abs(x1 - x2)) + Math.Sqrt(Math.Abs(y1 - y2)) + Math.Sqrt(Math.Abs(z1 - z2))); //Без модуля result получает отрицательное значение. Что делать?
    return result;
}

void WriteResult(double result)
{
    Console.WriteLine($"Взяты случайные точки с координатами ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}).");
    Console.WriteLine($"Расстояние между точками равно: {result}");
}

PifagorMethod(x1, y1, z1, x2, y2, z2);
WriteResult(result);
