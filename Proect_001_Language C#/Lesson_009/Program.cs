
Console.Clear();
// Работа с массивами, база
/*int[] array0 = {1, 12, 31, 4, 15, 16, 17, 18}; // Обозначили массив - array и присвоили/передали в массив значения

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

// Работа с массивами и функциями/методами
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
Console.Write($"Позиция индекса в массиве где находится искомое значение = {pos}");
