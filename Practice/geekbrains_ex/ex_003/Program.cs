// 3. По заданному номеру дня недели вывести его название.

int specifiednumber = new Random().Next(1, 10);
string[] DayOfWeekName = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"};

if (specifiednumber > 7 ^ specifiednumber < 1)
{
    Console.WriteLine("Нет такого дня недели.");
}
else
{
    Console.WriteLine(DayOfWeekName[specifiednumber - 1]);
}