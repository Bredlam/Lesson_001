namespace Lesson_021;
class Program
{
    static void Main(string[] args)
    {
        // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
        // Например: А(3, 6, 8) / В(2, 1, -7) -> 15,84
        Console.Clear();        
        string[] nameCoordinates = {"x1","y1","z1","x2","y2","z2"};
        double[] coordinates = {0,0,0,0,0,0};

        UserControlInput(ref coordinates, nameCoordinates); // Вызов метода
        CalculatingLengthVector(coordinates); // Вызов метода

        static void UserControlInput(ref double[] coord, string[] nameCoord) // Определение метода - контроль ввода данных        
        {            
            for (int i = 0; i < coord.Length; i++)
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"Введите координаты {nameCoord[i]}: ");
                        coord[i] = double.Parse(Console.ReadLine() ?? "");
                        break;
                    }
                    catch (System.Exception exc)
                    {
                        Console.WriteLine($"Ошибка! Введите число {exc.Message}");                        
                    }
                }
            }

        }
        static void CalculatingLengthVector(double[] coord) // Определение метода - вычисления расстояния между 2-х точек в 3D пространсте
        {
            double result01 = 0;
            for (int i = 0; i < coord.Length-3; i++)
            {
                double result02 = Math.Pow(coord[i] - coord[i+3],2);
                result01  += result02;                
            }
            Console.Write($"{(Math.Sqrt(result01)):f2}");
        }
    }
}
