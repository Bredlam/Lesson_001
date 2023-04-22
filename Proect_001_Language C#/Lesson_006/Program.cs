// Напишите программу, которая на вход принимает число и выдает, 
// является ли число четным т.е. делится ли оно на два без остатка
Console.Clear();

Console.Write("Введите число: ");
int FirstInt = int.Parse(Console.ReadLine() ?? "");

if (FirstInt % 2 == 0)
{
    Console.Write($"Число -> {FirstInt} является четным");
}
else
{
    Console.Write($"Число -> {FirstInt} НЕ является четным");
}