// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int RandomValue = new Random().Next(1, 1000000);

string strThirdDigit = RandomValue.ToString();

Console.Write("Взятое число: ");
Console.WriteLine(RandomValue);
Console.Write("Третья цифра взятого числа: ");
Console.WriteLine(strThirdDigit[2]);