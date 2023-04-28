﻿// УРОК 4. Лекция. Рекурсия и двумерные массивы
Console.Clear();
/*TwoDimensionalStringArray();
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
            if(matrix[rows02, colums02] == 0)
                matrix[rows02, colums02] = new Random().Next(100,1000); // не забывай, что вторая цифра не включается в интервал т.е. [100,1000)
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
            if(matr[i,j] == 0) Console.Write(" ");
            else Console.Write("+");
        }
        Console.WriteLine();
    }
}
void FullImage(int row, int col) // Определение метода - закрашиваем картинку
{
    if(pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FullImage(row-1,col);
        FullImage(row,col-1);
        FullImage(row+1,col);
        FullImage(row,col+1);
    }
}

// Задача. Вычисление факториала. Отрабатываем эффект рекурсии
int Factorial01(int n) // Определение метода - вычисление факториала, работаем с типом int
{
    if(n == 1) return 1;    // 1! = 1 (читается как: факториал единицы равен единице)
                            // Кстати, в общем случае 0! = 1
    else return n * Factorial01(n-1);
}
double Factorial02(double n) // Определение метода - вычисление факториала, работаем с типом double
{
    if(n == 1) return 1;    // 1! = 1 (читается как: факториал единицы равен единице)
                            // Кстати, в общем случае 0! = 1
    else return n * Factorial02(n-1);
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
    if(n == 1 || n == 2) return 1;
    else return Fibonacci01(n-1) + Fibonacci01(n-2);
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
    if(n == 1 || n == 2) return 1;
    else return Fibonacci02(n-1) + Fibonacci02(n-2);
}
for (int i = 1; i < 70; i++)
{
    Console.WriteLine($"№ {i} - {Fibonacci01(i)}");
} 
*/

// УРОК 4. Семинар.
// Задача. Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А
// Например: 4 -> 10 т.е. (1+2+3+4=10)
int ControlUserInput() // Определение метода - контроль ввода целого числа пользователем
{
    while (true)
    {
        Console.Write("Введите целое число: ");
        if(int.TryParse(Console.ReadLine(), out int userInt))   // параметр out в этой инструкции говорит о том, что переменная userInt
        // будет определена и ей будет присвоено значение внутри метода .TryParse                                                             // причем обязательно.
            return userInt;
        Console.WriteLine("Ошибка! Введите целое число: ");
    }
}
void SummInt(int userInt) // Определение метода - вычисление суммы
{
    int result = 0;
    for (int i = 1; i <= userInt; i++)
    {
        result += i; 
    }
    Console.Write($"{userInt} -> {result}");
}
int userInt = ControlUserInput(); // Вызов метода
SummInt(userInt); // Вызов метода


// Задача. Напишите программу, которая принимает на вход число и выдает количество цифр в числе
// Например: 456 -> 3


// Задача. Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N
// Например: !5 -> 120


// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
// Например: [1,0,1,1,0,1,0,0]