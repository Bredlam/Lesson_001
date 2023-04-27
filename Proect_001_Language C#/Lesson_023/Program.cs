namespace Lesson_023;
class Program
{
    static void Main(string[] args)
    {
        // Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N
        // Например: 5 -> 1, 8, 27, 64, 125

        int userNum = ControlUserInput(); // Вызов метода
        UserCalculations(userNum);

        static int ControlUserInput() // Определение метода - 
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите число: ");
                    int num = int.Parse(Console.ReadLine() ?? "");
                    return num;
                }
                catch (System.Exception exc)
                {
                    Console.WriteLine($"Ошибка! Введите число: {exc.Message}");
                }
            }
        }
        static void UserCalculations(int num) // Определение метода - 
        {
            for (int i = 1; i <= num; i++)
            {
                int result = Convert.ToInt32(Math.Pow(i,3));
                Console.Write($"{result}, ");
            }
        }
    }
}
