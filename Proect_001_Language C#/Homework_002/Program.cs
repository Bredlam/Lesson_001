// Задача. Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
// Например: 452 -> 11
int ControlUserInput05() // Определение метода - контроль ввода данных пользователя
{
    while (true)
    {
        Console.Write("Введите целое число: ");
        if (int.TryParse(Console.ReadLine(), out int userNum))
            return userNum;
        Console.WriteLine("Ошибка! Введите целое число: ");
    }
}
int SummNumOfTally(int num) // Определение метода - вычисление суммы цифр числа
{
    int result = 0;
    int numLenght = num.ToString().Length;
    for (int i = 0; i < numLenght; i++)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}
void ResultOutput05(int num, int result) // Определение метода - вывод данных пользователю
{
    System.Console.WriteLine($"{num} -> {result}");
}

int userNum03 = ControlUserInput05();
int userResult04 = SummNumOfTally(userNum03);
ResultOutput05(userNum03, userResult04);