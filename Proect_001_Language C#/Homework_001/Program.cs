// Задача. Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
// Например: 3, 5 -> 243
int[] userArray02 = ControlUserInput04();
double userResult03 = NumPower(userArray02);
ResultOutput04(userArray02, userResult03);

int[] ControlUserInput04() // Определение метода - контроль ввода данных пользователем
{
    int[] array = { 0, 0 };
    for (int i = 1; i < 3; i++)
    {
        while (true)
        {
            Console.Write($"Введите {i}-е число: ");
            if (int.TryParse(Console.ReadLine(), out array[i - 1])) break;
        }

    }
    return array;
}
double NumPower(int[] array) // Определение метода - возведение числа в степень
{
    double result = Math.Pow(array[0], array[1]);
    return result;
}
void ResultOutput04(int[] array, double num) // Определение метода - вывод данных пользователю
{
    Console.WriteLine($"{array[0]}, {array[1]} -> {num}");
}
