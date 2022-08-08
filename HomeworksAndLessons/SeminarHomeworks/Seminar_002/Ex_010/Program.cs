// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

string string1 = "Взято случайное трёхзначное число: ";
string string2 = "Второй цифрой числа является: ";

int RandomValue = new Random().Next(100, 1000);
int x = ( RandomValue - ( RandomValue / 100 * 100 ) ) / 10;

Console.WriteLine(string1 + RandomValue);
Console.WriteLine(string2 + x);
