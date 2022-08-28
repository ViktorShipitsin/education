// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

double ArgumentEnter()
{
    double temporary = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return temporary;
}

double[] FunctionImplement(double[] temparray)
{
    double b1 = temparray[0];
    double k1 = temparray[1];
    double b2 = temparray[2];
    double k2 = temparray[3];
    
    double x = 0;
    x = ((-1 * b1) / (-1 * k1)) + ((-1 * b1) % (-1 * k1));
    x = x * -1;
    double y = k2 * x + b2;

    double[] res = new double[2];
        res[0] = x; res[1] = y;

    return res;
}

void PrintResult(double[] res)
{
    Console.Write($"Координаты точки пересечения отрезков: ({res[0]}; {res[1]})");
}

void Main()
{
    double[] temparray = new double[4];
    string[] str = {"b1", "k1", "b2", "k2"};
    
    for (int i = 0; i < temparray.Length; i++)
    {
        Console.Write($"Введите переменную {str[i]}: ");
        temparray[i] = ArgumentEnter();
    }

    double[] res = FunctionImplement(temparray);

    PrintResult(res);
}

Main();