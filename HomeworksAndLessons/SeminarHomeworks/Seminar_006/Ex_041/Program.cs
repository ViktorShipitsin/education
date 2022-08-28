// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


void Main()
{
    double m = 0;
    double temporary = 0;
    int count = 0;
    Console.Write("Сколько чисел вы хотите ввести? ");
    m = int.Parse(Console.ReadLine());
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите число {i + 1} (из {m}):");
        temporary = int.Parse(Console.ReadLine());
        if (temporary > 0) {count++;}
    }
    Console.Write($"Введено чисел больше 0:  ({count})");
}

Main();