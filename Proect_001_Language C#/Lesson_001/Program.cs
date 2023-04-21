Console.Clear();
// Урок разбирал препод - я писал за ним
Console.WriteLine("Задача №1 ");
Console.Write("Введите целое число (тип Строка): ");
string UserInput = Console.ReadLine() ?? "";
int UserNumber = int.Parse(UserInput);
//int UserNumber = int.Parse(Console.ReadLine() ?? "";); - вариант когда мы в качестве параметра для метода .Parse() сразу используем метод .Readlile() 
int Result = UserNumber * UserNumber;
Console.WriteLine("Вывод квадрат числа преобразованных данных (тип Число) = " + Result);
Console.WriteLine(UserInput + " -> " + Result);
Console.WriteLine($"{UserInput} -> {Result}"); // метод интерполяции. Метод позволяющий использовать переменные внутри строки

// Напишите программу, которая на вход принимает два числа 
// и проверяет, является ли первое число квадратом второго.
Console.WriteLine(" ");
Console.WriteLine("Задача №2 ");
Console.Write("Введите 1-е число - ");
int UserInputA = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите 2-е число - ");
int UserInputB = int.Parse(Console.ReadLine() ?? "");

int Result1 = UserInputA / UserInputB;
if (Result1 == UserInputB)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

// Напишите программу, которая будет выдавать название
// дня недели по заданному номеру за интервал номеров
// дней недели заступать нельзя
Console.WriteLine(" ");
Console.WriteLine("Задача №3 ");
Console.Write("Введите день недели ");
int UserInputС = int.Parse(Console.ReadLine() ?? "");
if (UserInputС > 0 & UserInputС < 8)
{
    if (UserInputС == 1) Console.Write("Понедельник");
    else if (UserInputС == 2) Console.Write("Вторник");
    else if (UserInputС == 3) Console.Write("Среда");
    else if (UserInputС == 4) Console.Write("Четверг");
    else if (UserInputС == 5) Console.Write("Пятница");
    else if (UserInputС == 6) Console.Write("Суббота");
    else if (UserInputС == 7) Console.Write("Воскресенье");
}
else
{
    Console.Write("Вы ввели неверные данные");
}