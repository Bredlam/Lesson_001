// Напишите программу, которая на вход принимает число N,
// а на выходе показывает все четные числа от 1 до N
Console.Clear();
Console.Write("Введите число: ");
int UserInt = int.Parse(Console.ReadLine() ?? "");

int count1 = 0;
int Result = UserInt % 2;
while (count1 < UserInt - Result)
{
    count1 += 2;
    Console.Write(count1 + " ");    
}