// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void MassiveInitAndConsolWrite()
{
    int[] matrix = new int[8];
    for (int i = 0; i < matrix.Length; i++)
    {
        Console.Write($"{matrix[i]} ");
    }
}

MassiveInitAndConsolWrite();