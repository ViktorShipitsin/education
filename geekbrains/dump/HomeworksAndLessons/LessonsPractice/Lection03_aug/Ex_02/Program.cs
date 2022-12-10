// Метод №2
void Method2v1(string msg)
    {
        Console.WriteLine(msg);
    }

Method2v1("Этот метод не возвращает никаких данных.");

void Method2v2(string msg, int count)
    {
        int i = 0;
        while (i < count)
            {
                Console.WriteLine(msg + "x" + (i+1));
                i++ ;
            }
    }

Method2v2("И повтор!", 3);
Method2v2(count: 1, msg: "Ну, закрепили.");