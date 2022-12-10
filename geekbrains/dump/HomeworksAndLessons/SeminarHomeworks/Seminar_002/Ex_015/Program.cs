// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void dayWrite()
{
    string[] daysArray = {"пн", "вт", "ср", "чт", "пт", "сб", "вс"};
    int RandomValue = new Random().Next(0, 7);
    Console.WriteLine(daysArray[RandomValue]);
}

dayWrite();