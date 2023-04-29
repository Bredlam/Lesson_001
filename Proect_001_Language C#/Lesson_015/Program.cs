
int number = 456789;
int result = 0;
int y = number.ToString().Length;

for (int i = 0; i < y; i++)
{
    result += number % 10;
    number /= 10;
}
Console.WriteLine(result);


