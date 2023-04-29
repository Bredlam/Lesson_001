// УРОК 4. Лекция. Рекурсия и двумерные массивы
Console.Clear();
TwoDimensionalStringArray();
void TwoDimensionalStringArray() // Определение метода - пример двумерного строкового массива
{
    string[,] table = new string[2, 2]; // двумерный строковой массив, где у нас 2 - строки и 2 - столбцы
    table[0, 0] = "ДобавленныеДанные"; // пример записи в двумерном массиве по нужному адресу
    for (int rows01 = 0; rows01 < table.GetLength(0); rows01++) // этот цикл обходит строки
    {
        for (int colums01 = 0; colums01 < table.GetLength(1); colums01++) // этот цикл обходит столбцы
        {
            Console.Write($"-{table[rows01, colums01]}+ СдМ ");
        }
        Console.WriteLine();
    }
}

TwoDimensionalIntegerArray();
void TwoDimensionalIntegerArray() // Определение метода - пример двумерного числового массива
{
    int[,] matrix = new int[4, 4]; // двумерный числовой массив, где у нас 2 - строки, 2 - столбцы
    matrix[0, 0] = 888; // пример записи в двумерном массиве по нужному адресу
    for (int rows02 = 0; rows02 < matrix.GetLength(0); rows02++) // этот цикл обходит строки
    {
        for (int colums02 = 0; colums02 < matrix.GetLength(1); colums02++) // этот цикл обходит столбцы
        {
            if (matrix[rows02, colums02] == 0)
                matrix[rows02, colums02] = new Random().Next(100, 1000); // не забывай, что вторая цифра не включается в интервал т.е. [100,1000)
            Console.Write($"{matrix[rows02, colums02]} ");
        }
        Console.WriteLine();
    }
}

// Задача. "Закрасить область". Отрабатываем эффект рекурсии
int[,] pic = new int[,] // Фиксированные данные поэтому двумерный диапазон не указываем
{
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
 {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};
PrintArray(pic); // Вызов метода
FullImage(13, 13); // Вызов метода
PrintArray(pic); // Вызов метода
void PrintArray(int[,] matr) // Определение метода - опрделяем контур картинки
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == 0) Console.Write(" ");
            else Console.Write("+");
        }
        Console.WriteLine();
    }
}
void FullImage(int row, int col) // Определение метода - закрашиваем картинку
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FullImage(row - 1, col);
        FullImage(row, col - 1);
        FullImage(row + 1, col);
        FullImage(row, col + 1);
    }
}

// Задача. Вычисление факториала. Отрабатываем эффект рекурсии
int Factorial01(int n) // Определение метода - вычисление факториала, работаем с типом int
{
    if (n == 1) return 1;    // 1! = 1 (читается как: факториал единицы равен единице)
                             // Кстати, в общем случае 0! = 1
    else return n * Factorial01(n - 1);
}
double Factorial02(double n) // Определение метода - вычисление факториала, работаем с типом double
{
    if (n == 1) return 1;    // 1! = 1 (читается как: факториал единицы равен единице)
                             // Кстати, в общем случае 0! = 1
    else return n * Factorial02(n - 1);
}
//Console.WriteLine(Factorial(3)); // Вывод на печать + вызов метода
// ПодЗадача. Вычисление факториала. Отрабатываем проблему при вычислении факториала
// Проблема в том что тип int (целое число) неспособен вместить в себя значение !17 и поэтому
// у !17 в коде (при вычисление) появляется уже отрицательное число -288522240 что не есть правильно...
Console.WriteLine("Вычисляем факториал используя тип значения переменной - int");
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"Число {i} и его факториал {Factorial01(i)}");
}
// ... проблему решает смена типа значения переменной на более "емкий" тип, например, - double
Console.WriteLine("Вычисляем факториал используя тип значения переменной - double");
for (double j = 1; j < 40; j++)
{
    Console.WriteLine($"Число {j} и его факториал {Factorial02(j)}");
}

// Задача. Числа Фибоначчи. Отрабатываем эффект рекурсиию
// Числа Фибонначи - где каждое следующее число задается через предыдущее число
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)
int Fibonacci01(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci01(n - 1) + Fibonacci01(n - 2);
}
for (int i = 1; i < 70; i++)
{
    Console.WriteLine($"№ {i} - {Fibonacci01(i)}");
}
// 63245986
// ... здесь есть один маленький момент - уже на 36-й итерации я получаю значительное замедление выполнения рекурсии 
// и дальше замедление растет в геометрической прогресии ...
double Fibonacci02(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci02(n - 1) + Fibonacci02(n - 2);
}
for (int i = 1; i < 70; i++)
{
    Console.WriteLine($"№ {i} - {Fibonacci01(i)}");
}

// УРОК 4. Семинар.
// Задача. Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А
// Например: 4 -> 10 т.е. (1+2+3+4=10)
int ControlUserInput01() // Определение метода - контроль ввода целого числа пользователем
{
    while (true)
    {
        Console.Write("Введите целое число: ");
        if (int.TryParse(Console.ReadLine(), out int userInt))   // параметр out в этой инструкции говорит о том, что переменная userInt
                                                                 // будет определена и ей будет присвоено значение внутри метода .TryParse                                                             // причем обязательно.
            return userInt;
        Console.WriteLine("Ошибка! Введите целое число: ");
    }
}
void SummInt(int userInt01) // Определение метода - вычисление суммы
{
    int result = 0;
    for (int i = 1; i <= userInt01; i++)
    {
        result += i;
    }
    Console.Write($"{userInt01} -> {result}");
}
int userInt01 = ControlUserInput01(); // Вызов метода
SummInt(userInt01); // Вызов метода

// Задача. Напишите программу, которая принимает на вход число и выдает количество цифр в числе
// Например: 456 -> 3
int ControlUserInput02(string msg, string errorMsg) // Определение метода - контроль ввода данных пользователем
{
    while (true)
    {
        Console.Write(msg);
        if (int.TryParse(Console.ReadLine(), out int userInput)) return userInput;
        Console.WriteLine(errorMsg);
    }
}
int Calculation01(int num) // Определение метода - вычисление количества цифр в числе
{
    int count = 0;
    while (num > 0)
    {
        count++; // Счетчик (инкремент)
        num /= 10;
    }
    return count;
}
void ResultOutput01(int result, int num) // Определение метода - вывод данных пользователю
{
    Console.WriteLine($"{num} -> {result}");
}

int userNum01 = ControlUserInput02("Введите целое число: ", "Ошибка! Введите целое число: "); // Вызов метода
int userResult01 = Calculation01(userNum01); // Вызов метода
ResultOutput01(userResult01, userNum01); // Вызов метода

// Задача. Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N
// Например: !5 -> 120
int ControlUserInput03(string msg, string errorMsg) // Определение метода - контроль ввода данных пользователем
{
    while (true)
    {
        Console.Write(msg);
        if (int.TryParse(Console.ReadLine(), out int userInput)) return userInput;
        Console.WriteLine(errorMsg);
    }
}
int Factorial03(int num) // Определение метода - вычисление факториала (используем эффект рекурсии)
{
    if (num == 1) return num;
    else return num * Factorial03(num - 1);
}
void ResultOutput02(int result, int num) // Определение метода - вывод данных пользователю
{
    Console.WriteLine($"!{num} -> {result}");
}

int userNum02 = ControlUserInput03("Введите целое число: ", "Ошибка! Введите целое число: ");
int userResult02 = Factorial03(userNum02);
ResultOutput02(userResult02, userNum02);

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
// Например: [1,0,1,1,0,1,0,0]
void FullArrayRandom(int[] array) // Определение метода - рандомное заполнение массива
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}
void ResultOutput03(int[] array) // Определение метода - вывод данных пользователю
{
    Console.WriteLine("Массив из 8 элементов заполненный рандомно значениями 0 и 1");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]},");
    }
}

int[] userArray01 = new int[8];
FullArrayRandom(userArray01);
ResultOutput03(userArray01);

// ДОМАШНИЕ ЗАДАЧИ.
// Задача. Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
// Например: 3, 5 -> 243 
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

int[] userArray02 = ControlUserInput04();
double userResult03 = NumPower(userArray02);
ResultOutput04(userArray02, userResult03);

// Задача. Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
// Например: 452 -> 11
int ControlUserInput05() // Определение метода - контроль ввода данных пользователя
{
    while (true)
    {
        Console.Write("Введите целое число: ");
        if (int.TryParse(Console.ReadLine(), out int userNum))
            return userNum;
        Console.WriteLine("Ошибка! Введите целое число: ");
    }
}
int SummNumOfTally(int num) // Определение метода - вычисление суммы цифр числа
{
    int result = 0;
    int numLenght = num.ToString().Length;
    for (int i = 0; i < numLenght; i++)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}
void ResultOutput05(int num, int result) // Определение метода - вывод данных пользователю
{
    System.Console.WriteLine($"{num} -> {result}");
}

int userNum03 = ControlUserInput05();
int userResult04 = SummNumOfTally(userNum03);
ResultOutput05(userNum03, userResult04);


// Задача. Напишите программу, которая задает массив из 8 элементов и выводит их на экран.