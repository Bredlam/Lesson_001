namespace Lesson_019;
class Program
{
    static void Main(string[] args)
    {   // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
        // Примеры: 14212 -> нет ... 23432 -> да
        Console.Clear();

        int userNum = ControlUserInput(); // Вызов метода
        CalculationPalindrome(userNum) // Вызов метода
;
        static int ControlUserInput() // Определение метода - контроль ввода пятизначного числа      
        {
            while (true)
            {
                Console.Write("Введите целое пятизначное число: ");
                if ((int.TryParse(Console.ReadLine(), out int userInt)))
                {
                    int controlInt = 0;
                    int coint = userInt;
                    while (coint > 0)
                    {
                        controlInt++;
                        coint /= 10;
                    }
                    if (controlInt == 5)
                    {
                        return userInt;
                    }
                }
                Console.WriteLine("Ошибка. Введите целое пятизначное число!");
            }
        }
        static void CalculationPalindrome(int userNum) // Определение метода - вычисление палиандрома
        {
            if (userNum / 10000 == userNum % 10 && userNum / 1000 % 10 == userNum / 10 % 10)
                Console.Write($"{userNum} -> Да");
            else
                Console.Write($"{userNum} -> Нет");
        }
    }
}