// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Например: 645 -> 5 ... 78 -> третьей цифры нет ... 32679 -> 6
Console.Clear();
int UserInt;
Console.Write("Введите целое число: ");
while (true) // Проверка на ввод целого числа
{
    if ((int.TryParse(Console.ReadLine(), out UserInt)))
    {
        break;
    }
    Console.Write("Ошибка. Введите целое число!:");
}

int Сount = 0;
int TmpInt01 = UserInt;
while (TmpInt01 > 0) // Вычисляем сколько знаков в числе
{
    Сount++;
    TmpInt01 /= 10;
}

if (Сount >= 3) // Вычисляем 3-ю цифру если число хотя бы трехзначное
{
    int TmpInt02 = UserInt;
    while (TmpInt02 >= 1000)
    {
        TmpInt02 /= 10;
    }
    int OstInt = TmpInt02 % 10;

    Console.WriteLine($"{UserInt} -> {OstInt}");
}
else // Отказ
{
    Console.WriteLine($"{UserInt} -> третьей цифры нет");
}