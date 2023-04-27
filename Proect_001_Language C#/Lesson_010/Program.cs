// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа
// Например: 456 -> 5 ... 782 -> 8 ... 917 -> 1
Console.Clear();
int UserInt;
Console.Write("Введите целое трехзначное число: ");
    while (true)
    {
        if ((int.TryParse(Console.ReadLine(), out UserInt)))
        {
            int ControlInt = 0;
            int coint = UserInt;
            while (coint > 0)
            {
                ControlInt++;
                coint/=10;
            }
            if (ControlInt == 3) break;        
        }
        Console.WriteLine("Ошибка. Введите целое трехзначное число!");
    }

int OstInt = UserInt % 100 / 10;

Console.WriteLine($"Результат: {OstInt}");