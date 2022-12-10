// Метод №4
string Method4(int count, string text)
    {
        string result = "";         // String.Empty
        for (int i = 0; i < count; i++)
            {
                result = result + text;
            }
        return result;
    }

string res = Method4(10, "Этот метод и принимает, и возвращает некоторые данные. ");
Console.WriteLine(res);