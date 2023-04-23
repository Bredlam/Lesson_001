Console.Clear();
/*// Работа с массивами, базовый уровень синтаксиса
int[] array0 = {1, 12, 31, 4, 15, 16, 17, 18}; // Обозначили массив - array и присвоили/передали в массив значения

int n = array0.Length; // Передали в переменную - n - значение длины массива (кол-во элементов массива)
int find = 4; // переменная с искомым значением

int index = 0; // переменная-счетчик которая будет работать по индексу в массиве

while (index < n)
{
    if (array0[index] == find)
    {
        Console.Write($"Указанное значение {find} присутствует в массиве");
        break; // оператор прерывания        
    }    
    index++;
}*/

/*// Работа с массивами и функциями/методами
void FillArray(int[] collection) //собственно имя функции/метода и ее параметры/агрументы
{
    int Length = collection.Length;
    int Index1 = 0;
    while (Index1 < Length)
    {
        collection[Index1] = new Random().Next(1, 10); // По указанному индексу кладем случайное число из диапазона 1-10
        Index1++; // счетчик цикла
    }
}

void PrintArray(int[] col)
{
    int coint = col.Length;
    int position = 0;
    while (position < coint)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] massiv, int Find01)
{
    int N01 = massiv.Length;
    int coint01 = 0;
    int SaveBox = -1;   // ввели начальное значение -1 чтобы если нет значений в массиве то выходило это базовое значение
                        // которое нам точно сообщит что искомого значения в массиве нет

    while (coint01 < N01)
    {
        if (Find01 == massiv[coint01])
        {
            SaveBox = coint01;
            break;            
        }
        coint01++;
    }
    return SaveBox;
}

int[] array = new int[10];  // Определили массив и определи что в массиве будет 10 элементов 
                            // т.е. - new int[10] - звучит так - создай новый массив с 10-ю элементам ... 
                            //по умолчанию элементы будут заполнены нулями

FillArray(array);
PrintArray(array);
Console.Write("Введите значение которое нужно найти в массиве: ");
int pos = IndexOf(array, int.Parse(Console.ReadLine() ?? ""));
Console.Write($"Позиция индекса в массиве где находится искомое значение = {pos}");*/

/*// Пример кода: циклический ввод переменной типа double - контроль ввода пользователем правильных данных
double varA; // память под вещественную (тип double) переменную выделена, но не инициализирована т.к. значение под нее введет пользователь
while (true) // бесконечный цикл
{
    Console.Write("Введите А: ");
    if (double.TryParse(Console.ReadLine(), out varA))  // в этой строке при вводе данных проверяется тип значения данных которые
                                                        // вводит пользователь и если при попытке преобразования - .TryParse получившийся
                                                        // тип значения не подходит под назначенный (в данном случае это double) в условие
                                                        // оператора if не выполняется и не происходит прерывание - break
                                                        // и у нас работает бесконечный цикл
    {
        break;
    }
    Console.WriteLine("Ошибка ввода!");
}
Console.WriteLine($"А={varA}");*/

// Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа, например:
/*// 78 -> 8 или 12 -> 2 или 75 -> 7
int num = new Random().Next(10, 100);
int a1 = num / 10;
int a2 = num % 10;
int max = a1;
if (max < a2) max = a2;
Console.WriteLine($"Максимальная цифра в числе {num} -> {max}");*/

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
/*// Например: 456 -> 46
int num01 = new Random().Next(100, 1000);
int a1 = num01 / 100; 
int a3 = num01 % 10;

int num02 = a1 * 10 + a3;

Console.WriteLine($"{num01}->{num02}");*/

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе
// число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
/*// Например: 34, 5 -> не кратно, остаток 4 или 16, 4 -> кратно
Console.Write("Введите первое число: ");
int UserInt01;
while (true)
{
    if (int.TryParse(Console.ReadLine(), out UserInt01))
    {
        break;
    }
    Console.WriteLine("Ошибка. Введите целое число!");
}

Console.Write("Введите второе число: ");
int UserInt02;
while (true)
{
    if (int.TryParse(Console.ReadLine(), out UserInt02))
    {
        break;
    }
    Console.WriteLine("Ошибка. Введите целое число!");
}

int Result = UserInt01 % UserInt02;
if (Result == 0)
{
    Console.Write($"{UserInt01}, {UserInt02} -> кратно");
}
else
{
    Console.Write($"{UserInt01}, {UserInt02} -> не кратно, остаток {Result}");
}*/

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
/*// 7 и 23. Например: 14 -> нет; 46 -> нет; 161 -> да
Console.Write("Введите число: ");
int UserInt;
while (true)
{
    if (int.TryParse(Console.ReadLine(), out UserInt))
    {
        break;
    }
    Console.WriteLine("Ощибка.Введите целое число!");
}

int ControlInt01 = 7;
int ControlInt02 = 23;

if (UserInt / ControlInt01 == ControlInt02 & UserInt / ControlInt02 == ControlInt01)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}*/