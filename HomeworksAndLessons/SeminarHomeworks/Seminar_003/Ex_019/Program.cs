// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int[] ArrayFilledUp(int[] arr, int RandomValue)
{
    int x = RandomValue;
    int temporary = x;
    for (int i = 0; i < arr.Length; i++)
    {
        temporary = x % 10;
        x = x / 10;
        arr[arr.Length - 1 - i] = temporary;
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    Console.Write(", состоящее из цифр: ");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void PalindromeCheck(int[] arr)
{
    bool palindrome = true;
    int center = arr.Length / 2 + arr.Length % 2;
    for (int count = 0; count < center; count++)
    {
        int i = 0 + count;
        int j = arr.Length - 1 - count;
        if (arr[i] != arr[j])
            {
            palindrome = false;
            continue;
            }
    }
    if (palindrome == false) {Console.WriteLine("Это число не является палиндромом.");}
    else {Console.WriteLine("Это число является палиндромом.");}
}

int RandomValue = new Random().Next(10000, 100000);
int[] arr = new int[5];

Console.Write("Взято случайное число: " + RandomValue);
ArrayFilledUp(arr, RandomValue);
PrintArray(arr);
PalindromeCheck(arr);