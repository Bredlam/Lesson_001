Console.Write("Введите целое число (тип Строка): ");
string UserInput = Console.ReadLine() ?? "";
int UserNumber = int.Parse(UserInput);
//int UserNumber = int.Parse(Console.ReadLine() ?? "";); - вариант когда мы в качестве параметра для метода .Parse() сразу используем метод .Readlile() 
int Result = UserNumber * UserNumber;
Console.WriteLine("Вывод квадрат числа преобразованных данных (тип Число) = " + Result);
Console.WriteLine(UserInput + " -> " + Result);
Console.WriteLine($"{UserInput} -> {Result}"); // метод интерполяции. Метод позволяющий использовать переменные внутри строки