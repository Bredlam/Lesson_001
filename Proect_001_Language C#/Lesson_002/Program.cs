// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Введите первое число: ");
int FirstInt = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите второе число: ");
int SecondtInt = int.Parse(Console.ReadLine() ?? "");

if (FirstInt > SecondtInt)
{
    Console.Write($"max = {FirstInt}");
}
else
{
    Console.Write($"max = {SecondtInt}");
}