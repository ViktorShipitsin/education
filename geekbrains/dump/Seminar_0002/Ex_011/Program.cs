// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int random(){
    Random rnd = new Random();
    int a = rnd.Next(100, 999);
    return a;
}

int razdel (int a) {
    int x = a%10;
    int y = a/100;
    return y*10+x;
}

void vivod (int a, int z) {
    Console.WriteLine("случайное число " + a);
    Console.WriteLine(z);
}