// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
Console.Clear();

Console.Write("Введите первое число: ");
string FirstInput = Console.ReadLine() ?? "";
int FirstInt = int.Parse(FirstInput);

Console.Write("Введите второе число: ");
string SecondInput = Console.ReadLine() ?? "";
int SecondInt = int.Parse(SecondInput);

Console.Write("Введите третье число: ");
string ThirdInput = Console.ReadLine() ?? "";
int ThirdInt = int.Parse(ThirdInput);

int MaxInt = FirstInt;
if (MaxInt < SecondInt) MaxInt = SecondInt;
if (MaxInt < ThirdInt) MaxInt = ThirdInt;

Console.Write($"Максимальное число = {MaxInt}");