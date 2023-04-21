// Напишите программу, которая на вход принимает два числа 
// и проверяет, является ли первое число квадратом второго.
Console.Write("Введите 1-е число - ");
int UserInputA = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите 2-е число - ");
int UserInputB = int.Parse(Console.ReadLine() ?? "");

int Result = UserInputA / UserInputB;
if (Result == UserInputB)
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

Console.Write("Введите день недели ");
int UserInput = int.Parse(Console.ReadLine() ?? "");
if (UserInput > 0 & UserInput < 8)
{
   if (UserInput == 1) Console.Write("Понедельник");
   if (UserInput == 2) Console.Write("Вторник");
   if (UserInput == 3) Console.Write("Среда");
   if (UserInput == 4) Console.Write("Четверг");
   if (UserInput == 5) Console.Write("Пятница");
   if (UserInput == 1) Console.Write("Суббота");
   if (UserInput == 1) Console.Write("Воскресенье");    
}
else
{
    Console.Write("Вы ввели неверные данные");
}